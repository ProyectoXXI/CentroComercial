namespace GestorCentroComercial
{
    partial class VentasDependiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasDependiente));
            System.Windows.Forms.Label fechaVentaLabel;
            System.Windows.Forms.Label codigCentroLabel;
            System.Windows.Forms.Label codigoDependienteLabel;
            System.Windows.Forms.Label dniClienteLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label codigoVentaLabel;
            System.Windows.Forms.Label codigoArticuloLabel;
            System.Windows.Forms.Label unidadesLabel;
            System.Windows.Forms.Label precioFinalLabel;
            this.consultas = new GestorCentroComercial.Consultas();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new GestorCentroComercial.ConsultasTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager();
            this.ventasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ventasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ventasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosCentroComercialTableAdapter1 = new GestorCentroComercial.ConsultasTableAdapters.ArticulosCentroComercialTableAdapter();
            this.fechaVentaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codigCentroTextBox = new System.Windows.Forms.TextBox();
            this.codigoDependienteTextBox = new System.Windows.Forms.TextBox();
            this.dniClienteTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.codigoVentaTextBox = new System.Windows.Forms.TextBox();
            this.codigoArticuloTextBox = new System.Windows.Forms.TextBox();
            this.unidadesTextBox = new System.Windows.Forms.TextBox();
            this.precioFinalTextBox = new System.Windows.Forms.TextBox();
            fechaVentaLabel = new System.Windows.Forms.Label();
            codigCentroLabel = new System.Windows.Forms.Label();
            codigoDependienteLabel = new System.Windows.Forms.Label();
            dniClienteLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            codigoVentaLabel = new System.Windows.Forms.Label();
            codigoArticuloLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            precioFinalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingNavigator)).BeginInit();
            this.ventasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.consultas;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticulosCentroComercialTableAdapter = null;
            this.tableAdapterManager.ArticulosProveedoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = this.ventasTableAdapter;
            // 
            // ventasBindingNavigator
            // 
            this.ventasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ventasBindingNavigator.BindingSource = this.ventasBindingSource;
            this.ventasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ventasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ventasBindingNavigatorSaveItem});
            this.ventasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ventasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ventasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ventasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ventasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ventasBindingNavigator.Name = "ventasBindingNavigator";
            this.ventasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ventasBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.ventasBindingNavigator.TabIndex = 0;
            this.ventasBindingNavigator.Text = "bindingNavigator1";
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
            // ventasBindingNavigatorSaveItem
            // 
            this.ventasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasBindingNavigatorSaveItem.Image")));
            this.ventasBindingNavigatorSaveItem.Name = "ventasBindingNavigatorSaveItem";
            this.ventasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ventasBindingNavigatorSaveItem.Text = "Save Data";
            this.ventasBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventasBindingNavigatorSaveItem_Click);
            // 
            // ventasDataGridView
            // 
            this.ventasDataGridView.AutoGenerateColumns = false;
            this.ventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.ventasDataGridView.DataSource = this.ventasBindingSource;
            this.ventasDataGridView.Location = new System.Drawing.Point(12, 316);
            this.ventasDataGridView.Name = "ventasDataGridView";
            this.ventasDataGridView.Size = new System.Drawing.Size(776, 220);
            this.ventasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FechaVenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "FechaVenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigCentro";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigCentro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoDependiente";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodigoDependiente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DniCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "DniCliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descuento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CodigoVenta";
            this.dataGridViewTextBoxColumn6.HeaderText = "CodigoVenta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CodigoArticulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "CodigoArticulo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Unidades";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PrecioFinal";
            this.dataGridViewTextBoxColumn9.HeaderText = "PrecioFinal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // articulosCentroComercialTableAdapter1
            // 
            this.articulosCentroComercialTableAdapter1.ClearBeforeFill = true;
            // 
            // fechaVentaLabel
            // 
            fechaVentaLabel.AutoSize = true;
            fechaVentaLabel.Location = new System.Drawing.Point(30, 56);
            fechaVentaLabel.Name = "fechaVentaLabel";
            fechaVentaLabel.Size = new System.Drawing.Size(71, 13);
            fechaVentaLabel.TabIndex = 2;
            fechaVentaLabel.Text = "Fecha Venta:";
            // 
            // fechaVentaDateTimePicker
            // 
            this.fechaVentaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "FechaVenta", true));
            this.fechaVentaDateTimePicker.Location = new System.Drawing.Point(143, 52);
            this.fechaVentaDateTimePicker.Name = "fechaVentaDateTimePicker";
            this.fechaVentaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaVentaDateTimePicker.TabIndex = 3;
            // 
            // codigCentroLabel
            // 
            codigCentroLabel.AutoSize = true;
            codigCentroLabel.Location = new System.Drawing.Point(30, 81);
            codigCentroLabel.Name = "codigCentroLabel";
            codigCentroLabel.Size = new System.Drawing.Size(71, 13);
            codigCentroLabel.TabIndex = 4;
            codigCentroLabel.Text = "Codig Centro:";
            // 
            // codigCentroTextBox
            // 
            this.codigCentroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigCentro", true));
            this.codigCentroTextBox.Location = new System.Drawing.Point(143, 78);
            this.codigCentroTextBox.Name = "codigCentroTextBox";
            this.codigCentroTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigCentroTextBox.TabIndex = 5;
            // 
            // codigoDependienteLabel
            // 
            codigoDependienteLabel.AutoSize = true;
            codigoDependienteLabel.Location = new System.Drawing.Point(30, 107);
            codigoDependienteLabel.Name = "codigoDependienteLabel";
            codigoDependienteLabel.Size = new System.Drawing.Size(107, 13);
            codigoDependienteLabel.TabIndex = 6;
            codigoDependienteLabel.Text = "Codigo Dependiente:";
            // 
            // codigoDependienteTextBox
            // 
            this.codigoDependienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigoDependiente", true));
            this.codigoDependienteTextBox.Location = new System.Drawing.Point(143, 104);
            this.codigoDependienteTextBox.Name = "codigoDependienteTextBox";
            this.codigoDependienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoDependienteTextBox.TabIndex = 7;
            // 
            // dniClienteLabel
            // 
            dniClienteLabel.AutoSize = true;
            dniClienteLabel.Location = new System.Drawing.Point(30, 133);
            dniClienteLabel.Name = "dniClienteLabel";
            dniClienteLabel.Size = new System.Drawing.Size(61, 13);
            dniClienteLabel.TabIndex = 8;
            dniClienteLabel.Text = "Dni Cliente:";
            // 
            // dniClienteTextBox
            // 
            this.dniClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "DniCliente", true));
            this.dniClienteTextBox.Location = new System.Drawing.Point(143, 130);
            this.dniClienteTextBox.Name = "dniClienteTextBox";
            this.dniClienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniClienteTextBox.TabIndex = 9;
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(30, 159);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(62, 13);
            descuentoLabel.TabIndex = 10;
            descuentoLabel.Text = "Descuento:";
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(143, 156);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoTextBox.TabIndex = 11;
            // 
            // codigoVentaLabel
            // 
            codigoVentaLabel.AutoSize = true;
            codigoVentaLabel.Location = new System.Drawing.Point(30, 185);
            codigoVentaLabel.Name = "codigoVentaLabel";
            codigoVentaLabel.Size = new System.Drawing.Size(74, 13);
            codigoVentaLabel.TabIndex = 12;
            codigoVentaLabel.Text = "Codigo Venta:";
            // 
            // codigoVentaTextBox
            // 
            this.codigoVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigoVenta", true));
            this.codigoVentaTextBox.Location = new System.Drawing.Point(143, 182);
            this.codigoVentaTextBox.Name = "codigoVentaTextBox";
            this.codigoVentaTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoVentaTextBox.TabIndex = 13;
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.Location = new System.Drawing.Point(30, 211);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(81, 13);
            codigoArticuloLabel.TabIndex = 14;
            codigoArticuloLabel.Text = "Codigo Articulo:";
            // 
            // codigoArticuloTextBox
            // 
            this.codigoArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigoArticulo", true));
            this.codigoArticuloTextBox.Location = new System.Drawing.Point(143, 208);
            this.codigoArticuloTextBox.Name = "codigoArticuloTextBox";
            this.codigoArticuloTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoArticuloTextBox.TabIndex = 15;
            // 
            // unidadesLabel
            // 
            unidadesLabel.AutoSize = true;
            unidadesLabel.Location = new System.Drawing.Point(30, 237);
            unidadesLabel.Name = "unidadesLabel";
            unidadesLabel.Size = new System.Drawing.Size(55, 13);
            unidadesLabel.TabIndex = 16;
            unidadesLabel.Text = "Unidades:";
            // 
            // unidadesTextBox
            // 
            this.unidadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Unidades", true));
            this.unidadesTextBox.Location = new System.Drawing.Point(143, 234);
            this.unidadesTextBox.Name = "unidadesTextBox";
            this.unidadesTextBox.Size = new System.Drawing.Size(200, 20);
            this.unidadesTextBox.TabIndex = 17;
            // 
            // precioFinalLabel
            // 
            precioFinalLabel.AutoSize = true;
            precioFinalLabel.Location = new System.Drawing.Point(30, 263);
            precioFinalLabel.Name = "precioFinalLabel";
            precioFinalLabel.Size = new System.Drawing.Size(65, 13);
            precioFinalLabel.TabIndex = 18;
            precioFinalLabel.Text = "Precio Final:";
            // 
            // precioFinalTextBox
            // 
            this.precioFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "PrecioFinal", true));
            this.precioFinalTextBox.Location = new System.Drawing.Point(143, 260);
            this.precioFinalTextBox.Name = "precioFinalTextBox";
            this.precioFinalTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioFinalTextBox.TabIndex = 19;
            // 
            // VentasDependiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 548);
            this.Controls.Add(fechaVentaLabel);
            this.Controls.Add(this.fechaVentaDateTimePicker);
            this.Controls.Add(codigCentroLabel);
            this.Controls.Add(this.codigCentroTextBox);
            this.Controls.Add(codigoDependienteLabel);
            this.Controls.Add(this.codigoDependienteTextBox);
            this.Controls.Add(dniClienteLabel);
            this.Controls.Add(this.dniClienteTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(codigoVentaLabel);
            this.Controls.Add(this.codigoVentaTextBox);
            this.Controls.Add(codigoArticuloLabel);
            this.Controls.Add(this.codigoArticuloTextBox);
            this.Controls.Add(unidadesLabel);
            this.Controls.Add(this.unidadesTextBox);
            this.Controls.Add(precioFinalLabel);
            this.Controls.Add(this.precioFinalTextBox);
            this.Controls.Add(this.ventasDataGridView);
            this.Controls.Add(this.ventasBindingNavigator);
            this.Name = "VentasDependiente";
            this.Text = "VentasDependiente";
            this.Load += new System.EventHandler(this.VentasDependiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingNavigator)).EndInit();
            this.ventasBindingNavigator.ResumeLayout(false);
            this.ventasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultas consultas;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private ConsultasTableAdapters.VentasTableAdapter ventasTableAdapter;
        private ConsultasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ventasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ventasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ventasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private ConsultasTableAdapters.ArticulosCentroComercialTableAdapter articulosCentroComercialTableAdapter1;
        private System.Windows.Forms.DateTimePicker fechaVentaDateTimePicker;
        private System.Windows.Forms.TextBox codigCentroTextBox;
        private System.Windows.Forms.TextBox codigoDependienteTextBox;
        private System.Windows.Forms.TextBox dniClienteTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox codigoVentaTextBox;
        private System.Windows.Forms.TextBox codigoArticuloTextBox;
        private System.Windows.Forms.TextBox unidadesTextBox;
        private System.Windows.Forms.TextBox precioFinalTextBox;
    }
}