namespace Pry_sistema_metroVia.Vista.Administrador
{
    partial class frmDataGridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox_Buscar = new TextBox();
            panel2 = new Panel();
            button_nuevo = new Button();
            button_modificar = new Button();
            button_eliminar = new Button();
            button_salir = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_Buscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 27);
            panel1.TabIndex = 0;
            // 
            // textBox_Buscar
            // 
            textBox_Buscar.Dock = DockStyle.Top;
            textBox_Buscar.Location = new Point(0, 0);
            textBox_Buscar.Name = "textBox_Buscar";
            textBox_Buscar.Size = new Size(870, 27);
            textBox_Buscar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_nuevo);
            panel2.Controls.Add(button_modificar);
            panel2.Controls.Add(button_eliminar);
            panel2.Controls.Add(button_salir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 54);
            panel2.TabIndex = 1;
            // 
            // button_nuevo
            // 
            button_nuevo.Dock = DockStyle.Right;
            button_nuevo.Location = new Point(494, 0);
            button_nuevo.Name = "button_nuevo";
            button_nuevo.Size = new Size(94, 54);
            button_nuevo.TabIndex = 3;
            button_nuevo.Text = "Nuevo";
            button_nuevo.UseVisualStyleBackColor = true;
            // 
            // button_modificar
            // 
            button_modificar.Dock = DockStyle.Right;
            button_modificar.Location = new Point(588, 0);
            button_modificar.Name = "button_modificar";
            button_modificar.Size = new Size(94, 54);
            button_modificar.TabIndex = 2;
            button_modificar.Text = "Modificar";
            button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_eliminar
            // 
            button_eliminar.Dock = DockStyle.Right;
            button_eliminar.Location = new Point(682, 0);
            button_eliminar.Name = "button_eliminar";
            button_eliminar.Size = new Size(94, 54);
            button_eliminar.TabIndex = 1;
            button_eliminar.Text = "Eliminar";
            button_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            button_salir.Dock = DockStyle.Right;
            button_salir.Location = new Point(776, 0);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(94, 54);
            button_salir.TabIndex = 0;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(870, 283);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(870, 283);
            dataGridView1.TabIndex = 0;
            // 
            // frmDataGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 364);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDataGridView";
            Text = "Ventana de Información";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox_Buscar;
        private Panel panel2;
        private Button button_nuevo;
        private Button button_modificar;
        private Button button_eliminar;
        private Button button_salir;
        private Panel panel3;
        private DataGridView dataGridView1;
    }
}