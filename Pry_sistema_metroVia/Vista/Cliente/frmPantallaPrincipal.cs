using Pry_sistema_metroVia.Metodos;
using OpenCvSharp;
using OpenCvSharp.Aruco;
using OpenCvSharp.Extensions;
using System;
using System.Windows.Forms;
using Point = OpenCvSharp.Point;
using Pry_sistema_metroVia.Vista.Cliente;
using Pry_sistema_metroVia.Vista.Administrador;
using Pry_sistema_metroVia.Context;
using System.Web;


namespace Pry_sistema_metroVia
{

    public partial class frmPantallaPrincipal : Form
    {
        private VideoCapture capture;  // Par capturar el vido desde la camara
        private Mat frame;             // almacenar los fotogramas
        private QRCodeDetector detector;  // detectar y leer codigos QR
        private bool isCapturing = false;  // Indica si se está capturando video
        private bool form2Shown = false;
        private string ruta;
        private decimal saldoActual;

        public decimal SaldoRecargado { get; private set; } = 0; // Propiedad pública para acceder a SaldoRecargado




        public frmPantallaPrincipal()
        {
            InitializeComponent();
            capture = new VideoCapture(0);
            detector = new QRCodeDetector();
            Application.Idle += ProcessFrame;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
            if (!capture.IsOpened())
            {
                MessageBox.Show("No se pudo abrir la cámara.");
                return;
            }

            detector = new QRCodeDetector();
            isCapturing = true;
            Application.Idle += ProcessFrame;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            try
            {
                isCapturing = false;
                Application.Idle -= ProcessFrame;

                if (capture != null)
                {
                    if (capture.IsOpened())
                    {
                        capture.Release();
                    }
                    capture.Dispose();
                    capture = null;
                }

                Application.Exit();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error al detener la cámara: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ProcessFrame(object sender, EventArgs e)
        {
            string Tc_administrativa = "";

            if (capture == null || !capture.IsOpened())
            {
                return;
            }

            Mat frame = new Mat();
            capture.Read(frame);

            if (!frame.Empty())
            {
                string decodedText = string.Empty;
                Point2f[] points = null;

                decodedText = detector.DetectAndDecode(frame, out points);

                if (!string.IsNullOrEmpty(decodedText))
                {

                    var listaAdmin = Utiles.contexto.Admistradors.Where(r => r.CampoV01 == decodedText)
                           .Select(r => new { r.CampoV01 })
                           .ToList();

                    if (listaAdmin.Any())
                    {
                        Tc_administrativa = listaAdmin[0].CampoV01;
                    }

                    if (Tc_administrativa == decodedText && !form2Shown)
                    {
                        // ingreso al administrador
                        form2Shown = true;

                        if (capture != null && capture.IsOpened())
                        {
                            capture.Release();
                            capture.Dispose();
                            capture = null;
                        }

                        frmInicioSesion frmInicioSesion = new frmInicioSesion();
                        frmInicioSesion.FormClosed += (s, args) =>
                        {
                            form2Shown = false;
                            this.Show();
                            ReiniciarCaptura();
                        };

                        this.Hide();
                        frmInicioSesion.ShowDialog();

                    }
                    else
                    {
                        // PRIMERO HAY QUE CONSULTAR LA RUTA Y SACAR EL COSTO
                        // SEGUNDO CONSULTAR A USUARIO SI TIENE SALDO, SACAR EL SANDO Y RESTARLO CON EL VALRO DE LA RUTA
                        // TERCERO ACTUALIZAR EL SALDO DEL CLIENTE                         

                        Form existingFormRutas = Application.OpenForms.OfType<frmRutas>().FirstOrDefault();
                        string rutaSeleccionada;

                        if (existingFormRutas == null)
                        {
                            frmRutas newFormRutas = new frmRutas();
                            newFormRutas.ShowDialog();
                            rutaSeleccionada = newFormRutas.RutaSeleccionada;
                        }
                        else
                        {
                            existingFormRutas.BringToFront();
                            rutaSeleccionada = ((frmRutas)existingFormRutas).RutaSeleccionada;
                        }


                        if (!string.IsNullOrEmpty(rutaSeleccionada))
                        {
                            var listaRutas = Utiles.contexto.Ruta.Where(r => r.NombreRuta == rutaSeleccionada)
                            .Select(r => new { r.Costo })
                            .ToList();

                            if (listaRutas.Any())
                            {
                                textBox_valorPagar.Text = listaRutas[0].Costo.ToString("N2"); // Ejemplo: "1,234.56"
                            }

                            var listaUsuario = Utiles.contexto.Usuarios.Where(r => r.Cedula == decodedText)
                               .Select(r => new { r.Saldo })
                               .ToList();

                            if (listaUsuario.Any())
                            {
                                textBox_SaldoAntiguo.Text = listaUsuario[0].Saldo.ToString("N2"); // Ejemplo: "1,234.56"
                            }

                            if (decimal.TryParse(textBox_SaldoAntiguo.Text, out decimal valorAntiguo) &&
                                decimal.TryParse(textBox_valorPagar.Text, out decimal valorPago))
                            {
                                if (valorAntiguo <= 0m)
                                {
                                    label_Estado.Text = "RECARGUE POR FAVOR";
                                    await LimpiarCamposAsync();
                                }
                                else
                                {
                                    decimal totalRegesta = valorAntiguo - valorPago;
                                    textBox_saldoActual.Text = totalRegesta.ToString();

                                    // actualizr campo saldo del cliente
                                    var objUsuario_Upd = Utiles.contexto.Usuarios.Find(decodedText);
                                    objUsuario_Upd.Saldo = totalRegesta;
                                    Utiles.contexto.Usuarios.Update(objUsuario_Upd);
                                    Utiles.contexto.SaveChanges();

                                    label_Estado.Text = "INGRESE POR FAVOR";
                                    await LimpiarCamposAsync();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos de saldo y pago.",
                                                "Error de entrada",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            Console.WriteLine("No se seleccionó ninguna ruta.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se detectó ningún código QR.");
                }

                if (points != null && points.Length > 0)
                {
                    double contourArea = Cv2.ContourArea(points);

                    if (contourArea > 0.0)
                    {
                        for (int i = 0; i < points.Length; i++)
                        {
                            Cv2.Circle(frame, (int)points[i].X, (int)points[i].Y, 5, Scalar.Red, 2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Los puntos del QR son inválidos o no forman un contorno válido.");
                    }
                }
                else
                {
                    Console.WriteLine("No se detectaron puntos válidos para el QR.");
                }


                if (points != null && points.Length > 0)
                {
                    double contourArea = Cv2.ContourArea(points);
                    if (contourArea > 0.0)
                    {
                        for (int i = 0; i < points.Length; i++)
                        {
                            Cv2.Circle(frame, (int)points[i].X, (int)points[i].Y, 5, Scalar.Red, 2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Los puntos del QR son inválidos o no forman un contorno válido.");
                    }
                }

                pictureBox1.Image = BitmapConverter.ToBitmap(frame);
            }
        }
        private async Task LimpiarCamposAsync()
        {
            await Task.Delay(5000);
            textBox_saldoActual.Text = "";
            textBox_SaldoAntiguo.Text = "";
            textBox_valorPagar.Text = "";
            label_Estado.Text = "";
        }

        private void ReiniciarCaptura()
        {
            try
            {
                if (capture != null)
                {
                    if (capture.IsOpened())
                    {
                        capture.Release();
                    }
                    capture.Dispose();
                    capture = null;
                }

                capture = new VideoCapture(0);    // reifnicia la captura de vide
                if (!capture.IsOpened())
                {
                    MessageBox.Show("No se pudo abrir la cámara.");
                    return;
                }

                detector = new QRCodeDetector();
                isCapturing = true;
                Application.Idle += ProcessFrame;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reiniciar la captura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (capture != null)
                {
                    if (capture.IsOpened())
                    {
                        capture.Release();
                    }
                    capture.Dispose();
                    capture = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al liberar la cámara: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistroCliente frmRegistroCliente = new frmRegistroCliente();
            frmRegistroCliente.ShowDialog();
        }

        private void button_rutas_Click(object sender, EventArgs e)
        {
            frmRutas frmRutas = new frmRutas();

            frmRutas.ShowDialog();

            this.Close();
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            label_ruta_seleccionada.Text = ruta;
        }

        private void button_saldo_Click(object sender, EventArgs e)
        {
            frmConsultarSaldo frmConsultarSaldo = new frmConsultarSaldo();
            frmConsultarSaldo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRecargarSaldo frmRecargar = new frmRecargarSaldo(saldoActual); // Pasar el saldo actual
            if (frmRecargar.ShowDialog() == DialogResult.OK)
            {
                saldoActual += frmRecargar.SaldoRecargado; // Actualizar el saldo
                MessageBox.Show($"Recarga exitosa. Nuevo saldo: {saldoActual:C}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para actualizar el saldo
        private void ActualizarSaldo(decimal monto)
        {
            // Supongamos que tienes una variable lblSaldo para mostrar el saldo actual
            decimal saldoActual = decimal.Parse(textBox_SaldoAntiguo.Text); // Convierte el texto del label a decimal
            saldoActual += monto; // Suma el monto recargado al saldo actual
            textBox_SaldoAntiguo.Text = saldoActual.ToString("F2"); // Actualiza el label con el nuevo saldo
            MessageBox.Show($"Saldo actualizado con éxito. Nuevo saldo: {saldoActual:C2}", "Recarga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
