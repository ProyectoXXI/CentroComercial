namespace GestorCentroComercial
{
    partial class Ventas
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
            System.Windows.Forms.Label fechaVentaLabel;
            System.Windows.Forms.Label codigCentroLabel;
            System.Windows.Forms.Label codigoDependienteLabel;
            System.Windows.Forms.Label dniClienteLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label codigoVentaLabel;
            System.Windows.Forms.Label codigoArticuloLabel;
            System.Windows.Forms.Label unidadesLabel;
            System.Windows.Forms.Label precioFinalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.ventasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultas = new GestorCentroComercial.Consultas();
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
            this.fechaVentaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codigCentroTextBox = new System.Windows.Forms.TextBox();
            this.codigoDependienteTextBox = new System.Windows.Forms.TextBox();
            this.dniClienteTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.codigoArticuloTextBox = new System.Windows.Forms.TextBox();
            this.unidadesTextBox = new System.Windows.Forms.TextBox();
            this.precioFinalTextBox = new System.Windows.Forms.TextBox();
            this.ventasTableAdapter = new GestorCentroComercial.ConsultasTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager();
            this.articulosCentroComercialTableAdapter1 = new GestorCentroComercial.ConsultasTableAdapters.ArticulosCentroComercialTableAdapter();
            this.empleadoTableAdapter1 = new GestorCentroComercial.ConsultasTableAdapters.EmpleadoTableAdapter();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoVentaTextBox = new System.Windows.Forms.TextBox();
            fechaVentaLabel = new System.Windows.Forms.Label();
            codigCentroLabel = new System.Windows.Forms.Label();
            codigoDependienteLabel = new System.Windows.Forms.Label();
            dniClienteLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            codigoVentaLabel = new System.Windows.Forms.Label();
            codigoArticuloLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            precioFinalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingNavigator)).BeginInit();
            this.ventasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaVentaLabel
            // 
            fechaVentaLabel.AutoSize = true;
            fechaVentaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaVentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaVentaLabel.ForeColor = System.Drawing.Color.White;
            fechaVentaLabel.Location = new System.Drawing.Point(64, 92);
            fechaVentaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaVentaLabel.Name = "fechaVentaLabel";
            fechaVentaLabel.Size = new System.Drawing.Size(130, 25);
            fechaVentaLabel.TabIndex = 1;
            fechaVentaLabel.Text = "Fecha Venta:";
            // 
            // codigCentroLabel
            // 
            codigCentroLabel.AutoSize = true;
            codigCentroLabel.BackColor = System.Drawing.Color.Transparent;
            codigCentroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigCentroLabel.ForeColor = System.Drawing.Color.White;
            codigCentroLabel.Location = new System.Drawing.Point(64, 123);
            codigCentroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigCentroLabel.Name = "codigCentroLabel";
            codigCentroLabel.Size = new System.Drawing.Size(134, 25);
            codigCentroLabel.TabIndex = 3;
            codigCentroLabel.Text = "Codig Centro:";
            // 
            // codigoDependienteLabel
            // 
            codigoDependienteLabel.AutoSize = true;
            codigoDependienteLabel.BackColor = System.Drawing.Color.Transparent;
            codigoDependienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoDependienteLabel.ForeColor = System.Drawing.Color.White;
            codigoDependienteLabel.Location = new System.Drawing.Point(64, 155);
            codigoDependienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoDependienteLabel.Name = "codigoDependienteLabel";
            codigoDependienteLabel.Size = new System.Drawing.Size(197, 25);
            codigoDependienteLabel.TabIndex = 5;
            codigoDependienteLabel.Text = "Codigo Dependiente:";
            // 
            // dniClienteLabel
            // 
            dniClienteLabel.AutoSize = true;
            dniClienteLabel.BackColor = System.Drawing.Color.Transparent;
            dniClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dniClienteLabel.ForeColor = System.Drawing.Color.White;
            dniClienteLabel.Location = new System.Drawing.Point(64, 187);
            dniClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dniClienteLabel.Name = "dniClienteLabel";
            dniClienteLabel.Size = new System.Drawing.Size(113, 25);
            dniClienteLabel.TabIndex = 7;
            dniClienteLabel.Text = "Dni Cliente:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.BackColor = System.Drawing.Color.Transparent;
            descuentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descuentoLabel.ForeColor = System.Drawing.Color.White;
            descuentoLabel.Location = new System.Drawing.Point(727, 71);
            descuentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(112, 25);
            descuentoLabel.TabIndex = 9;
            descuentoLabel.Text = "Descuento:";
            // 
            // codigoVentaLabel
            // 
            codigoVentaLabel.AutoSize = true;
            codigoVentaLabel.BackColor = System.Drawing.Color.Transparent;
            codigoVentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoVentaLabel.ForeColor = System.Drawing.Color.White;
            codigoVentaLabel.Location = new System.Drawing.Point(727, 103);
            codigoVentaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoVentaLabel.Name = "codigoVentaLabel";
            codigoVentaLabel.Size = new System.Drawing.Size(138, 25);
            codigoVentaLabel.TabIndex = 11;
            codigoVentaLabel.Text = "Codigo Venta:";
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.BackColor = System.Drawing.Color.Transparent;
            codigoArticuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoArticuloLabel.ForeColor = System.Drawing.Color.White;
            codigoArticuloLabel.Location = new System.Drawing.Point(727, 135);
            codigoArticuloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(151, 25);
            codigoArticuloLabel.TabIndex = 13;
            codigoArticuloLabel.Text = "Codigo Articulo:";
            // 
            // unidadesLabel
            // 
            unidadesLabel.AutoSize = true;
            unidadesLabel.BackColor = System.Drawing.Color.Transparent;
            unidadesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidadesLabel.ForeColor = System.Drawing.Color.White;
            unidadesLabel.Location = new System.Drawing.Point(727, 167);
            unidadesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unidadesLabel.Name = "unidadesLabel";
            unidadesLabel.Size = new System.Drawing.Size(101, 25);
            unidadesLabel.TabIndex = 15;
            unidadesLabel.Text = "Unidades:";
            // 
            // precioFinalLabel
            // 
            precioFinalLabel.AutoSize = true;
            precioFinalLabel.BackColor = System.Drawing.Color.Transparent;
            precioFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioFinalLabel.ForeColor = System.Drawing.Color.White;
            precioFinalLabel.Location = new System.Drawing.Point(727, 199);
            precioFinalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precioFinalLabel.Name = "precioFinalLabel";
            precioFinalLabel.Size = new System.Drawing.Size(120, 25);
            precioFinalLabel.TabIndex = 17;
            precioFinalLabel.Text = "Precio Final:";
            // 
            // ventasBindingNavigator
            // 
            this.ventasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ventasBindingNavigator.BindingSource = this.ventasBindingSource;
            this.ventasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ventasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.ventasBindingNavigator.Size = new System.Drawing.Size(1301, 27);
            this.ventasBindingNavigator.TabIndex = 0;
            this.ventasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.consultas;
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ventasBindingNavigatorSaveItem
            // 
            this.ventasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasBindingNavigatorSaveItem.Image")));
            this.ventasBindingNavigatorSaveItem.Name = "ventasBindingNavigatorSaveItem";
            this.ventasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.ventasBindingNavigatorSaveItem.Text = "Save Data";
            this.ventasBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventasBindingNavigatorSaveItem_Click);
            // 
            // fechaVentaDateTimePicker
            // 
            this.fechaVentaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "FechaVenta", true));
            this.fechaVentaDateTimePicker.Location = new System.Drawing.Point(285, 92);
            this.fechaVentaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fechaVentaDateTimePicker.Name = "fechaVentaDateTimePicker";
            this.fechaVentaDateTimePicker.Size = new System.Drawing.Size(336, 22);
            this.fechaVentaDateTimePicker.TabIndex = 2;
            // 
            // codigCentroTextBox
            // 
            this.codigCentroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigCentro", true));
            this.codigCentroTextBox.Location = new System.Drawing.Point(285, 124);
            this.codigCentroTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigCentroTextBox.Name = "codigCentroTextBox";
            this.codigCentroTextBox.Size = new System.Drawing.Size(336, 22);
            this.codigCentroTextBox.TabIndex = 4;
            // 
            // codigoDependienteTextBox
            // 
            this.codigoDependienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigoDependiente", true));
            this.codigoDependienteTextBox.Enabled = false;
            this.codigoDependienteTextBox.Location = new System.Drawing.Point(285, 156);
            this.codigoDependienteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigoDependienteTextBox.Name = "codigoDependienteTextBox";
            this.codigoDependienteTextBox.Size = new System.Drawing.Size(336, 22);
            this.codigoDependienteTextBox.TabIndex = 6;
            // 
            // dniClienteTextBox
            // 
            this.dniClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "DniCliente", true));
            this.dniClienteTextBox.Location = new System.Drawing.Point(285, 188);
            this.dniClienteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dniClienteTextBox.Name = "dniClienteTextBox";
            this.dniClienteTextBox.Size = new System.Drawing.Size(336, 22);
            this.dniClienteTextBox.TabIndex = 8;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(921, 74);
            this.descuentoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(336, 22);
            this.descuentoTextBox.TabIndex = 10;
            // 
            // codigoArticuloTextBox
            // 
            this.codigoArticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigoArticulo", true));
            this.codigoArticuloTextBox.Location = new System.Drawing.Point(921, 138);
            this.codigoArticuloTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigoArticuloTextBox.Name = "codigoArticuloTextBox";
            this.codigoArticuloTextBox.Size = new System.Drawing.Size(336, 22);
            this.codigoArticuloTextBox.TabIndex = 14;
            // 
            // unidadesTextBox
            // 
            this.unidadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Unidades", true));
            this.unidadesTextBox.Location = new System.Drawing.Point(921, 170);
            this.unidadesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unidadesTextBox.Name = "unidadesTextBox";
            this.unidadesTextBox.Size = new System.Drawing.Size(336, 22);
            this.unidadesTextBox.TabIndex = 16;
            // 
            // precioFinalTextBox
            // 
            this.precioFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "PrecioFinal", true));
            this.precioFinalTextBox.Location = new System.Drawing.Point(921, 202);
            this.precioFinalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precioFinalTextBox.Name = "precioFinalTextBox";
            this.precioFinalTextBox.Size = new System.Drawing.Size(336, 22);
            this.precioFinalTextBox.TabIndex = 18;
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
            // articulosCentroComercialTableAdapter1
            // 
            this.articulosCentroComercialTableAdapter1.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter1
            // 
            this.empleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PrecioFinal";
            this.dataGridViewTextBoxColumn9.HeaderText = "PrecioFinal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Unidades";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CodigoArticulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "CodigoArticulo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CodigoVenta";
            this.dataGridViewTextBoxColumn6.HeaderText = "CodigoVenta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descuento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DniCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "DniCliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoDependiente";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodigoDependiente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigCentro";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigCentro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FechaVenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "FechaVenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.ventasDataGridView.Location = new System.Drawing.Point(16, 267);
            this.ventasDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ventasDataGridView.Name = "ventasDataGridView";
            this.ventasDataGridView.Size = new System.Drawing.Size(1261, 514);
            this.ventasDataGridView.TabIndex = 19;
            // 
            // codigoVentaTextBox
            // 
            this.codigoVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "CodigoVenta", true));
            this.codigoVentaTextBox.Location = new System.Drawing.Point(921, 106);
            this.codigoVentaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigoVentaTextBox.Name = "codigoVentaTextBox";
            this.codigoVentaTextBox.Size = new System.Drawing.Size(336, 22);
            this.codigoVentaTextBox.TabIndex = 12;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorCentroComercial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1301, 806);
            this.Controls.Add(this.ventasDataGridView);
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
            this.Controls.Add(this.ventasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingNavigator)).EndInit();
            this.ventasBindingNavigator.ResumeLayout(false);
            this.ventasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
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
        private System.Windows.Forms.DateTimePicker fechaVentaDateTimePicker;
        private System.Windows.Forms.TextBox codigCentroTextBox;
        private System.Windows.Forms.TextBox codigoDependienteTextBox;
        private System.Windows.Forms.TextBox dniClienteTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox codigoArticuloTextBox;
        private System.Windows.Forms.TextBox unidadesTextBox;
        private System.Windows.Forms.TextBox precioFinalTextBox;
        private ConsultasTableAdapters.ArticulosCentroComercialTableAdapter articulosCentroComercialTableAdapter1;
        private ConsultasTableAdapters.EmpleadoTableAdapter empleadoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView ventasDataGridView;
        private System.Windows.Forms.TextBox codigoVentaTextBox;
    }
}