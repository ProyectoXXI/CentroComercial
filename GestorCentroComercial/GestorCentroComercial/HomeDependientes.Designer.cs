namespace GestorCentroComercial
{
    partial class HomeDependientes
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
            this.bMostrarNominas = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bAddVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMostrarNominas
            // 
            this.bMostrarNominas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bMostrarNominas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMostrarNominas.ForeColor = System.Drawing.Color.White;
            this.bMostrarNominas.Location = new System.Drawing.Point(46, 30);
            this.bMostrarNominas.Name = "bMostrarNominas";
            this.bMostrarNominas.Size = new System.Drawing.Size(149, 90);
            this.bMostrarNominas.TabIndex = 0;
            this.bMostrarNominas.Text = "Nóminas";
            this.bMostrarNominas.UseVisualStyleBackColor = false;
            this.bMostrarNominas.Click += new System.EventHandler(this.bMostrarNominas_Click);
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.White;
            this.bSalir.Location = new System.Drawing.Point(276, 30);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(114, 215);
            this.bSalir.TabIndex = 2;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bAddVenta
            // 
            this.bAddVenta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bAddVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddVenta.ForeColor = System.Drawing.Color.White;
            this.bAddVenta.Location = new System.Drawing.Point(46, 155);
            this.bAddVenta.Name = "bAddVenta";
            this.bAddVenta.Size = new System.Drawing.Size(149, 90);
            this.bAddVenta.TabIndex = 3;
            this.bAddVenta.Text = "Ventas";
            this.bAddVenta.UseVisualStyleBackColor = false;
            this.bAddVenta.Click += new System.EventHandler(this.bAddVenta_Click);
            // 
            // HomeDependientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorCentroComercial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(435, 293);
            this.Controls.Add(this.bAddVenta);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bMostrarNominas);
            this.Name = "HomeDependientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeDependientes";
            this.Load += new System.EventHandler(this.HomeDependientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMostrarNominas;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bAddVenta;
    }
}