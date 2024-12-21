namespace Pry_sistema_metroVia
{
    partial class frmPantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_valorPagar = new TextBox();
            label3 = new Label();
            textBox_SaldoAntiguo = new TextBox();
            btnDetener = new Button();
            textBox_saldoActual = new TextBox();
            label4 = new Label();
            button_saldo = new Button();
            label_ruta_seleccionada = new Label();
            label_Estado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Image = Properties.Resources.wallet_payment_purchase_coin_cash_money_icon_141978;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Image = Properties.Resources.records_notes_journal_edited_9479;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // textBox_valorPagar
            // 
            resources.ApplyResources(textBox_valorPagar, "textBox_valorPagar");
            textBox_valorPagar.ForeColor = Color.Lime;
            textBox_valorPagar.Name = "textBox_valorPagar";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Transparent;
            label3.Name = "label3";
            // 
            // textBox_SaldoAntiguo
            // 
            resources.ApplyResources(textBox_SaldoAntiguo, "textBox_SaldoAntiguo");
            textBox_SaldoAntiguo.ForeColor = Color.FromArgb(0, 0, 192);
            textBox_SaldoAntiguo.Name = "textBox_SaldoAntiguo";
            // 
            // btnDetener
            // 
            resources.ApplyResources(btnDetener, "btnDetener");
            btnDetener.Image = Properties.Resources.sign_emergency_code_Salir;
            btnDetener.Name = "btnDetener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // textBox_saldoActual
            // 
            resources.ApplyResources(textBox_saldoActual, "textBox_saldoActual");
            textBox_saldoActual.ForeColor = SystemColors.MenuText;
            textBox_saldoActual.Name = "textBox_saldoActual";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Name = "label4";
            // 
            // button_saldo
            // 
            resources.ApplyResources(button_saldo, "button_saldo");
            button_saldo.Image = Properties.Resources.money_dollar_cash_coins_riches_wealth_icon_icons_com_53585__1_;
            button_saldo.Name = "button_saldo";
            button_saldo.UseVisualStyleBackColor = true;
            button_saldo.Click += button_saldo_Click;
            // 
            // label_ruta_seleccionada
            // 
            resources.ApplyResources(label_ruta_seleccionada, "label_ruta_seleccionada");
            label_ruta_seleccionada.BackColor = Color.Transparent;
            label_ruta_seleccionada.ForeColor = Color.Transparent;
            label_ruta_seleccionada.Name = "label_ruta_seleccionada";
            // 
            // label_Estado
            // 
            resources.ApplyResources(label_Estado, "label_Estado");
            label_Estado.BackColor = Color.Transparent;
            label_Estado.ForeColor = Color.Lime;
            label_Estado.Name = "label_Estado";
            // 
            // frmPantallaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.metrovia;
            ControlBox = false;
            Controls.Add(label_Estado);
            Controls.Add(label_ruta_seleccionada);
            Controls.Add(button_saldo);
            Controls.Add(textBox_saldoActual);
            Controls.Add(label4);
            Controls.Add(textBox_SaldoAntiguo);
            Controls.Add(label3);
            Controls.Add(textBox_valorPagar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnDetener);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmPantallaPrincipal";
            FormClosed += Form1_FormClosed;
            Load += frmPantallaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox_valorPagar;
        private Label label3;
        private TextBox textBox_SaldoAntiguo;
        private Button btnDetener;
        private TextBox textBox_saldoActual;
        private Label label4;
        private Button button_saldo;
        private Label label_ruta_seleccionada;
        private Label label_Estado;
    }
}
