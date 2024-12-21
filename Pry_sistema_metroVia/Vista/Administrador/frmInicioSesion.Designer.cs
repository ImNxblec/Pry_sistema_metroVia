namespace Pry_sistema_metroVia
{
    partial class frmInicioSesion
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
            textBox_usuario = new TextBox();
            textBox_clave = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox_usuario
            // 
            textBox_usuario.ForeColor = SystemColors.ActiveCaptionText;
            textBox_usuario.Location = new Point(65, 181);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.Size = new Size(207, 27);
            textBox_usuario.TabIndex = 1;
            textBox_usuario.Text = "   Ingrese Usuario";
            textBox_usuario.Click += textBox_usuario_Click;
            textBox_usuario.TextChanged += textBox1_TextChanged;
            // 
            // textBox_clave
            // 
            textBox_clave.ForeColor = SystemColors.ControlText;
            textBox_clave.Location = new Point(65, 225);
            textBox_clave.Name = "textBox_clave";
            textBox_clave.PasswordChar = '*';
            textBox_clave.Size = new Size(203, 27);
            textBox_clave.TabIndex = 2;
            textBox_clave.Text = "  Ingrese contraseña";
            textBox_clave.Click += textBox_clave_Click;
            // 
            // button1
            // 
            button1.Location = new Point(89, 278);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 3;
            button1.Text = "Inicio Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.user_icon_icons_com_57997__1_;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(96, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.KeyChainAccess_37052__1_;
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(29, 225);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Enabled = false;
            pictureBox3.Image = Properties.Resources.UsersFolder_256x256_icon_icons_com_76750;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(29, 176);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 341);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox_clave);
            Controls.Add(textBox_usuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_usuario;
        private TextBox textBox_clave;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}