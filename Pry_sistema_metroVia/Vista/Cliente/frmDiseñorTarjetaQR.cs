using QRCoder;
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
    public partial class frmDiseñorTarjetaQR : Form
    {
        public frmDiseñorTarjetaQR(Image qrImage, string usuario)
        {
            InitializeComponent();
            pictureBox_CodeQr.Image = qrImage;
            label2.Text = usuario;
        }
    }

    

}
