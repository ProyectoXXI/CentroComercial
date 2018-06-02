namespace GestorCentroComercial
{
    partial class Nominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nominas));
            System.Windows.Forms.Label dniEmpleadoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label sueldoBrutoLabel;
            System.Windows.Forms.Label descuentoSeguridadLabel;
            System.Windows.Forms.Label totalDineroLabel;
            System.Windows.Forms.Label descuentoIRPFLabel;
            System.Windows.Forms.Label plustrieniosLabel;
            System.Windows.Forms.Label plusproductividadLabel;
            System.Windows.Forms.Label horasTrabajadasLabel;
            System.Windows.Forms.Label horasMesLabel;
            System.Windows.Forms.Label fechaNominaLabel;
            System.Windows.Forms.Label periodoNominaMesesLabel;
            System.Windows.Forms.Label codigoEmpleadoLabel;
            this.consultas = new GestorCentroComercial.Consultas();
            this.nominasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominasTableAdapter = new GestorCentroComercial.ConsultasTableAdapters.NominasTableAdapter();
            this.tableAdapterManager = new GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager();
            this.nominasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nominasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nominasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.sueldoBrutoTextBox = new System.Windows.Forms.TextBox();
            this.descuentoSeguridadTextBox = new System.Windows.Forms.TextBox();
            this.totalDineroTextBox = new System.Windows.Forms.TextBox();
            this.descuentoIRPFTextBox = new System.Windows.Forms.TextBox();
            this.plustrieniosTextBox = new System.Windows.Forms.TextBox();
            this.plusproductividadTextBox = new System.Windows.Forms.TextBox();
            this.horasTrabajadasTextBox = new System.Windows.Forms.TextBox();
            this.horasMesTextBox = new System.Windows.Forms.TextBox();
            this.fechaNominaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodoNominaMesesTextBox = new System.Windows.Forms.TextBox();
            this.codigoEmpleadoTextBox = new System.Windows.Forms.TextBox();
            dniEmpleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            sueldoBrutoLabel = new System.Windows.Forms.Label();
            descuentoSeguridadLabel = new System.Windows.Forms.Label();
            totalDineroLabel = new System.Windows.Forms.Label();
            descuentoIRPFLabel = new System.Windows.Forms.Label();
            plustrieniosLabel = new System.Windows.Forms.Label();
            plusproductividadLabel = new System.Windows.Forms.Label();
            horasTrabajadasLabel = new System.Windows.Forms.Label();
            horasMesLabel = new System.Windows.Forms.Label();
            fechaNominaLabel = new System.Windows.Forms.Label();
            periodoNominaMesesLabel = new System.Windows.Forms.Label();
            codigoEmpleadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingNavigator)).BeginInit();
            this.nominasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominasBindingSource
            // 
            this.nominasBindingSource.DataMember = "Nominas";
            this.nominasBindingSource.DataSource = this.consultas;
            // 
            // nominasTableAdapter
            // 
            this.nominasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticulosCentroComercialTableAdapter = null;
            this.tableAdapterManager.ArticulosProveedoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = this.nominasTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // nominasBindingNavigator
            // 
            this.nominasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nominasBindingNavigator.BindingSource = this.nominasBindingSource;
            this.nominasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nominasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nominasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nominasBindingNavigatorSaveItem});
            this.nominasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nominasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nominasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nominasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nominasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nominasBindingNavigator.Name = "nominasBindingNavigator";
            this.nominasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nominasBindingNavigator.Size = new System.Drawing.Size(1103, 25);
            this.nominasBindingNavigator.TabIndex = 0;
            this.nominasBindingNavigator.Text = "bindingNavigator1";
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
            // nominasBindingNavigatorSaveItem
            // 
            this.nominasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nominasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nominasBindingNavigatorSaveItem.Image")));
            this.nominasBindingNavigatorSaveItem.Name = "nominasBindingNavigatorSaveItem";
            this.nominasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.nominasBindingNavigatorSaveItem.Text = "Save Data";
            this.nominasBindingNavigatorSaveItem.Click += new System.EventHandler(this.nominasBindingNavigatorSaveItem_Click);
            // 
            // nominasDataGridView
            // 
            this.nominasDataGridView.AutoGenerateColumns = false;
            this.nominasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nominasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.nominasDataGridView.DataSource = this.nominasBindingSource;
            this.nominasDataGridView.Location = new System.Drawing.Point(12, 437);
            this.nominasDataGridView.Name = "nominasDataGridView";
            this.nominasDataGridView.Size = new System.Drawing.Size(1034, 220);
            this.nominasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DniEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "DniEmpleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sueldoBruto";
            this.dataGridViewTextBoxColumn4.HeaderText = "sueldoBruto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descuentoSeguridad";
            this.dataGridViewTextBoxColumn5.HeaderText = "descuentoSeguridad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "totalDinero";
            this.dataGridViewTextBoxColumn6.HeaderText = "totalDinero";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "descuentoIRPF";
            this.dataGridViewTextBoxColumn7.HeaderText = "descuentoIRPF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "plustrienios";
            this.dataGridViewTextBoxColumn8.HeaderText = "plustrienios";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "plusproductividad";
            this.dataGridViewTextBoxColumn9.HeaderText = "plusproductividad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "horasTrabajadas";
            this.dataGridViewTextBoxColumn10.HeaderText = "horasTrabajadas";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "horasMes";
            this.dataGridViewTextBoxColumn11.HeaderText = "horasMes";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "fechaNomina";
            this.dataGridViewTextBoxColumn12.HeaderText = "fechaNomina";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "periodoNominaMeses";
            this.dataGridViewTextBoxColumn13.HeaderText = "periodoNominaMeses";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CodigoEmpleado";
            this.dataGridViewTextBoxColumn14.HeaderText = "CodigoEmpleado";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dniEmpleadoLabel
            // 
            dniEmpleadoLabel.AutoSize = true;
            dniEmpleadoLabel.Location = new System.Drawing.Point(58, 64);
            dniEmpleadoLabel.Name = "dniEmpleadoLabel";
            dniEmpleadoLabel.Size = new System.Drawing.Size(76, 13);
            dniEmpleadoLabel.TabIndex = 2;
            dniEmpleadoLabel.Text = "Dni Empleado:";
            // 
            // dniEmpleadoTextBox
            // 
            this.dniEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "DniEmpleado", true));
            this.dniEmpleadoTextBox.Location = new System.Drawing.Point(182, 61);
            this.dniEmpleadoTextBox.Name = "dniEmpleadoTextBox";
            this.dniEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniEmpleadoTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(58, 90);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(182, 87);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(58, 116);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(51, 13);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(182, 113);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 7;
            // 
            // sueldoBrutoLabel
            // 
            sueldoBrutoLabel.AutoSize = true;
            sueldoBrutoLabel.Location = new System.Drawing.Point(58, 142);
            sueldoBrutoLabel.Name = "sueldoBrutoLabel";
            sueldoBrutoLabel.Size = new System.Drawing.Size(69, 13);
            sueldoBrutoLabel.TabIndex = 8;
            sueldoBrutoLabel.Text = "sueldo Bruto:";
            // 
            // sueldoBrutoTextBox
            // 
            this.sueldoBrutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "sueldoBruto", true));
            this.sueldoBrutoTextBox.Location = new System.Drawing.Point(182, 139);
            this.sueldoBrutoTextBox.Name = "sueldoBrutoTextBox";
            this.sueldoBrutoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoBrutoTextBox.TabIndex = 9;
            // 
            // descuentoSeguridadLabel
            // 
            descuentoSeguridadLabel.AutoSize = true;
            descuentoSeguridadLabel.Location = new System.Drawing.Point(58, 168);
            descuentoSeguridadLabel.Name = "descuentoSeguridadLabel";
            descuentoSeguridadLabel.Size = new System.Drawing.Size(111, 13);
            descuentoSeguridadLabel.TabIndex = 10;
            descuentoSeguridadLabel.Text = "descuento Seguridad:";
            // 
            // descuentoSeguridadTextBox
            // 
            this.descuentoSeguridadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "descuentoSeguridad", true));
            this.descuentoSeguridadTextBox.Location = new System.Drawing.Point(182, 165);
            this.descuentoSeguridadTextBox.Name = "descuentoSeguridadTextBox";
            this.descuentoSeguridadTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoSeguridadTextBox.TabIndex = 11;
            // 
            // totalDineroLabel
            // 
            totalDineroLabel.AutoSize = true;
            totalDineroLabel.Location = new System.Drawing.Point(58, 194);
            totalDineroLabel.Name = "totalDineroLabel";
            totalDineroLabel.Size = new System.Drawing.Size(64, 13);
            totalDineroLabel.TabIndex = 12;
            totalDineroLabel.Text = "total Dinero:";
            // 
            // totalDineroTextBox
            // 
            this.totalDineroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "totalDinero", true));
            this.totalDineroTextBox.Location = new System.Drawing.Point(182, 191);
            this.totalDineroTextBox.Name = "totalDineroTextBox";
            this.totalDineroTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalDineroTextBox.TabIndex = 13;
            // 
            // descuentoIRPFLabel
            // 
            descuentoIRPFLabel.AutoSize = true;
            descuentoIRPFLabel.Location = new System.Drawing.Point(58, 220);
            descuentoIRPFLabel.Name = "descuentoIRPFLabel";
            descuentoIRPFLabel.Size = new System.Drawing.Size(87, 13);
            descuentoIRPFLabel.TabIndex = 14;
            descuentoIRPFLabel.Text = "descuento IRPF:";
            // 
            // descuentoIRPFTextBox
            // 
            this.descuentoIRPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "descuentoIRPF", true));
            this.descuentoIRPFTextBox.Location = new System.Drawing.Point(182, 217);
            this.descuentoIRPFTextBox.Name = "descuentoIRPFTextBox";
            this.descuentoIRPFTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoIRPFTextBox.TabIndex = 15;
            // 
            // plustrieniosLabel
            // 
            plustrieniosLabel.AutoSize = true;
            plustrieniosLabel.Location = new System.Drawing.Point(58, 246);
            plustrieniosLabel.Name = "plustrieniosLabel";
            plustrieniosLabel.Size = new System.Drawing.Size(62, 13);
            plustrieniosLabel.TabIndex = 16;
            plustrieniosLabel.Text = "plustrienios:";
            // 
            // plustrieniosTextBox
            // 
            this.plustrieniosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "plustrienios", true));
            this.plustrieniosTextBox.Location = new System.Drawing.Point(182, 243);
            this.plustrieniosTextBox.Name = "plustrieniosTextBox";
            this.plustrieniosTextBox.Size = new System.Drawing.Size(200, 20);
            this.plustrieniosTextBox.TabIndex = 17;
            // 
            // plusproductividadLabel
            // 
            plusproductividadLabel.AutoSize = true;
            plusproductividadLabel.Location = new System.Drawing.Point(58, 272);
            plusproductividadLabel.Name = "plusproductividadLabel";
            plusproductividadLabel.Size = new System.Drawing.Size(93, 13);
            plusproductividadLabel.TabIndex = 18;
            plusproductividadLabel.Text = "plusproductividad:";
            // 
            // plusproductividadTextBox
            // 
            this.plusproductividadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "plusproductividad", true));
            this.plusproductividadTextBox.Location = new System.Drawing.Point(182, 269);
            this.plusproductividadTextBox.Name = "plusproductividadTextBox";
            this.plusproductividadTextBox.Size = new System.Drawing.Size(200, 20);
            this.plusproductividadTextBox.TabIndex = 19;
            // 
            // horasTrabajadasLabel
            // 
            horasTrabajadasLabel.AutoSize = true;
            horasTrabajadasLabel.Location = new System.Drawing.Point(58, 298);
            horasTrabajadasLabel.Name = "horasTrabajadasLabel";
            horasTrabajadasLabel.Size = new System.Drawing.Size(92, 13);
            horasTrabajadasLabel.TabIndex = 20;
            horasTrabajadasLabel.Text = "horas Trabajadas:";
            // 
            // horasTrabajadasTextBox
            // 
            this.horasTrabajadasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "horasTrabajadas", true));
            this.horasTrabajadasTextBox.Location = new System.Drawing.Point(182, 295);
            this.horasTrabajadasTextBox.Name = "horasTrabajadasTextBox";
            this.horasTrabajadasTextBox.Size = new System.Drawing.Size(200, 20);
            this.horasTrabajadasTextBox.TabIndex = 21;
            // 
            // horasMesLabel
            // 
            horasMesLabel.AutoSize = true;
            horasMesLabel.Location = new System.Drawing.Point(58, 324);
            horasMesLabel.Name = "horasMesLabel";
            horasMesLabel.Size = new System.Drawing.Size(59, 13);
            horasMesLabel.TabIndex = 22;
            horasMesLabel.Text = "horas Mes:";
            // 
            // horasMesTextBox
            // 
            this.horasMesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "horasMes", true));
            this.horasMesTextBox.Location = new System.Drawing.Point(182, 321);
            this.horasMesTextBox.Name = "horasMesTextBox";
            this.horasMesTextBox.Size = new System.Drawing.Size(200, 20);
            this.horasMesTextBox.TabIndex = 23;
            // 
            // fechaNominaLabel
            // 
            fechaNominaLabel.AutoSize = true;
            fechaNominaLabel.Location = new System.Drawing.Point(58, 351);
            fechaNominaLabel.Name = "fechaNominaLabel";
            fechaNominaLabel.Size = new System.Drawing.Size(76, 13);
            fechaNominaLabel.TabIndex = 24;
            fechaNominaLabel.Text = "fecha Nomina:";
            // 
            // fechaNominaDateTimePicker
            // 
            this.fechaNominaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nominasBindingSource, "fechaNomina", true));
            this.fechaNominaDateTimePicker.Location = new System.Drawing.Point(182, 347);
            this.fechaNominaDateTimePicker.Name = "fechaNominaDateTimePicker";
            this.fechaNominaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNominaDateTimePicker.TabIndex = 25;
            // 
            // periodoNominaMesesLabel
            // 
            periodoNominaMesesLabel.AutoSize = true;
            periodoNominaMesesLabel.Location = new System.Drawing.Point(58, 376);
            periodoNominaMesesLabel.Name = "periodoNominaMesesLabel";
            periodoNominaMesesLabel.Size = new System.Drawing.Size(118, 13);
            periodoNominaMesesLabel.TabIndex = 26;
            periodoNominaMesesLabel.Text = "periodo Nomina Meses:";
            // 
            // periodoNominaMesesTextBox
            // 
            this.periodoNominaMesesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "periodoNominaMeses", true));
            this.periodoNominaMesesTextBox.Location = new System.Drawing.Point(182, 373);
            this.periodoNominaMesesTextBox.Name = "periodoNominaMesesTextBox";
            this.periodoNominaMesesTextBox.Size = new System.Drawing.Size(200, 20);
            this.periodoNominaMesesTextBox.TabIndex = 27;
            // 
            // codigoEmpleadoLabel
            // 
            codigoEmpleadoLabel.AutoSize = true;
            codigoEmpleadoLabel.Location = new System.Drawing.Point(58, 402);
            codigoEmpleadoLabel.Name = "codigoEmpleadoLabel";
            codigoEmpleadoLabel.Size = new System.Drawing.Size(93, 13);
            codigoEmpleadoLabel.TabIndex = 28;
            codigoEmpleadoLabel.Text = "Codigo Empleado:";
            // 
            // codigoEmpleadoTextBox
            // 
            this.codigoEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "CodigoEmpleado", true));
            this.codigoEmpleadoTextBox.Location = new System.Drawing.Point(182, 399);
            this.codigoEmpleadoTextBox.Name = "codigoEmpleadoTextBox";
            this.codigoEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoEmpleadoTextBox.TabIndex = 29;
            // 
            // Nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 677);
            this.Controls.Add(dniEmpleadoLabel);
            this.Controls.Add(this.dniEmpleadoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(sueldoBrutoLabel);
            this.Controls.Add(this.sueldoBrutoTextBox);
            this.Controls.Add(descuentoSeguridadLabel);
            this.Controls.Add(this.descuentoSeguridadTextBox);
            this.Controls.Add(totalDineroLabel);
            this.Controls.Add(this.totalDineroTextBox);
            this.Controls.Add(descuentoIRPFLabel);
            this.Controls.Add(this.descuentoIRPFTextBox);
            this.Controls.Add(plustrieniosLabel);
            this.Controls.Add(this.plustrieniosTextBox);
            this.Controls.Add(plusproductividadLabel);
            this.Controls.Add(this.plusproductividadTextBox);
            this.Controls.Add(horasTrabajadasLabel);
            this.Controls.Add(this.horasTrabajadasTextBox);
            this.Controls.Add(horasMesLabel);
            this.Controls.Add(this.horasMesTextBox);
            this.Controls.Add(fechaNominaLabel);
            this.Controls.Add(this.fechaNominaDateTimePicker);
            this.Controls.Add(periodoNominaMesesLabel);
            this.Controls.Add(this.periodoNominaMesesTextBox);
            this.Controls.Add(codigoEmpleadoLabel);
            this.Controls.Add(this.codigoEmpleadoTextBox);
            this.Controls.Add(this.nominasDataGridView);
            this.Controls.Add(this.nominasBindingNavigator);
            this.Name = "Nominas";
            this.Text = "Nominas";
            this.Load += new System.EventHandler(this.Nominas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingNavigator)).EndInit();
            this.nominasBindingNavigator.ResumeLayout(false);
            this.nominasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultas consultas;
        private System.Windows.Forms.BindingSource nominasBindingSource;
        private ConsultasTableAdapters.NominasTableAdapter nominasTableAdapter;
        private ConsultasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nominasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nominasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nominasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox dniEmpleadoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox sueldoBrutoTextBox;
        private System.Windows.Forms.TextBox descuentoSeguridadTextBox;
        private System.Windows.Forms.TextBox totalDineroTextBox;
        private System.Windows.Forms.TextBox descuentoIRPFTextBox;
        private System.Windows.Forms.TextBox plustrieniosTextBox;
        private System.Windows.Forms.TextBox plusproductividadTextBox;
        private System.Windows.Forms.TextBox horasTrabajadasTextBox;
        private System.Windows.Forms.TextBox horasMesTextBox;
        private System.Windows.Forms.DateTimePicker fechaNominaDateTimePicker;
        private System.Windows.Forms.TextBox periodoNominaMesesTextBox;
        private System.Windows.Forms.TextBox codigoEmpleadoTextBox;
    }
}