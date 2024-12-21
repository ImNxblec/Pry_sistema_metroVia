using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Timer = System.Windows.Forms.Timer;
using Pry_sistema_metroVia.Modelo;
using Pry_sistema_metroVia.Context;
using Pry_sistema_metroVia.Modelo;
using Pry_sistema_metroVia.Metodos;
using Pry_sistema_metroVia.Vista.Cliente;


namespace Pry_sistema_metroVia.Vista.Administrador
{
    public partial class frmRegistroCliente : Form
    {
        private VideoCapture capture; 
        private Mat frame; 
        private Timer timer; 
        private bool isCapturing;
        public int idCliente = 0;       

        public frmRegistroCliente()
        {
            InitializeComponent();

            button_camara.Text = "Iniciar Cámara";

            frame = new Mat();
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            isCapturing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloMayuscula(sender, e);
            NoNumeros(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloMayuscula(sender, e);
            NoNumeros(sender, e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteresPermitidos(sender, e);
        }

        public void SoloMayuscula(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public void NoNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ValidarCaracteresPermitidos(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLower(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void button_camara_Click(object sender, EventArgs e)
        {
            if (!isCapturing)
            {               
                capture = new VideoCapture(0);
                if (!capture.IsOpened())
                {
                    MessageBox.Show("No se pudo abrir la cámara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                isCapturing = true;
                timer.Start(); 
                button_camara.Text = "Capturar Foto"; 
            }
            else
            {               
                timer.Stop();
                isCapturing = false;

                if (!frame.Empty())
                {                    
                    pictureBox1.Image = BitmapConverter.ToBitmap(frame);
                   
                    //var result = MessageBox.Show("¿Desea guardar la foto capturada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if (result == DialogResult.Yes)
                    //{                        
                    //    GuardarEnRutaPredeterminada();                       
                    //}
                }
                pictureBox1.Image = pictureBox1.Image; 
                button_camara.Text = "Iniciar Cámara"; 
                capture.Release(); 
            }
        }

        private void frmRegistroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {           
            timer.Stop();
            capture?.Release();
        }

        private void GuardarEnRutaPredeterminada()
        {
            string carpeta = @"C:\Tftp\Fotos";
            string cedula1 = textBox_cedula.Text;
           
            if (frame == null || frame.Empty())
            {
                MessageBox.Show("Debe capturar una foto antes de guardarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (string.IsNullOrWhiteSpace(cedula1))
            {
                MessageBox.Show("La cédula no puede estar vacía. Por favor, ingrese la cédula antes de guardar la foto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
           
            string rutaPredeterminada = Path.Combine(carpeta, $"{cedula1}.jpg");
            frame.SaveImage(rutaPredeterminada);

            //MessageBox.Show($"Foto guardada correctamente en: {rutaPredeterminada}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (capture != null && capture.IsOpened())
            {
                capture.Read(frame);
                if (!frame.Empty())
                {
                    pictureBox1.Image = BitmapConverter.ToBitmap(frame);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            DateTime fechaHoraActual = DateTime.Now;
            QrGenerator QrGenerator = new QrGenerator();


            if (idCliente == 0)
            {               
                if (frame == null || frame.Empty())
                {
                    MessageBox.Show("Debe capturar una foto antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              
                if (string.IsNullOrWhiteSpace(textBox_cedula.Text))
                {
                    MessageBox.Show("La cédula no puede estar vacía. Por favor, ingrese la cédula antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                objUsuario.Cedula = textBox_cedula.Text;
                objUsuario.Nombre = textBox_nombre.Text;
                objUsuario.Apellido = textBox_apellido.Text;                
                objUsuario.Mail = textBox_correo.Text;
                objUsuario.Qr = null;
                objUsuario.Saldo = 0;
                objUsuario.FechaRegist = fechaHoraActual;
                objUsuario.CampoV01 = textBox_direccion.Text;
                objUsuario.CampoN01 = null;
                Utiles.contexto.Add(objUsuario);                
                Utiles.contexto.SaveChanges();
                textBox_cedula.Text = objUsuario.Cedula.ToString();
                GuardarEnRutaPredeterminada();

                var result = MessageBox.Show($"Desea imprimir código QR o escoja \"NO\" para enviar el código a su correo electrónico.", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {                   
                    var codeQR = QrGenerator.GenerateQRCode(objUsuario.Cedula);

                    string usuario = $"{textBox_nombre.Text} {textBox_apellido.Text} ";
                    frmDiseñorTarjetaQR tarjetaQRForm = new frmDiseñorTarjetaQR(codeQR, usuario);
                    tarjetaQRForm.ShowDialog(); 

                }
                else 
                {
                    MessageBox.Show("El código QR será enviado a su correo electrónico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }            
        }
    }
}
