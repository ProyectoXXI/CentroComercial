namespace GestorCentroComercial
{
    partial class Pedidos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fechaPedidoLabel;
            System.Windows.Forms.Label codigoProveedorLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label codigoPedidoLabel;
            System.Windows.Forms.Label codigoArticuloLabel;
            System.Windows.Forms.Label unidadesLabel;
            System.Windows.Forms.Label precioCosteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.consultas = new GestorCentroComercial.Consultas();
            this.articulosProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosProveedoresTableAdapter = new GestorCentroComercial.ConsultasTableAdapters.ArticulosProveedoresTableAdapter();
            this.tableAdapterManager = new GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager();
            this.articulosProveedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.articulosProveedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.articulosProveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedidoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codigoProveedorTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.codigoPedidoTextBox = new System.Windows.Forms.TextBox();
            this.codigoArticuloTextBox = new System.Windows.Forms.TextBox();
            this.unidadesTextBox = new System.Windows.Forms.TextBox();
            this.precioCosteTextBox = new System.Windows.Forms.TextBox();
            fechaPedidoLabel = new System.Windows.Forms.Label();
            codigoProveedorLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            codigoPedidoLabel = new System.Windows.Forms.Label();
            codigoArticuloLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            precioCosteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosProveedoresBindingNavigator)).BeginInit();
            this.articulosProveedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosProveedoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaPedidoLabel
            // 
            fechaPedidoLabel.AutoSize = true;
            fechaPedidoLabel.BackColor = System.Drawing.Color.Transparent;
            fechaPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaPedidoLabel.ForeColor = System.Drawing.Color.White;
            fechaPedidoLabel.Location = new System.Drawing.Point(12, 74);
            fechaPedidoLabel.Name = "fechaPedidoLabel";
            fechaPedidoLabel.Size = new System.Drawing.Size(111, 20);
            fechaPedidoLabel.TabIndex = 2;
            fechaPedidoLabel.Text = "Fecha Pedido:";
            // 
            // codigoProveedorLabel
            // 
            codigoProveedorLabel.AutoSize = true;
            codigoProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            codigoProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoProveedorLabel.ForeColor = System.Drawing.Color.White;
            codigoProveedorLabel.Location = new System.Drawing.Point(12, 111);
            codigoProveedorLabel.Name = "codigoProveedorLabel";
            codigoProveedorLabel.Size = new System.Drawing.Size(139, 20);
            codigoProveedorLabel.TabIndex = 4;
            codigoProveedorLabel.Text = "Codigo Proveedor:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.BackColor = System.Drawing.Color.Transparent;
            descuentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descuentoLabel.ForeColor = System.Drawing.Color.White;
            descuentoLabel.Location = new System.Drawing.Point(12, 151);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(91, 20);
            descuentoLabel.TabIndex = 6;
            descuentoLabel.Text = "Descuento:";
            // 
            // codigoPedidoLabel
            // 
            codigoPedidoLabel.AutoSize = true;
            codigoPedidoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoPedidoLabel.ForeColor = System.Drawing.Color.White;
            codigoPedidoLabel.Location = new System.Drawing.Point(410, 52);
            codigoPedidoLabel.Name = "codigoPedidoLabel";
            codigoPedidoLabel.Size = new System.Drawing.Size(116, 20);
            codigoPedidoLabel.TabIndex = 8;
            codigoPedidoLabel.Text = "Codigo Pedido:";
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.BackColor = System.Drawing.Color.Transparent;
            codigoArticuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoArticuloLabel.ForeColor = System.Drawing.Color.White;
            codigoArticuloLabel.Location = new System.Drawing.Point(410, 89);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(120, 20);
            codigoArticuloLabel.TabIndex = 10;
            codigoArticuloLabel.Text = "Codigo Articulo:";
            // 
            // unidadesLabel
            // 
            unidadesLabel.AutoSize = true;
            unidadesLabel.BackColor = System.Drawing.Color.Transparent;
            unidadesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidadesLabel.ForeColor = System.Drawing.Color.White;
            unidadesLabel.Location = new System.Drawing.Point(410, 130);
            unidadesLabel.Name = "unidadesLabel";
            unidadesLabel.Size = new System.Drawing.Size(81, 20);
            unidadesLabel.TabIndex = 12;
            unidadesLabel.Text = "Unidades:";
            // 
            // precioCosteLabel
            // 
            precioCosteLabel.AutoSize = true;
            precioCosteLabel.BackColor = System.Drawing.Color.Transparent;
            precioCosteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioCosteLabel.ForeColor = System.Drawing.Color.White;
            precioCosteLabel.Location = new System.Drawing.Point(410, 164);
            precioCosteLabel.Name = "precioCosteLabel";
            precioCosteLabel.Size = new System.Drawing.Size(103, 20);
            precioCosteLabel.TabIndex = 14;
            precioCosteLabel.Text = "Precio Coste:";
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosProveedoresBindingSource
            // 
            this.articulosProveedoresBindingSource.DataMember = "ArticulosProveedores";
            this.articulosProveedoresBindingSource.DataSource = this.consultas;
            // 
            // articulosProveedoresTableAdapter
            // 
            this.articulosProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticulosCentroComercialTableAdapter = null;
            this.tableAdapterManager.ArticulosProveedoresTableAdapter = this.articulosProveedoresTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // articulosProveedoresBindingNavigator
            // 
            this.articulosProveedoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.articulosProveedoresBindingNavigator.BindingSource = this.articulosProveedoresBindingSource;
            this.articulosProveedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.articulosProveedoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.articulosProveedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.articulosProveedoresBindingNavigatorSaveItem});
            this.articulosProveedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.articulosProveedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.articulosProveedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.articulosProveedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.articulosProveedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.articulosProveedoresBindingNavigator.Name = "articulosProveedoresBindingNavigator";
            this.articulosProveedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.articulosProveedoresBindingNavigator.Size = new System.Drawing.Size(776, 25);
            this.articulosProveedoresBindingNavigator.TabIndex = 0;
            this.articulosProveedoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // articulosProveedoresBindingNavigatorSaveItem
            // 
            this.articulosProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.articulosProveedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("articulosProveedoresBindingNavigatorSaveItem.Image")));
            this.articulosProveedoresBindingNavigatorSaveItem.Name = "articulosProveedoresBindingNavigatorSaveItem";
            this.articulosProveedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.articulosProveedoresBindingNavigatorSaveItem.Text = "Save Data";
            this.articulosProveedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.articulosProveedoresBindingNavigatorSaveItem_Click);
            // 
            // articulosProveedoresDataGridView
            // 
            this.articulosProveedoresDataGridView.AutoGenerateColumns = false;
            this.articulosProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosProveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.articulosProveedoresDataGridView.DataSource = this.articulosProveedoresBindingSource;
            this.articulosProveedoresDataGridView.Location = new System.Drawing.Point(12, 229);
            this.articulosProveedoresDataGridView.Name = "articulosProveedoresDataGridView";
            this.articulosProveedoresDataGridView.Size = new System.Drawing.Size(743, 303);
            this.articulosProveedoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FechaPedido";
            this.dataGridViewTextBoxColumn1.HeaderText = "FechaPedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProveedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoProveedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descuento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodigoPedido";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodigoPedido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodigoArticulo";
            this.dataGridViewTextBoxColumn5.HeaderText = "CodigoArticulo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Unidades";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PrecioCoste";
            this.dataGridViewTextBoxColumn7.HeaderText = "PrecioCoste";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // fechaPedidoDateTimePicker
            // 
            this.fechaPedidoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.articulosProveedoresBindingSource, "FechaPedido", true));
            this.fechaPedidoDateTimePicker.Location = new System.Drawing.Point(155, 73);
            this.fechaPedidoDateTimePicker.Name = "fechaPedidoDateTimePicker";
            this.fechaPedidoDateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.fechaPedidoDateTimePicker.TabIndex = 3;
            // 
            // codigoProveedorTextBox
            // 
            this.codigoProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosProveedoresBindingSource, "CodigoProveedor", true));
            this.codigoProveedorTextBox.Location = new System.Drawing.Point(155, 111);
            this.codigoProveedorTextBox.Name = "codigoProveedorTextBox";
            this.codigoProveedorTextBox.Size = new System.Drawing.Size(219, 20);
            this.codigoProveedorTextBox.TabIndex = 5;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosProveedoresBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(155, 151);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(219, 20);
            this.descuentoTextBox.TabIndex = 7;
            // 
            // codigoPedidoTextBox
            // 
            this.codigoPedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosProveedoresBindingSource, "CodigoPedido", true));
            this.codigoPedidoTextBox.Location = new System.Drawing.Point(532, 52);
            this.codigoPedidoTextBox.Name = "codigoPedidoTextBox";
            this.codigoPedidoTextBox.Size = new System.Drawing.Size(223, 20);
            this.codigoPedidoTextBox.TabIndex = 9;
            // 
            // codigoArticuloTextBox
            // 
            this.codigoArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosProveedoresBindingSource, "CodigoArticulo", true));
            this.codigoArticuloTextBox.Location = new System.Drawing.Point(532, 89);
            this.codigoArticuloTextBox.Name = "codigoArticuloTextBox";
            this.codigoArticuloTextBox.Size = new System.Drawing.Size(223, 20);
            this.codigoArticuloTextBox.TabIndex = 11;
            // 
            // unidadesTextBox
            // 
            this.unidadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosProveedoresBindingSource, "Unidades", true));
            this.unidadesTextBox.Location = new System.Drawing.Point(532, 130);
            this.unidadesTextBox.Name = "unidadesTextBox";
            this.unidadesTextBox.Size = new System.Drawing.Size(223, 20);
            this.unidadesTextBox.TabIndex = 13;
            // 
            // precioCosteTextBox
            // 
            this.precioCosteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosProveedoresBindingSource, "PrecioCoste", true));
            this.precioCosteTextBox.Location = new System.Drawing.Point(532, 164);
            this.precioCosteTextBox.Name = "precioCosteTextBox";
            this.precioCosteTextBox.Size = new System.Drawing.Size(223, 20);
            this.precioCosteTextBox.TabIndex = 15;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorCentroComercial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(776, 552);
            this.Controls.Add(fechaPedidoLabel);
            this.Controls.Add(this.fechaPedidoDateTimePicker);
            this.Controls.Add(codigoProveedorLabel);
            this.Controls.Add(this.codigoProveedorTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(codigoPedidoLabel);
            this.Controls.Add(this.codigoPedidoTextBox);
            this.Controls.Add(codigoArticuloLabel);
            this.Controls.Add(this.codigoArticuloTextBox);
            this.Controls.Add(unidadesLabel);
            this.Controls.Add(this.unidadesTextBox);
            this.Controls.Add(precioCosteLabel);
            this.Controls.Add(this.precioCosteTextBox);
            this.Controls.Add(this.articulosProveedoresDataGridView);
            this.Controls.Add(this.articulosProveedoresBindingNavigator);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosProveedoresBindingNavigator)).EndInit();
            this.articulosProveedoresBindingNavigator.ResumeLayout(false);
            this.articulosProveedoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosProveedoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultas consultas;
        private System.Windows.Forms.BindingSource articulosProveedoresBindingSource;
        private ConsultasTableAdapters.ArticulosProveedoresTableAdapter articulosProveedoresTableAdapter;
        private ConsultasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator articulosProveedoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton articulosProveedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView articulosProveedoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DateTimePicker fechaPedidoDateTimePicker;
        private System.Windows.Forms.TextBox codigoProveedorTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox codigoPedidoTextBox;
        private System.Windows.Forms.TextBox codigoArticuloTextBox;
        private System.Windows.Forms.TextBox unidadesTextBox;
        private System.Windows.Forms.TextBox precioCosteTextBox;
    }
}