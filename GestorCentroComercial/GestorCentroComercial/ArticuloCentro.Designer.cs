namespace GestorCentroComercial
{
    partial class ArticuloCentro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticuloCentro));
            System.Windows.Forms.Label codigoCentroLabel;
            System.Windows.Forms.Label codigoArticuloLabel;
            System.Windows.Forms.Label fechaEntradaLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label caracteristicasLabel;
            System.Windows.Forms.Label unidadesStockLabel;
            System.Windows.Forms.Label precioCosteLabel;
            System.Windows.Forms.Label beneficiosLabel;
            this.consultas = new GestorCentroComercial.Consultas();
            this.articulosCentroComercialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosCentroComercialTableAdapter = new GestorCentroComercial.ConsultasTableAdapters.ArticulosCentroComercialTableAdapter();
            this.tableAdapterManager = new GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager();
            this.articulosCentroComercialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.articulosCentroComercialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoCentroTextBox = new System.Windows.Forms.TextBox();
            this.codigoArticuloTextBox = new System.Windows.Forms.TextBox();
            this.fechaEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreArticuloTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.caracteristicasTextBox = new System.Windows.Forms.TextBox();
            this.unidadesStockTextBox = new System.Windows.Forms.TextBox();
            this.precioCosteTextBox = new System.Windows.Forms.TextBox();
            this.beneficiosTextBox = new System.Windows.Forms.TextBox();
            this.articulosCentroComercialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoCentroLabel = new System.Windows.Forms.Label();
            codigoArticuloLabel = new System.Windows.Forms.Label();
            fechaEntradaLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            caracteristicasLabel = new System.Windows.Forms.Label();
            unidadesStockLabel = new System.Windows.Forms.Label();
            precioCosteLabel = new System.Windows.Forms.Label();
            beneficiosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCentroComercialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCentroComercialBindingNavigator)).BeginInit();
            this.articulosCentroComercialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCentroComercialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosCentroComercialBindingSource
            // 
            this.articulosCentroComercialBindingSource.DataMember = "ArticulosCentroComercial";
            this.articulosCentroComercialBindingSource.DataSource = this.consultas;
            // 
            // articulosCentroComercialTableAdapter
            // 
            this.articulosCentroComercialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticulosCentroComercialTableAdapter = this.articulosCentroComercialTableAdapter;
            this.tableAdapterManager.ArticulosProveedoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // articulosCentroComercialBindingNavigator
            // 
            this.articulosCentroComercialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.articulosCentroComercialBindingNavigator.BindingSource = this.articulosCentroComercialBindingSource;
            this.articulosCentroComercialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.articulosCentroComercialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.articulosCentroComercialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.articulosCentroComercialBindingNavigatorSaveItem});
            this.articulosCentroComercialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.articulosCentroComercialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.articulosCentroComercialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.articulosCentroComercialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.articulosCentroComercialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.articulosCentroComercialBindingNavigator.Name = "articulosCentroComercialBindingNavigator";
            this.articulosCentroComercialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.articulosCentroComercialBindingNavigator.Size = new System.Drawing.Size(974, 25);
            this.articulosCentroComercialBindingNavigator.TabIndex = 0;
            this.articulosCentroComercialBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // articulosCentroComercialBindingNavigatorSaveItem
            // 
            this.articulosCentroComercialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.articulosCentroComercialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("articulosCentroComercialBindingNavigatorSaveItem.Image")));
            this.articulosCentroComercialBindingNavigatorSaveItem.Name = "articulosCentroComercialBindingNavigatorSaveItem";
            this.articulosCentroComercialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.articulosCentroComercialBindingNavigatorSaveItem.Text = "Save Data";
            this.articulosCentroComercialBindingNavigatorSaveItem.Click += new System.EventHandler(this.articulosCentroComercialBindingNavigatorSaveItem_Click);
            // 
            // codigoCentroLabel
            // 
            codigoCentroLabel.AutoSize = true;
            codigoCentroLabel.Location = new System.Drawing.Point(69, 54);
            codigoCentroLabel.Name = "codigoCentroLabel";
            codigoCentroLabel.Size = new System.Drawing.Size(77, 13);
            codigoCentroLabel.TabIndex = 1;
            codigoCentroLabel.Text = "Codigo Centro:";
            // 
            // codigoCentroTextBox
            // 
            this.codigoCentroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "CodigoCentro", true));
            this.codigoCentroTextBox.Location = new System.Drawing.Point(161, 51);
            this.codigoCentroTextBox.Name = "codigoCentroTextBox";
            this.codigoCentroTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoCentroTextBox.TabIndex = 2;
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.Location = new System.Drawing.Point(69, 80);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(81, 13);
            codigoArticuloLabel.TabIndex = 3;
            codigoArticuloLabel.Text = "Codigo Articulo:";
            // 
            // codigoArticuloTextBox
            // 
            this.codigoArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "CodigoArticulo", true));
            this.codigoArticuloTextBox.Location = new System.Drawing.Point(161, 77);
            this.codigoArticuloTextBox.Name = "codigoArticuloTextBox";
            this.codigoArticuloTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoArticuloTextBox.TabIndex = 4;
            // 
            // fechaEntradaLabel
            // 
            fechaEntradaLabel.AutoSize = true;
            fechaEntradaLabel.Location = new System.Drawing.Point(69, 107);
            fechaEntradaLabel.Name = "fechaEntradaLabel";
            fechaEntradaLabel.Size = new System.Drawing.Size(80, 13);
            fechaEntradaLabel.TabIndex = 5;
            fechaEntradaLabel.Text = "Fecha Entrada:";
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.articulosCentroComercialBindingSource, "FechaEntrada", true));
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(161, 103);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntradaDateTimePicker.TabIndex = 6;
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(69, 132);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(85, 13);
            nombreArticuloLabel.TabIndex = 7;
            nombreArticuloLabel.Text = "Nombre Articulo:";
            // 
            // nombreArticuloTextBox
            // 
            this.nombreArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "NombreArticulo", true));
            this.nombreArticuloTextBox.Location = new System.Drawing.Point(161, 129);
            this.nombreArticuloTextBox.Name = "nombreArticuloTextBox";
            this.nombreArticuloTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreArticuloTextBox.TabIndex = 8;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(69, 158);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 9;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(161, 155);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(200, 20);
            this.modeloTextBox.TabIndex = 10;
            // 
            // caracteristicasLabel
            // 
            caracteristicasLabel.AutoSize = true;
            caracteristicasLabel.Location = new System.Drawing.Point(69, 184);
            caracteristicasLabel.Name = "caracteristicasLabel";
            caracteristicasLabel.Size = new System.Drawing.Size(79, 13);
            caracteristicasLabel.TabIndex = 11;
            caracteristicasLabel.Text = "Caracteristicas:";
            // 
            // caracteristicasTextBox
            // 
            this.caracteristicasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "Caracteristicas", true));
            this.caracteristicasTextBox.Location = new System.Drawing.Point(161, 181);
            this.caracteristicasTextBox.Name = "caracteristicasTextBox";
            this.caracteristicasTextBox.Size = new System.Drawing.Size(200, 20);
            this.caracteristicasTextBox.TabIndex = 12;
            // 
            // unidadesStockLabel
            // 
            unidadesStockLabel.AutoSize = true;
            unidadesStockLabel.Location = new System.Drawing.Point(69, 210);
            unidadesStockLabel.Name = "unidadesStockLabel";
            unidadesStockLabel.Size = new System.Drawing.Size(86, 13);
            unidadesStockLabel.TabIndex = 13;
            unidadesStockLabel.Text = "Unidades Stock:";
            // 
            // unidadesStockTextBox
            // 
            this.unidadesStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "UnidadesStock", true));
            this.unidadesStockTextBox.Location = new System.Drawing.Point(161, 207);
            this.unidadesStockTextBox.Name = "unidadesStockTextBox";
            this.unidadesStockTextBox.Size = new System.Drawing.Size(200, 20);
            this.unidadesStockTextBox.TabIndex = 14;
            // 
            // precioCosteLabel
            // 
            precioCosteLabel.AutoSize = true;
            precioCosteLabel.Location = new System.Drawing.Point(69, 236);
            precioCosteLabel.Name = "precioCosteLabel";
            precioCosteLabel.Size = new System.Drawing.Size(70, 13);
            precioCosteLabel.TabIndex = 15;
            precioCosteLabel.Text = "Precio Coste:";
            // 
            // precioCosteTextBox
            // 
            this.precioCosteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "PrecioCoste", true));
            this.precioCosteTextBox.Location = new System.Drawing.Point(161, 233);
            this.precioCosteTextBox.Name = "precioCosteTextBox";
            this.precioCosteTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioCosteTextBox.TabIndex = 16;
            // 
            // beneficiosLabel
            // 
            beneficiosLabel.AutoSize = true;
            beneficiosLabel.Location = new System.Drawing.Point(69, 262);
            beneficiosLabel.Name = "beneficiosLabel";
            beneficiosLabel.Size = new System.Drawing.Size(59, 13);
            beneficiosLabel.TabIndex = 17;
            beneficiosLabel.Text = "Beneficios:";
            // 
            // beneficiosTextBox
            // 
            this.beneficiosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosCentroComercialBindingSource, "Beneficios", true));
            this.beneficiosTextBox.Location = new System.Drawing.Point(161, 259);
            this.beneficiosTextBox.Name = "beneficiosTextBox";
            this.beneficiosTextBox.Size = new System.Drawing.Size(200, 20);
            this.beneficiosTextBox.TabIndex = 18;
            // 
            // articulosCentroComercialDataGridView
            // 
            this.articulosCentroComercialDataGridView.AutoGenerateColumns = false;
            this.articulosCentroComercialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosCentroComercialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.articulosCentroComercialDataGridView.DataSource = this.articulosCentroComercialBindingSource;
            this.articulosCentroComercialDataGridView.Location = new System.Drawing.Point(12, 341);
            this.articulosCentroComercialDataGridView.Name = "articulosCentroComercialDataGridView";
            this.articulosCentroComercialDataGridView.Size = new System.Drawing.Size(943, 220);
            this.articulosCentroComercialDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoCentro";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoCentro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoArticulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoArticulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaEntrada";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaEntrada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn4.HeaderText = "NombreArticulo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Caracteristicas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Caracteristicas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UnidadesStock";
            this.dataGridViewTextBoxColumn7.HeaderText = "UnidadesStock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PrecioCoste";
            this.dataGridViewTextBoxColumn8.HeaderText = "PrecioCoste";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Beneficios";
            this.dataGridViewTextBoxColumn9.HeaderText = "Beneficios";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // ArticuloCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 581);
            this.Controls.Add(this.articulosCentroComercialDataGridView);
            this.Controls.Add(codigoCentroLabel);
            this.Controls.Add(this.codigoCentroTextBox);
            this.Controls.Add(codigoArticuloLabel);
            this.Controls.Add(this.codigoArticuloTextBox);
            this.Controls.Add(fechaEntradaLabel);
            this.Controls.Add(this.fechaEntradaDateTimePicker);
            this.Controls.Add(nombreArticuloLabel);
            this.Controls.Add(this.nombreArticuloTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(caracteristicasLabel);
            this.Controls.Add(this.caracteristicasTextBox);
            this.Controls.Add(unidadesStockLabel);
            this.Controls.Add(this.unidadesStockTextBox);
            this.Controls.Add(precioCosteLabel);
            this.Controls.Add(this.precioCosteTextBox);
            this.Controls.Add(beneficiosLabel);
            this.Controls.Add(this.beneficiosTextBox);
            this.Controls.Add(this.articulosCentroComercialBindingNavigator);
            this.Name = "ArticuloCentro";
            this.Text = "ArticuloCentro";
            this.Load += new System.EventHandler(this.ArticuloCentro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCentroComercialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCentroComercialBindingNavigator)).EndInit();
            this.articulosCentroComercialBindingNavigator.ResumeLayout(false);
            this.articulosCentroComercialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosCentroComercialDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultas consultas;
        private System.Windows.Forms.BindingSource articulosCentroComercialBindingSource;
        private ConsultasTableAdapters.ArticulosCentroComercialTableAdapter articulosCentroComercialTableAdapter;
        private ConsultasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator articulosCentroComercialBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton articulosCentroComercialBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoCentroTextBox;
        private System.Windows.Forms.TextBox codigoArticuloTextBox;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
        private System.Windows.Forms.TextBox nombreArticuloTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox caracteristicasTextBox;
        private System.Windows.Forms.TextBox unidadesStockTextBox;
        private System.Windows.Forms.TextBox precioCosteTextBox;
        private System.Windows.Forms.TextBox beneficiosTextBox;
        private System.Windows.Forms.DataGridView articulosCentroComercialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}