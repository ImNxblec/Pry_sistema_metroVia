namespace Pry_sistema_metroVia.Vista.Administrador
{
    partial class frmAdministrador
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
            button1 = new Button();
            button_ConsulUser = new Button();
            button_AddUser = new Button();
            button_transacciones = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button_ConsulUser);
            panel1.Controls.Add(button_AddUser);
            panel1.Controls.Add(button_transacciones);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 95);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.sign_emergency_code_Salir;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1069, 0);
            button1.Name = "button1";
            button1.Size = new Size(113, 95);
            button1.TabIndex = 3;
            button1.Text = "Salir ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_ConsulUser
            // 
            button_ConsulUser.Dock = DockStyle.Left;
            button_ConsulUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ConsulUser.Image = Properties.Resources.business_man_usersearch_thesearch_theclient_2356;
            button_ConsulUser.ImageAlign = ContentAlignment.MiddleLeft;
            button_ConsulUser.Location = new Point(461, 0);
            button_ConsulUser.Name = "button_ConsulUser";
            button_ConsulUser.Size = new Size(226, 95);
            button_ConsulUser.TabIndex = 2;
            button_ConsulUser.Text = "Usuarios MetroVia ";
            button_ConsulUser.TextAlign = ContentAlignment.MiddleRight;
            button_ConsulUser.UseVisualStyleBackColor = true;
            button_ConsulUser.Click += button_ConsulUser_Click;
            // 
            // button_AddUser
            // 
            button_AddUser.Dock = DockStyle.Left;
            button_AddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddUser.Image = Properties.Resources.addusergroup_1251;
            button_AddUser.ImageAlign = ContentAlignment.MiddleLeft;
            button_AddUser.Location = new Point(240, 0);
            button_AddUser.Name = "button_AddUser";
            button_AddUser.Size = new Size(221, 95);
            button_AddUser.TabIndex = 1;
            button_AddUser.Text = "Usuarios Admin ";
            button_AddUser.TextAlign = ContentAlignment.MiddleRight;
            button_AddUser.UseVisualStyleBackColor = true;
            button_AddUser.Click += button_AddUser_Click;
            // 
            // button_transacciones
            // 
            button_transacciones.Dock = DockStyle.Left;
            button_transacciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_transacciones.Image = Properties.Resources.route_icon_129308__1_;
            button_transacciones.ImageAlign = ContentAlignment.MiddleLeft;
            button_transacciones.Location = new Point(0, 0);
            button_transacciones.Name = "button_transacciones";
            button_transacciones.Size = new Size(240, 95);
            button_transacciones.TabIndex = 0;
            button_transacciones.Text = "Historial por rutas  ";
            button_transacciones.TextAlign = ContentAlignment.MiddleRight;
            button_transacciones.UseVisualStyleBackColor = true;
            button_transacciones.Click += button_transacciones_Click;
            // 
            // frmAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 745);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "frmAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consola administrativa";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_AddUser;
        private Button button_transacciones;
        private Button button_ConsulUser;
        private Button button1;
    }
}