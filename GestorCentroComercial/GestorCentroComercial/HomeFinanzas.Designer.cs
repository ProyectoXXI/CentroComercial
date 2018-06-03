namespace GestorCentroComercial
{
    partial class HomeFinanzas
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
            this.bEmpleados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarPedidos = new System.Windows.Forms.Button();
            this.btnmostrarArtiucloscentro = new System.Windows.Forms.Button();
            this.btnmostrarProveedores = new System.Windows.Forms.Button();
            this.btnmostrarNominas = new System.Windows.Forms.Button();
            this.btnmostrarVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEmpleados
            // 
            this.bEmpleados.Location = new System.Drawing.Point(239, 115);
            this.bEmpleados.Name = "bEmpleados";
            this.bEmpleados.Size = new System.Drawing.Size(138, 33);
            this.bEmpleados.TabIndex = 13;
            this.bEmpleados.Text = "Mostrar Empleados";
            this.bEmpleados.UseVisualStyleBackColor = true;
            this.bEmpleados.Click += new System.EventHandler(this.bEmpleados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(132, 209);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 35);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarPedidos
            // 
            this.btnMostrarPedidos.Location = new System.Drawing.Point(7, 113);
            this.btnMostrarPedidos.Name = "btnMostrarPedidos";
            this.btnMostrarPedidos.Size = new System.Drawing.Size(138, 35);
            this.btnMostrarPedidos.TabIndex = 11;
            this.btnMostrarPedidos.Text = "Mostar Pedidos";
            this.btnMostrarPedidos.UseVisualStyleBackColor = true;
            this.btnMostrarPedidos.Click += new System.EventHandler(this.btnMostrarPedidos_Click);
            // 
            // btnmostrarArtiucloscentro
            // 
            this.btnmostrarArtiucloscentro.Location = new System.Drawing.Point(244, 74);
            this.btnmostrarArtiucloscentro.Name = "btnmostrarArtiucloscentro";
            this.btnmostrarArtiucloscentro.Size = new System.Drawing.Size(138, 35);
            this.btnmostrarArtiucloscentro.TabIndex = 10;
            this.btnmostrarArtiucloscentro.Text = "Mostrar Artiuclos del centro";
            this.btnmostrarArtiucloscentro.UseVisualStyleBackColor = true;
            this.btnmostrarArtiucloscentro.Click += new System.EventHandler(this.btnmostrarArtiucloscentro_Click);
            // 
            // btnmostrarProveedores
            // 
            this.btnmostrarProveedores.Location = new System.Drawing.Point(7, 72);
            this.btnmostrarProveedores.Name = "btnmostrarProveedores";
            this.btnmostrarProveedores.Size = new System.Drawing.Size(138, 35);
            this.btnmostrarProveedores.TabIndex = 9;
            this.btnmostrarProveedores.Text = "Mostrar Proveedores";
            this.btnmostrarProveedores.UseVisualStyleBackColor = true;
            this.btnmostrarProveedores.Click += new System.EventHandler(this.btnmostrarProveedores_Click);
            // 
            // btnmostrarNominas
            // 
            this.btnmostrarNominas.Location = new System.Drawing.Point(244, 31);
            this.btnmostrarNominas.Name = "btnmostrarNominas";
            this.btnmostrarNominas.Size = new System.Drawing.Size(138, 35);
            this.btnmostrarNominas.TabIndex = 8;
            this.btnmostrarNominas.Text = "Mostrar Nominas";
            this.btnmostrarNominas.UseVisualStyleBackColor = true;
            this.btnmostrarNominas.Click += new System.EventHandler(this.btnmostrarNominas_Click);
            // 
            // btnmostrarVentas
            // 
            this.btnmostrarVentas.Location = new System.Drawing.Point(7, 31);
            this.btnmostrarVentas.Name = "btnmostrarVentas";
            this.btnmostrarVentas.Size = new System.Drawing.Size(138, 35);
            this.btnmostrarVentas.TabIndex = 7;
            this.btnmostrarVentas.Text = "Mostar ventas";
            this.btnmostrarVentas.UseVisualStyleBackColor = true;
            this.btnmostrarVentas.Click += new System.EventHandler(this.btnmostrarVentas_Click);
            // 
            // HomeFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 256);
            this.Controls.Add(this.bEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarPedidos);
            this.Controls.Add(this.btnmostrarArtiucloscentro);
            this.Controls.Add(this.btnmostrarProveedores);
            this.Controls.Add(this.btnmostrarNominas);
            this.Controls.Add(this.btnmostrarVentas);
            this.Name = "HomeFinanzas";
            this.Text = "HomeFinanzas";
            this.Load += new System.EventHandler(this.HomeFinanzas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarPedidos;
        private System.Windows.Forms.Button btnmostrarArtiucloscentro;
        private System.Windows.Forms.Button btnmostrarProveedores;
        private System.Windows.Forms.Button btnmostrarNominas;
        private System.Windows.Forms.Button btnmostrarVentas;
    }
}