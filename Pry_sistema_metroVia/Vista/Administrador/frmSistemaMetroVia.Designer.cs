namespace Pry_sistema_metroVia.Vista.Administrador
{
    partial class frmSistemaMetroVia
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
            label_titulo = new Label();
            panel2 = new Panel();
            label_Tpproceso1 = new Label();
            button_nuevo = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_titulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 68);
            panel1.TabIndex = 0;
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titulo.Location = new Point(12, 12);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(435, 41);
            label_titulo.TabIndex = 0;
            label_titulo.Text = "SISTEMA ADMINISTRATIVO -";
            // 
            // panel2
            // 
            panel2.Controls.Add(label_Tpproceso1);
            panel2.Controls.Add(button_nuevo);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 67);
            panel2.TabIndex = 1;
            // 
            // label_Tpproceso1
            // 
            label_Tpproceso1.AutoSize = true;
            label_Tpproceso1.Location = new Point(12, 23);
            label_Tpproceso1.Name = "label_Tpproceso1";
            label_Tpproceso1.Size = new Size(50, 20);
            label_Tpproceso1.TabIndex = 3;
            label_Tpproceso1.Text = "label1";
            // 
            // button_nuevo
            // 
            button_nuevo.Dock = DockStyle.Right;
            button_nuevo.Location = new Point(271, 0);
            button_nuevo.Name = "button_nuevo";
            button_nuevo.Size = new Size(112, 67);
            button_nuevo.TabIndex = 0;
            button_nuevo.Text = "Nuevo";
            button_nuevo.UseVisualStyleBackColor = true;
            button_nuevo.Click += button_nuevo_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.Location = new Point(383, 0);
            button3.Name = "button3";
            button3.Size = new Size(117, 67);
            button3.TabIndex = 2;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(500, 0);
            button2.Name = "button2";
            button2.Size = new Size(112, 67);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(612, 0);
            button1.Name = "button1";
            button1.Size = new Size(117, 67);
            button1.TabIndex = 0;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(729, 28);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Right;
            textBox1.Location = new Point(22, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(707, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 3);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Busqueda...";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(729, 219);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(729, 219);
            dataGridView1.TabIndex = 0;
            // 
            // frmSistemaMetroVia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 382);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmSistemaMetroVia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Administrativo de la MetroVia";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button_nuevo;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label_titulo;
        private Panel panel3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Label label_Tpproceso1;
    }
}