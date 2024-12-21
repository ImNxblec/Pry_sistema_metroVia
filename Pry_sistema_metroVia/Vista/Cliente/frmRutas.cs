using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pry_sistema_metroVia.Vista.Cliente
{
    public partial class frmRutas : Form
    {
        public string RutaSeleccionada { get; private set; }

        public frmRutas()
        {
            InitializeComponent();
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarOpcion("Parq_historico");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnviarOpcion("Santa_ana");           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnviarOpcion("Malecon");       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnviarOpcion("Parq_samanes");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnviarOpcion("Parq_seminario");
        }

        private void EnviarOpcion(string rutaAsignada) 
        {
            RutaSeleccionada = rutaAsignada; 
            this.Close(); 
        }
    }
}
