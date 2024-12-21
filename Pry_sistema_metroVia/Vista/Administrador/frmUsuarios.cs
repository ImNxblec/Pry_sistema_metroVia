using Pry_sistema_metroVia.Context;
using Pry_sistema_metroVia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Pry_sistema_metroVia.Vista.Administrador
{
    public partial class frmUsuarios : Form
    {
        private string tpeEvento;
        private string tpProceso;
        public int adminId = 0;
        public int id = 0;
        public string cedulaId = "";
        public frmUsuarios(string tpProceso, string tpeEvento)
        {
            InitializeComponent();

            this.tpeEvento = tpeEvento;
            this.tpProceso = tpProceso;
            this.adminId = id;
            this.cedulaId = cedulaId;

            // Usuario Administrativo
            label_id.Visible = false;
            textBox_id.Visible = false;
            label_usuarioAdmin.Visible = false;
            label_claveAdmin.Visible = false;
            label_cedulaAdmin.Visible = false;
            label_correoAdmin.Visible = false;
            label_OtrosAdmin.Visible = false;
            // Usuario MetroVia
            label_cedulaMetroV.Visible = false;
            label_nombreMetroV.Visible = false;
            label_apellidoMetroV.Visible = false;
            label_correoMetroV.Visible = false;
            label_saldoMetroV.Visible = false;
            label_direcionMetroV.Visible = false;

            ValidaCampoos(tpProceso, tpeEvento);
        }

        private void ValidaCampoos(string tpProceso, string tpeEvento)
        {

            if (tpProceso == "UA")
            {
                label_id.Visible = true;
                textBox_id.Visible = true;
                label_usuarioAdmin.Visible = true;
                label_claveAdmin.Visible = true;
                label_cedulaAdmin.Visible = true;
                label_correoAdmin.Visible = true;
                label_OtrosAdmin.Visible = true;
            }
            else if (tpProceso == "UM")
            {
                label_cedulaMetroV.Visible = true;
                textBox_id.Visible = true;
                label_nombreMetroV.Visible = true;
                label_apellidoMetroV.Visible = true;
                label_correoMetroV.Visible = true;
                label_saldoMetroV.Visible = true;
                label_direcionMetroV.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tpeEvento == "N" && tpProceso == "UA")
            {
                Admistrador objUsuarAdmin = new Admistrador();

                objUsuarAdmin.Nombre = textBox_campo1.Text;
                objUsuarAdmin.Contrasena = textBox_campo2.Text;
                objUsuarAdmin.Mail = textBox_campo4.Text;
                objUsuarAdmin.CampoV01 = textBox_campo3.Text;
                objUsuarAdmin.CampoN01 = "A";// textBox_campo5.Text;
                Utiles.contexto.Admistradors.Add(objUsuarAdmin);
                Utiles.contexto.SaveChanges();
                MessageBox.Show($"Se creó con éxito al jugador #{objUsuarAdmin.AdminId}");
            }
            else if (tpeEvento == "N" && tpProceso == "UM")
            {
                Usuario objUsuarMetroV = new Usuario();

                objUsuarMetroV.Cedula = textBox_id.Text;
                objUsuarMetroV.Nombre = textBox_campo1.Text;
                objUsuarMetroV.Apellido = textBox_campo2.Text;
                objUsuarMetroV.Mail = textBox_campo3.Text;

                // Convertir el texto del TextBox a decimal
                if (decimal.TryParse(textBox_campo4.Text, out decimal saldo))
                {
                    objUsuarMetroV.Saldo = saldo;
                }
                else
                {
                    MessageBox.Show("El valor ingresado en Saldo no es válido.");
                    return;
                }

                objUsuarMetroV.CampoV01 = textBox_campo5.Text;
                objUsuarMetroV.CampoN01 = "A";

                Utiles.contexto.Usuarios.Add(objUsuarMetroV);
                Utiles.contexto.SaveChanges();
                MessageBox.Show($"Se creó con éxito al jugador #{objUsuarMetroV.Cedula}");
            }
            else if (tpeEvento == "M" && tpProceso == "UA")
            {
                var objUserAdmin = Utiles.contexto.Admistradors.Find(adminId);
                objUserAdmin.Nombre = textBox_campo1.Text.Trim();
                objUserAdmin.Contrasena = textBox_campo2.Text.Trim();
                objUserAdmin.Mail = textBox_campo3.Text.Trim();
                objUserAdmin.CampoV01 = textBox_campo4.Text.Trim();
                objUserAdmin.CampoN01 = "A";//textBox_campo5.Text.Trim();                
                Utiles.contexto.Admistradors.Update(objUserAdmin);
                Utiles.contexto.SaveChanges();
                MessageBox.Show("El registro fue Actualizado con éxito!");

            }
            else if (tpeEvento == "M" && tpProceso == "UM")
            {
                var objUserMetrov = Utiles.contexto.Usuarios.Find(cedulaId);
                objUserMetrov.Nombre = textBox_campo1.Text.Trim();
                objUserMetrov.Apellido = textBox_campo2.Text.Trim();
                objUserMetrov.Mail = textBox_campo3.Text.Trim();
                
                // Convertir el texto del TextBox a decimal
                if (decimal.TryParse(textBox_campo4.Text, out decimal saldo))
                {
                    objUserMetrov.Saldo = saldo;
                }
                else
                {
                    MessageBox.Show("El valor ingresado en Saldo no es válido.");
                    return;
                }
                objUserMetrov.CampoV01 = textBox_campo5.Text.Trim();
                Utiles.contexto.SaveChanges();
                MessageBox.Show("El registro fue Actualizado con éxito!");
            }
            this.Close();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            if (tpProceso == "UM" && tpeEvento == "M")
            {
                var objUserMetroV = Utiles.contexto.Usuarios.Find(cedulaId);
                if (objUserMetroV != null)
                {
                    textBox_id.Text = objUserMetroV.Cedula.ToString();
                    textBox_campo1.Text = objUserMetroV.Nombre.ToString();
                    textBox_campo2.Text = objUserMetroV.Apellido.ToString();
                    textBox_campo3.Text = objUserMetroV.Mail;
                    textBox_campo4.Text = objUserMetroV.Saldo.ToString();
                    textBox_campo5.Text = objUserMetroV.CampoV01.ToString();
                }
                else
                {
                    MessageBox.Show($"No existe el registro {cedulaId}");
                    this.Close();
                }
            }
            else if (tpProceso == "UA" && tpeEvento == "M")
            {
                var objUserMetroV = Utiles.contexto.Admistradors.Find(adminId);
                if (objUserMetroV != null)
                {
                    textBox_id.Text = objUserMetroV.AdminId.ToString();
                    textBox_campo1.Text = objUserMetroV.Nombre.ToString();
                    textBox_campo2.Text = objUserMetroV.Contrasena.ToString();
                    textBox_campo3.Text = objUserMetroV.Mail;
                    textBox_campo4.Text = objUserMetroV.CampoV01.ToString();
                }
                else
                {
                    MessageBox.Show($"No existe el registro {adminId}");
                    this.Close();
                }
            }            
        }
    }
}
