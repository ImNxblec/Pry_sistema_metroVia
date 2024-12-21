namespace Pry_sistema_metroVia.Vista.Cliente
{
    partial class frmDiseñorTarjetaQR
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
            pictureBox_CodeQr = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CodeQr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_CodeQr
            // 
            pictureBox_CodeQr.Location = new Point(38, 36);
            pictureBox_CodeQr.Name = "pictureBox_CodeQr";
            pictureBox_CodeQr.Size = new Size(304, 287);
            pictureBox_CodeQr.TabIndex = 2;
            pictureBox_CodeQr.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(381, 100);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 3;
            label1.Text = "Sistema de transporte";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.TBO51_7y_400x400;
            pictureBox1.Location = new Point(391, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 62);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(457, 328);
            label2.Name = "label2";
            label2.Size = new Size(255, 23);
            label2.TabIndex = 5;
            label2.Text = "Eddy Arturo Aliaga Bohorquez";
            // 
            // frmDiseñorTarjetaQR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.metrovia;
            ClientSize = new Size(724, 360);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox_CodeQr);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDiseñorTarjetaQR";
            Text = "Diseño de Tarjeta";
            ((System.ComponentModel.ISupportInitialize)pictureBox_CodeQr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox_CodeQr;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}