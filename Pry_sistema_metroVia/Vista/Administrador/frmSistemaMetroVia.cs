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
using Pry_sistema_metroVia.Vista.Administrador;

namespace Pry_sistema_metroVia.Vista.Administrador
{
    public partial class frmSistemaMetroVia : Form
    {
        private string tpProcesData;


        public frmSistemaMetroVia(string tpProcesData)
        {
            InitializeComponent();
            this.tpProcesData = tpProcesData;
            CargarTituloFormulario(tpProcesData);
            RecargarDatosSuper(tpProcesData);
        }

        public void CargarTituloFormulario(string tpProcesData)
        {
            if (tpProcesData == "UA")
            {
                label_titulo.Text = "SISTEMA ADMINISTRATIVO - USUARIO ADMINISTRATIVO";
            }
            else if (tpProcesData == "UM")
            {
                label_titulo.Text = "SISTEMA ADMINISTRATIVO - USUARIO METROVIA";
            }
            else
            {
                MessageBox.Show("Error en el formulario frmSistemaMetroVia");
            }
        }

        public void RecargarDatosSuper(string tpProcesData)
        {
            if (tpProcesData == "UA")
            {
                var listaUsuarioAdmin = Utiles.contexto.Admistradors.Where(x => x.CampoN01.Contains("A")).ToList();
                dataGridView1.DataSource = listaUsuarioAdmin;
            }
            else if (tpProcesData == "UM")
            {
                var listaUsuarioMetroV = Utiles.contexto.Usuarios.Where(x => x.CampoN01.Contains("A")).ToList();
                dataGridView1.DataSource = listaUsuarioMetroV;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            if (tpProcesData == "UA")
            {
                frmUsuarios frmUsuarios = new frmUsuarios(tpProcesData, "N");
                frmUsuarios.ShowDialog();
            }
            else if (tpProcesData == "UM")
            {
                frmUsuarios frmUsuarios = new frmUsuarios(tpProcesData, "N");
                frmUsuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error en el evento del boton nuevo", "Advertencia");
            }
            RecargarDatosSuper(tpProcesData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tpProcesData == "UM")
            {
                string cellValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmUsuarios frmUsuarios = new frmUsuarios(tpProcesData, "M");
                frmUsuarios.cedulaId = cellValue;
                frmUsuarios.ShowDialog();
                RecargarDatosSuper(tpProcesData);

            }
            else if (tpProcesData == "UA")
            {
                int cellValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int id = Convert.ToInt32(cellValue);
                frmUsuarios frmUsuarios = new frmUsuarios(tpProcesData, "M");
                frmUsuarios.adminId = id;
                frmUsuarios.ShowDialog();
                RecargarDatosSuper(tpProcesData);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tpProcesData == "UA")
            {
                int cellValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int id = Convert.ToInt32(cellValue);

                var objUserAdmin = Utiles.contexto.Admistradors.Find(id);
                objUserAdmin.CampoN01 = "E";
                Utiles.contexto.Admistradors.Update(objUserAdmin);
                Utiles.contexto.SaveChanges();
                MessageBox.Show("El registro fue Actualizado con éxito!");

            }
            else if (tpProcesData == "UM")
            {
                string cellValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var objUserMetrov = Utiles.contexto.Usuarios.Find(cellValue);
                objUserMetrov.CampoN01 = "E";
                Utiles.contexto.SaveChanges();
                MessageBox.Show("El registro fue Actualizado con éxito!");
            }
            RecargarDatosSuper(tpProcesData);

        }
    }
}
