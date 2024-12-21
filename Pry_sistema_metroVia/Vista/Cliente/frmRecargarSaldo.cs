using OpenCvSharp;
using OpenCvSharp.Extensions;
using Pry_sistema_metroVia.Context;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pry_sistema_metroVia.Vista.Cliente
{
    public partial class frmRecargarSaldo : Form
    {
        private VideoCapture capture;  // Captura de video
        private QRCodeDetector detector;  // Detector de códigos QR
        private decimal saldoActual; // Almacena el saldo actual
        public decimal SaldoRecargado { get; private set; } // Almacena el saldo recargado

        public frmRecargarSaldo(decimal saldo)
        {
            InitializeComponent();
            saldoActual = saldo; // Inicializar saldoActual
            SaldoRecargado = saldoActual; // Inicializar SaldoRecargado con el saldo actual
            detector = new QRCodeDetector();
            capture = new VideoCapture(0); // Abrir la cámara
            if (!capture.IsOpened())
            {
                MessageBox.Show("No se pudo abrir la cámara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Idle += ProcessFrame; // Procesar el frame de la cámara
        }

        private async void ProcessFrame(object sender, EventArgs e)
        {
            if (capture == null || !capture.IsOpened())
            {
                return;
            }

            Mat frame = new Mat();
            capture.Read(frame);  // Capturar un frame de la cámara

            if (!frame.Empty())
            {
                string decodedText = string.Empty;
                Point2f[] points = null;

                decodedText = detector.DetectAndDecode(frame, out points);  // Detectar y decodificar el QR

                if (!string.IsNullOrEmpty(decodedText))
                {
                    // Aquí puedes validar el código QR
                    var usuario = Utiles.contexto.Usuarios.Where(r => r.Cedula == decodedText).FirstOrDefault();

                    if (usuario != null)
                    {
                        saldoActual = usuario.Saldo; // Obtener saldo del usuario
                        SaldoRecargado = saldoActual;
                        // Actualizar el saldo en el Label
                        txtMontoFinal.Text = $"Saldo actual: {SaldoRecargado:C}";
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Mostrar el video en el PictureBox
                pictureBox1.Image = BitmapConverter.ToBitmap(frame);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha ingresado un monto válido
            if (decimal.TryParse(txtMonto.Text, out decimal monto) && monto > 0)
            {
                // Verificar si el monto no supera el límite máximo
                decimal limiteMaximo = 1000;
                if (monto <= limiteMaximo)
                {
                    // Código de administrador predefinido o generado previamente
                    string codigoValido = "ADMIN123"; // Este puede ser un valor codificado, QR escaneado, etc.

                    // Aquí no se solicita un código, simplemente se usa el código predefinido
                    if (codigoValido == "ADMIN123") // Si el código es el correcto
                    {
                        // Si el código es válido, proceder con la recarga
                        saldoActual += monto; // Se agrega el monto al saldo actual
                        SaldoRecargado = saldoActual; // Actualizar el saldo recargado
                        txtMontoFinal.Text = $"Saldo actual: {SaldoRecargado:C}"; // Actualizar el saldo en el Label
                        this.DialogResult = DialogResult.OK; // Cerrar el formulario con resultado OK
                        this.Close();
                    }
                    else
                    {
                        // Si el código es incorrecto, mostrar mensaje de error
                        MessageBox.Show("El código del administrador es incorrecto. No se puede realizar la recarga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si el monto excede el límite, mostrar mensaje de error
                    MessageBox.Show($"El monto no puede ser superior a {limiteMaximo:C}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el monto no es válido, mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRecargarSaldo_Load(object sender, EventArgs e)
        {
            // Mostrar el saldo actual en el Label correspondiente
            txtMontoFinal.Text = $"Saldo actual: {saldoActual:C}"; // Mostrar saldo como moneda en el Label
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            // Liberar la cámara al cerrar el formulario
            if (capture != null && capture.IsOpened())
            {
                capture.Release();
                capture.Dispose();
            }
        }
    }
}



