using Pry_sistema_metroVia.Context;
using Pry_sistema_metroVia.Vista.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_sistema_metroVia
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string clave = textBox_clave.Text;

            var listaAdmin = Utiles.contexto.Admistradors
                .Where(r => r.Nombre == usuario && r.Contrasena == clave)
                .Select(r => new { r.CampoN01 })
                .ToList();

            if (listaAdmin.Any())
            {
                this.Hide();
                frmAdministrador frmAdministrador = new frmAdministrador();
                frmAdministrador.ShowDialog();
                frmAdministrador.Hide();
            }
            else
            {                
                MessageBox.Show("Por favor ingrese correctamente el usuario y clave por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_usuario_Click(object sender, EventArgs e)
        {
            textBox_usuario.Text = "";
        }

        private void textBox_clave_Click(object sender, EventArgs e)
        {
            textBox_clave.Text = "";
        }
    }
}
