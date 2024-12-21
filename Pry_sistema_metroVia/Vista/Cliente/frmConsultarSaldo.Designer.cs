namespace Pry_sistema_metroVia.Vista.Cliente
{
    partial class frmConsultarSaldo
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
            label1 = new Label();
            textBox_cedula = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label_consultarSaldo = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(39, 158);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 11;
            label1.Text = "Ingrese Cedula: ";
            // 
            // textBox_cedula
            // 
            textBox_cedula.ForeColor = SystemColors.ControlText;
            textBox_cedula.Location = new Point(194, 159);
            textBox_cedula.Name = "textBox_cedula";
            textBox_cedula.Size = new Size(175, 27);
            textBox_cedula.TabIndex = 16;
            textBox_cedula.TextChanged += textBox_cedula_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(299, 41);
            label2.TabIndex = 17;
            label2.Text = "CONSULTAR SALDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(134, 82);
            label3.Name = "label3";
            label3.Size = new Size(35, 41);
            label3.TabIndex = 18;
            label3.Text = "$";
            // 
            // label_consultarSaldo
            // 
            label_consultarSaldo.AutoSize = true;
            label_consultarSaldo.BackColor = Color.Transparent;
            label_consultarSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_consultarSaldo.ForeColor = Color.FromArgb(0, 192, 0);
            label_consultarSaldo.ImeMode = ImeMode.NoControl;
            label_consultarSaldo.Location = new Point(175, 82);
            label_consultarSaldo.Name = "label_consultarSaldo";
            label_consultarSaldo.Size = new Size(26, 41);
            label_consultarSaldo.TabIndex = 19;
            label_consultarSaldo.Text = ".";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 70);
            panel1.TabIndex = 20;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(393, 70);
            button1.TabIndex = 0;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmConsultarSaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 286);
            Controls.Add(panel1);
            Controls.Add(label_consultarSaldo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_cedula);
            Controls.Add(label1);
            Name = "frmConsultarSaldo";
            Text = "frmConsultarSaldo";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_cedula;
        private Label label2;
        private Label label3;
        private Label label_consultarSaldo;
        private Panel panel1;
        private Button button1;
    }
}