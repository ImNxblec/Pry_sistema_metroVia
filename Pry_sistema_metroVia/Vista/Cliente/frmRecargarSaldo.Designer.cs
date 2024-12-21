namespace Pry_sistema_metroVia.Vista.Cliente
{
    partial class frmRecargarSaldo
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
            txtSaldoActual = new TextBox();
            txtMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMontoFinal = new TextBox();
            pictureBox1 = new PictureBox();
            btnRecargar = new Button();
            btnDetener = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtSaldoActual.Location = new Point(621, 112);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.Size = new Size(100, 36);
            txtSaldoActual.TabIndex = 0;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtMonto.Location = new Point(621, 180);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 36);
            txtMonto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(421, 183);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 2;
            label1.Text = "Monto a recargar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(464, 115);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 3;
            label2.Text = "Monto actual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(482, 254);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 4;
            label3.Text = "Monto final";
            // 
            // txtMontoFinal
            // 
            txtMontoFinal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtMontoFinal.Location = new Point(621, 251);
            txtMontoFinal.Name = "txtMontoFinal";
            txtMontoFinal.Size = new Size(100, 36);
            txtMontoFinal.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(39, 46);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnRecargar
            // 
            btnRecargar.BackgroundImage = Properties.Resources.money_dollar_cash_coins_riches_wealth_icon_icons_com_53585;
            btnRecargar.BackgroundImageLayout = ImageLayout.None;
            btnRecargar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRecargar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecargar.ImeMode = ImeMode.NoControl;
            btnRecargar.Location = new Point(431, 368);
            btnRecargar.Margin = new Padding(3, 2, 3, 2);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(146, 48);
            btnRecargar.TabIndex = 7;
            btnRecargar.Text = "Recargar";
            btnRecargar.TextAlign = ContentAlignment.MiddleRight;
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnAceptar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackgroundImage = Properties.Resources.sign_emergency_code_Salir;
            btnDetener.BackgroundImageLayout = ImageLayout.None;
            btnDetener.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDetener.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetener.ImeMode = ImeMode.NoControl;
            btnDetener.Location = new Point(245, 368);
            btnDetener.Margin = new Padding(3, 2, 3, 2);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(147, 48);
            btnDetener.TabIndex = 8;
            btnDetener.Text = "Salir        ";
            btnDetener.TextAlign = ContentAlignment.MiddleRight;
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // frmRecargarSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.metrovia;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDetener);
            Controls.Add(btnRecargar);
            Controls.Add(pictureBox1);
            Controls.Add(txtMontoFinal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(txtSaldoActual);
            Name = "frmRecargarSaldo";
            Text = "frmRecargar";
            Load += frmRecargarSaldo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSaldoActual;
        private TextBox txtMonto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMontoFinal;
        private PictureBox pictureBox1;
        private Button btnRecargar;
        private Button btnDetener;
    }
}