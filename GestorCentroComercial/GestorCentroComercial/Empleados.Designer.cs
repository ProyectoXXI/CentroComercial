namespace GestorCentroComercial
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            System.Windows.Forms.Label codigoEmpleadoLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label ingresoLabel;
            System.Windows.Forms.Label nacimientoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label centroLabel;
            System.Windows.Forms.Label tipoContratoLabel;
            System.Windows.Forms.Label precioHoraLabel;
            this.consultas = new GestorCentroComercial.Consultas();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new GestorCentroComercial.ConsultasTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager();
            this.empleadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.empleadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoDataGridView = new System.Windows.Forms.DataGridView();
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
            this.codigoEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.rolTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.ingresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.centroTextBox = new System.Windows.Forms.TextBox();
            this.tipoContratoTextBox = new System.Windows.Forms.TextBox();
            this.precioHoraTextBox = new System.Windows.Forms.TextBox();
            codigoEmpleadoLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ingresoLabel = new System.Windows.Forms.Label();
            nacimientoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            centroLabel = new System.Windows.Forms.Label();
            tipoContratoLabel = new System.Windows.Forms.Label();
            precioHoraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).BeginInit();
            this.empleadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.consultas;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticulosCentroComercialTableAdapter = null;
            this.tableAdapterManager.ArticulosProveedoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // empleadoBindingNavigator
            // 
            this.empleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadoBindingNavigator.BindingSource = this.empleadoBindingSource;
            this.empleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empleadoBindingNavigatorSaveItem});
            this.empleadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadoBindingNavigator.Name = "empleadoBindingNavigator";
            this.empleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadoBindingNavigator.Size = new System.Drawing.Size(1067, 25);
            this.empleadoBindingNavigator.TabIndex = 0;
            this.empleadoBindingNavigator.Text = "bindingNavigator1";
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
            // empleadoBindingNavigatorSaveItem
            // 
            this.empleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoBindingNavigatorSaveItem.Image")));
            this.empleadoBindingNavigatorSaveItem.Name = "empleadoBindingNavigatorSaveItem";
            this.empleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.empleadoBindingNavigatorSaveItem.Text = "Save Data";
            this.empleadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadoBindingNavigatorSaveItem_Click);
            // 
            // empleadoDataGridView
            // 
            this.empleadoDataGridView.AutoGenerateColumns = false;
            this.empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.empleadoDataGridView.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView.Location = new System.Drawing.Point(12, 453);
            this.empleadoDataGridView.Name = "empleadoDataGridView";
            this.empleadoDataGridView.Size = new System.Drawing.Size(1033, 189);
            this.empleadoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoEmpleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rol";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dni";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ingreso";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ingreso";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nacimiento";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nacimiento";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Centro";
            this.dataGridViewTextBoxColumn12.HeaderText = "Centro";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TipoContrato";
            this.dataGridViewTextBoxColumn13.HeaderText = "TipoContrato";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PrecioHora";
            this.dataGridViewTextBoxColumn14.HeaderText = "PrecioHora";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // codigoEmpleadoLabel
            // 
            codigoEmpleadoLabel.AutoSize = true;
            codigoEmpleadoLabel.Location = new System.Drawing.Point(27, 58);
            codigoEmpleadoLabel.Name = "codigoEmpleadoLabel";
            codigoEmpleadoLabel.Size = new System.Drawing.Size(93, 13);
            codigoEmpleadoLabel.TabIndex = 2;
            codigoEmpleadoLabel.Text = "Codigo Empleado:";
            // 
            // codigoEmpleadoTextBox
            // 
            this.codigoEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "CodigoEmpleado", true));
            this.codigoEmpleadoTextBox.Location = new System.Drawing.Point(126, 55);
            this.codigoEmpleadoTextBox.Name = "codigoEmpleadoTextBox";
            this.codigoEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoEmpleadoTextBox.TabIndex = 3;
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Location = new System.Drawing.Point(27, 84);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(26, 13);
            rolLabel.TabIndex = 4;
            rolLabel.Text = "Rol:";
            // 
            // rolTextBox
            // 
            this.rolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Rol", true));
            this.rolTextBox.Location = new System.Drawing.Point(126, 81);
            this.rolTextBox.Name = "rolTextBox";
            this.rolTextBox.Size = new System.Drawing.Size(200, 20);
            this.rolTextBox.TabIndex = 5;
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(27, 110);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 6;
            dniLabel.Text = "Dni:";
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(126, 107);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniTextBox.TabIndex = 7;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(27, 136);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(126, 133);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(27, 162);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 10;
            apellidosLabel.Text = "Apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(126, 159);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 11;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(27, 188);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 12;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(126, 185);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 13;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(27, 214);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(126, 211);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(27, 240);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(126, 237);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 17;
            // 
            // ingresoLabel
            // 
            ingresoLabel.AutoSize = true;
            ingresoLabel.Location = new System.Drawing.Point(27, 267);
            ingresoLabel.Name = "ingresoLabel";
            ingresoLabel.Size = new System.Drawing.Size(45, 13);
            ingresoLabel.TabIndex = 18;
            ingresoLabel.Text = "Ingreso:";
            // 
            // ingresoDateTimePicker
            // 
            this.ingresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadoBindingSource, "Ingreso", true));
            this.ingresoDateTimePicker.Location = new System.Drawing.Point(126, 263);
            this.ingresoDateTimePicker.Name = "ingresoDateTimePicker";
            this.ingresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ingresoDateTimePicker.TabIndex = 19;
            // 
            // nacimientoLabel
            // 
            nacimientoLabel.AutoSize = true;
            nacimientoLabel.Location = new System.Drawing.Point(27, 293);
            nacimientoLabel.Name = "nacimientoLabel";
            nacimientoLabel.Size = new System.Drawing.Size(63, 13);
            nacimientoLabel.TabIndex = 20;
            nacimientoLabel.Text = "Nacimiento:";
            // 
            // nacimientoDateTimePicker
            // 
            this.nacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadoBindingSource, "Nacimiento", true));
            this.nacimientoDateTimePicker.Location = new System.Drawing.Point(126, 289);
            this.nacimientoDateTimePicker.Name = "nacimientoDateTimePicker";
            this.nacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nacimientoDateTimePicker.TabIndex = 21;
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(27, 318);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(77, 13);
            departamentoLabel.TabIndex = 22;
            departamentoLabel.Text = "Departamento:";
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Departamento", true));
            this.departamentoTextBox.Location = new System.Drawing.Point(126, 315);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.departamentoTextBox.TabIndex = 23;
            // 
            // centroLabel
            // 
            centroLabel.AutoSize = true;
            centroLabel.Location = new System.Drawing.Point(27, 344);
            centroLabel.Name = "centroLabel";
            centroLabel.Size = new System.Drawing.Size(41, 13);
            centroLabel.TabIndex = 24;
            centroLabel.Text = "Centro:";
            // 
            // centroTextBox
            // 
            this.centroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Centro", true));
            this.centroTextBox.Location = new System.Drawing.Point(126, 341);
            this.centroTextBox.Name = "centroTextBox";
            this.centroTextBox.Size = new System.Drawing.Size(200, 20);
            this.centroTextBox.TabIndex = 25;
            // 
            // tipoContratoLabel
            // 
            tipoContratoLabel.AutoSize = true;
            tipoContratoLabel.Location = new System.Drawing.Point(27, 370);
            tipoContratoLabel.Name = "tipoContratoLabel";
            tipoContratoLabel.Size = new System.Drawing.Size(74, 13);
            tipoContratoLabel.TabIndex = 26;
            tipoContratoLabel.Text = "Tipo Contrato:";
            // 
            // tipoContratoTextBox
            // 
            this.tipoContratoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "TipoContrato", true));
            this.tipoContratoTextBox.Location = new System.Drawing.Point(126, 367);
            this.tipoContratoTextBox.Name = "tipoContratoTextBox";
            this.tipoContratoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoContratoTextBox.TabIndex = 27;
            // 
            // precioHoraLabel
            // 
            precioHoraLabel.AutoSize = true;
            precioHoraLabel.Location = new System.Drawing.Point(27, 396);
            precioHoraLabel.Name = "precioHoraLabel";
            precioHoraLabel.Size = new System.Drawing.Size(66, 13);
            precioHoraLabel.TabIndex = 28;
            precioHoraLabel.Text = "Precio Hora:";
            // 
            // precioHoraTextBox
            // 
            this.precioHoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "PrecioHora", true));
            this.precioHoraTextBox.Location = new System.Drawing.Point(126, 393);
            this.precioHoraTextBox.Name = "precioHoraTextBox";
            this.precioHoraTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioHoraTextBox.TabIndex = 29;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 662);
            this.Controls.Add(codigoEmpleadoLabel);
            this.Controls.Add(this.codigoEmpleadoTextBox);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.rolTextBox);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(ingresoLabel);
            this.Controls.Add(this.ingresoDateTimePicker);
            this.Controls.Add(nacimientoLabel);
            this.Controls.Add(this.nacimientoDateTimePicker);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.departamentoTextBox);
            this.Controls.Add(centroLabel);
            this.Controls.Add(this.centroTextBox);
            this.Controls.Add(tipoContratoLabel);
            this.Controls.Add(this.tipoContratoTextBox);
            this.Controls.Add(precioHoraLabel);
            this.Controls.Add(this.precioHoraTextBox);
            this.Controls.Add(this.empleadoDataGridView);
            this.Controls.Add(this.empleadoBindingNavigator);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).EndInit();
            this.empleadoBindingNavigator.ResumeLayout(false);
            this.empleadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultas consultas;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ConsultasTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private ConsultasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empleadoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton empleadoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView empleadoDataGridView;
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
        private System.Windows.Forms.TextBox codigoEmpleadoTextBox;
        private System.Windows.Forms.TextBox rolTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker ingresoDateTimePicker;
        private System.Windows.Forms.DateTimePicker nacimientoDateTimePicker;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.TextBox centroTextBox;
        private System.Windows.Forms.TextBox tipoContratoTextBox;
        private System.Windows.Forms.TextBox precioHoraTextBox;
    }
}