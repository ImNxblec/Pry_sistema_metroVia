using Pry_sistema_metroVia.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_sistema_metroVia.Vista.Cliente
{
    public partial class frmConsultarSaldo : Form
    {
        public frmConsultarSaldo()
        {
            InitializeComponent();
        }

        private void textBox_cedula_TextChanged(object sender, EventArgs e)
        {
            string cedulaId = textBox_cedula.Text;


            var objUserMetroV = Utiles.contexto.Usuarios
                .Where(x => x.Cedula.Contains(cedulaId))
                .Select(s => new { s.Saldo })
                .ToList();


            if (objUserMetroV.Any())
            {
                label_consultarSaldo.Text = objUserMetroV[0].Saldo.ToString("F2");
            }
            else
            {

                label_consultarSaldo.Text = "Saldo no encontrado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
