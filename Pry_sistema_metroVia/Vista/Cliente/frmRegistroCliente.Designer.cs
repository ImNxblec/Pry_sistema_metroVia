namespace Pry_sistema_metroVia.Vista.Administrador
{
    partial class frmRegistroCliente
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_cedula = new TextBox();
            textBox_nombre = new TextBox();
            textBox_apellido = new TextBox();
            textBox_correo = new TextBox();
            textBox_direccion = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            button_camara = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(45, 28);
            label2.Name = "label2";
            label2.Size = new Size(281, 41);
            label2.TabIndex = 8;
            label2.Text = "Registro de cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(45, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(375, 101);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 10;
            label1.Text = "Cedula o";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(375, 240);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 11;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(375, 184);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 12;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(388, 297);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 13;
            label5.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(367, 349);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 14;
            label6.Text = "Direccion:";
            // 
            // textBox_cedula
            // 
            textBox_cedula.ForeColor = SystemColors.ControlText;
            textBox_cedula.Location = new Point(479, 115);
            textBox_cedula.Name = "textBox_cedula";
            textBox_cedula.Size = new Size(175, 27);
            textBox_cedula.TabIndex = 15;
            // 
            // textBox_nombre
            // 
            textBox_nombre.ForeColor = SystemColors.ControlText;
            textBox_nombre.Location = new Point(479, 184);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(292, 27);
            textBox_nombre.TabIndex = 16;
            textBox_nombre.KeyPress += textBox2_KeyPress;
            // 
            // textBox_apellido
            // 
            textBox_apellido.ForeColor = SystemColors.ControlText;
            textBox_apellido.Location = new Point(479, 240);
            textBox_apellido.Name = "textBox_apellido";
            textBox_apellido.Size = new Size(292, 27);
            textBox_apellido.TabIndex = 17;
            textBox_apellido.KeyPress += textBox3_KeyPress;
            // 
            // textBox_correo
            // 
            textBox_correo.ForeColor = SystemColors.ControlText;
            textBox_correo.Location = new Point(479, 297);
            textBox_correo.Name = "textBox_correo";
            textBox_correo.Size = new Size(348, 27);
            textBox_correo.TabIndex = 18;
            textBox_correo.KeyPress += textBox4_KeyPress;
            // 
            // textBox_direccion
            // 
            textBox_direccion.ForeColor = SystemColors.ControlText;
            textBox_direccion.Location = new Point(479, 353);
            textBox_direccion.Name = "textBox_direccion";
            textBox_direccion.Size = new Size(348, 27);
            textBox_direccion.TabIndex = 19;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button1.Location = new Point(707, 401);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 20;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button2.Location = new Point(560, 401);
            button2.Name = "button2";
            button2.Size = new Size(121, 45);
            button2.TabIndex = 21;
            button2.Text = "Grabar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(367, 131);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 23;
            label7.Text = "Pasaporte:";
            // 
            // button_camara
            // 
            button_camara.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button_camara.Image = Properties.Resources.camara;
            button_camara.ImageAlign = ContentAlignment.MiddleLeft;
            button_camara.Location = new Point(45, 397);
            button_camara.Name = "button_camara";
            button_camara.Size = new Size(269, 53);
            button_camara.TabIndex = 24;
            button_camara.UseVisualStyleBackColor = true;
            button_camara.Click += button_camara_Click;
            // 
            // frmRegistroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 471);
            Controls.Add(button_camara);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_direccion);
            Controls.Add(textBox_correo);
            Controls.Add(textBox_apellido);
            Controls.Add(textBox_nombre);
            Controls.Add(textBox_cedula);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_cedula;
        private TextBox textBox_nombre;
        private TextBox textBox_apellido;
        private TextBox textBox_correo;
        private TextBox textBox_direccion;
        private Button button1;
        private Button button2;
        private Label label7;
        private Button button_camara;
    }
}