using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_sistema_metroVia.Vista.Administrador
{
    public partial class frmAdministrador : Form
    {
        private frmDataGridView frmDataGridView;
        private frmSistemaMetroVia frmUserAdmin;
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void button_transacciones_Click(object sender, EventArgs e)
        {
            if (frmDataGridView == null || frmDataGridView.IsDisposed)
            {
                frmDataGridView = new frmDataGridView();
                frmDataGridView.MdiParent = this;
                frmDataGridView.Size = new Size(888, 411);
                frmDataGridView.StartPosition = FormStartPosition.CenterParent;
                frmDataGridView.Show();
            }
            else
            {
                frmDataGridView.BringToFront();
            }
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            if (frmUserAdmin == null || frmUserAdmin.IsDisposed)
            {
                frmUserAdmin = new frmSistemaMetroVia("UA");
                frmUserAdmin.MdiParent = this;
                frmUserAdmin.Size = new Size(747, 429);
                frmUserAdmin.StartPosition = FormStartPosition.CenterParent;
                frmUserAdmin.Show();
            }
            else
            {
                frmDataGridView.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ConsulUser_Click(object sender, EventArgs e)
        {
            if (frmUserAdmin == null || frmUserAdmin.IsDisposed)
            {
                frmUserAdmin = new frmSistemaMetroVia("UM");
                frmUserAdmin.MdiParent = this;
                frmUserAdmin.Size = new Size(747, 429);
                frmUserAdmin.StartPosition = FormStartPosition.CenterParent;
                frmUserAdmin.Show();
            }
            else
            {
                frmDataGridView.BringToFront();
            }

        }
    }
}
