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
            this.bMostrarVentas = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMostrarNominas
            // 
            this.bMostrarNominas.Location = new System.Drawing.Point(46, 30);
            this.bMostrarNominas.Name = "bMostrarNominas";
            this.bMostrarNominas.Size = new System.Drawing.Size(114, 79);
            this.bMostrarNominas.TabIndex = 0;
            this.bMostrarNominas.Text = "Mostrar Nóminas";
            this.bMostrarNominas.UseVisualStyleBackColor = true;
            // 
            // bMostrarVentas
            // 
            this.bMostrarVentas.Location = new System.Drawing.Point(235, 30);
            this.bMostrarVentas.Name = "bMostrarVentas";
            this.bMostrarVentas.Size = new System.Drawing.Size(117, 79);
            this.bMostrarVentas.TabIndex = 1;
            this.bMostrarVentas.Text = "Mostrar Ventas";
            this.bMostrarVentas.UseVisualStyleBackColor = true;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(139, 148);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(127, 62);
            this.bSalir.TabIndex = 2;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // HomeDependientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 239);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bMostrarVentas);
            this.Controls.Add(this.bMostrarNominas);
            this.Name = "HomeDependientes";
            this.Text = "HomeDependientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMostrarNominas;
        private System.Windows.Forms.Button bMostrarVentas;
        private System.Windows.Forms.Button bSalir;
    }
}