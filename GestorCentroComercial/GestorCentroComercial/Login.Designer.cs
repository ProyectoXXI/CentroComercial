namespace GestorCentroComercial
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.consultas1 = new GestorCentroComercial.Consultas();
            this.empleadoTableAdapter1 = new GestorCentroComercial.ConsultasTableAdapters.EmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultas1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(101, 59);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(240, 22);
            this.tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(96, 155);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(245, 22);
            this.tbPass.TabIndex = 3;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(61, 214);
            this.bLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(117, 43);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(264, 214);
            this.bExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(129, 42);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Salir";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // consultas1
            // 
            this.consultas1.DataSetName = "Consultas";
            this.consultas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoTableAdapter1
            // 
            this.empleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.consultas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bExit;
        private Consultas consultas1;
        private ConsultasTableAdapters.EmpleadoTableAdapter empleadoTableAdapter1;
    }
}

