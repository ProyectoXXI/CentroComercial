namespace GestorCentroComercial
{
    partial class HomeTecnicos
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
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.btnmostrarPedidos = new System.Windows.Forms.Button();
            this.btnmostrarArticulos = new System.Windows.Forms.Button();
            this.btnmostrarProveedores = new System.Windows.Forms.Button();
            this.btnmostrarNominas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.Location = new System.Drawing.Point(47, 39);
            this.btnMostrarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Size = new System.Drawing.Size(171, 43);
            this.btnMostrarVentas.TabIndex = 0;
            this.btnMostrarVentas.Text = "Mostrar Ventas";
            this.btnMostrarVentas.UseVisualStyleBackColor = true;
            // 
            // btnmostrarPedidos
            // 
            this.btnmostrarPedidos.Location = new System.Drawing.Point(47, 170);
            this.btnmostrarPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmostrarPedidos.Name = "btnmostrarPedidos";
            this.btnmostrarPedidos.Size = new System.Drawing.Size(171, 43);
            this.btnmostrarPedidos.TabIndex = 1;
            this.btnmostrarPedidos.Text = "Mostrar Pedidos de Proveedores";
            this.btnmostrarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnmostrarArticulos
            // 
            this.btnmostrarArticulos.Location = new System.Drawing.Point(365, 103);
            this.btnmostrarArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmostrarArticulos.Name = "btnmostrarArticulos";
            this.btnmostrarArticulos.Size = new System.Drawing.Size(171, 43);
            this.btnmostrarArticulos.TabIndex = 2;
            this.btnmostrarArticulos.Text = "Mostrar Articulos de centro";
            this.btnmostrarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnmostrarProveedores
            // 
            this.btnmostrarProveedores.Location = new System.Drawing.Point(47, 103);
            this.btnmostrarProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmostrarProveedores.Name = "btnmostrarProveedores";
            this.btnmostrarProveedores.Size = new System.Drawing.Size(171, 43);
            this.btnmostrarProveedores.TabIndex = 3;
            this.btnmostrarProveedores.Text = "Mostrar Proveedores";
            this.btnmostrarProveedores.UseVisualStyleBackColor = true;
            // 
            // btnmostrarNominas
            // 
            this.btnmostrarNominas.Location = new System.Drawing.Point(365, 39);
            this.btnmostrarNominas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmostrarNominas.Name = "btnmostrarNominas";
            this.btnmostrarNominas.Size = new System.Drawing.Size(171, 43);
            this.btnmostrarNominas.TabIndex = 4;
            this.btnmostrarNominas.Text = "Mostrar Nominas";
            this.btnmostrarNominas.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(365, 170);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // HomeTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 294);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnmostrarNominas);
            this.Controls.Add(this.btnmostrarProveedores);
            this.Controls.Add(this.btnmostrarArticulos);
            this.Controls.Add(this.btnmostrarPedidos);
            this.Controls.Add(this.btnMostrarVentas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeTecnicos";
            this.Text = "HomeTecnicos";
            this.Load += new System.EventHandler(this.HomeTecnicos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarVentas;
        private System.Windows.Forms.Button btnmostrarPedidos;
        private System.Windows.Forms.Button btnmostrarArticulos;
        private System.Windows.Forms.Button btnmostrarProveedores;
        private System.Windows.Forms.Button btnmostrarNominas;
        private System.Windows.Forms.Button btnSalir;
    }
}