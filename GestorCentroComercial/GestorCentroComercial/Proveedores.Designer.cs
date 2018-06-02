namespace GestorCentroComercial
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            System.Windows.Forms.Label cifLabel;
            System.Windows.Forms.Label nombreProveedorLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label webLabel;
            System.Windows.Forms.Label nombreRepresentanteLabel;
            System.Windows.Forms.Label emailRepresentanteLabel;
            System.Windows.Forms.Label telefonoRepresentanteLabel;
            System.Windows.Forms.Label codigoProveedorLabel;
            this.consultas = new GestorCentroComercial.Consultas();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new GestorCentroComercial.ConsultasTableAdapters.ProveedoresTableAdapter();
            this.tableAdapterManager = new GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager();
            this.proveedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.proveedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proveedoresDataGridView = new System.Windows.Forms.DataGridView();
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
            this.cifTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveedorTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.webTextBox = new System.Windows.Forms.TextBox();
            this.nombreRepresentanteTextBox = new System.Windows.Forms.TextBox();
            this.emailRepresentanteTextBox = new System.Windows.Forms.TextBox();
            this.telefonoRepresentanteTextBox = new System.Windows.Forms.TextBox();
            this.codigoProveedorTextBox = new System.Windows.Forms.TextBox();
            cifLabel = new System.Windows.Forms.Label();
            nombreProveedorLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            webLabel = new System.Windows.Forms.Label();
            nombreRepresentanteLabel = new System.Windows.Forms.Label();
            emailRepresentanteLabel = new System.Windows.Forms.Label();
            telefonoRepresentanteLabel = new System.Windows.Forms.Label();
            codigoProveedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).BeginInit();
            this.proveedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultas
            // 
            this.consultas.DataSetName = "Consultas";
            this.consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.consultas;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArticulosCentroComercialTableAdapter = null;
            this.tableAdapterManager.ArticulosProveedoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestorCentroComercial.ConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // proveedoresBindingNavigator
            // 
            this.proveedoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proveedoresBindingNavigator.BindingSource = this.proveedoresBindingSource;
            this.proveedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proveedoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proveedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.proveedoresBindingNavigatorSaveItem});
            this.proveedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proveedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proveedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proveedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proveedoresBindingNavigator.Name = "proveedoresBindingNavigator";
            this.proveedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proveedoresBindingNavigator.Size = new System.Drawing.Size(1013, 25);
            this.proveedoresBindingNavigator.TabIndex = 0;
            this.proveedoresBindingNavigator.Text = "bindingNavigator1";
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
            // proveedoresBindingNavigatorSaveItem
            // 
            this.proveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proveedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresBindingNavigatorSaveItem.Image")));
            this.proveedoresBindingNavigatorSaveItem.Name = "proveedoresBindingNavigatorSaveItem";
            this.proveedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.proveedoresBindingNavigatorSaveItem.Text = "Save Data";
            this.proveedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.proveedoresBindingNavigatorSaveItem_Click);
            // 
            // proveedoresDataGridView
            // 
            this.proveedoresDataGridView.AutoGenerateColumns = false;
            this.proveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn11});
            this.proveedoresDataGridView.DataSource = this.proveedoresBindingSource;
            this.proveedoresDataGridView.Location = new System.Drawing.Point(12, 396);
            this.proveedoresDataGridView.Name = "proveedoresDataGridView";
            this.proveedoresDataGridView.Size = new System.Drawing.Size(979, 220);
            this.proveedoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cif";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cif";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreProveedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreProveedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodigoPostal";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodigoPostal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Web";
            this.dataGridViewTextBoxColumn7.HeaderText = "Web";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NombreRepresentante";
            this.dataGridViewTextBoxColumn8.HeaderText = "NombreRepresentante";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EmailRepresentante";
            this.dataGridViewTextBoxColumn9.HeaderText = "EmailRepresentante";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TelefonoRepresentante";
            this.dataGridViewTextBoxColumn10.HeaderText = "TelefonoRepresentante";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CodigoProveedor";
            this.dataGridViewTextBoxColumn11.HeaderText = "CodigoProveedor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // cifLabel
            // 
            cifLabel.AutoSize = true;
            cifLabel.Location = new System.Drawing.Point(43, 56);
            cifLabel.Name = "cifLabel";
            cifLabel.Size = new System.Drawing.Size(22, 13);
            cifLabel.TabIndex = 2;
            cifLabel.Text = "Cif:";
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Cif", true));
            this.cifTextBox.Location = new System.Drawing.Point(174, 53);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(100, 20);
            this.cifTextBox.TabIndex = 3;
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.Location = new System.Drawing.Point(43, 82);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(99, 13);
            nombreProveedorLabel.TabIndex = 4;
            nombreProveedorLabel.Text = "Nombre Proveedor:";
            // 
            // nombreProveedorTextBox
            // 
            this.nombreProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "NombreProveedor", true));
            this.nombreProveedorTextBox.Location = new System.Drawing.Point(174, 79);
            this.nombreProveedorTextBox.Name = "nombreProveedorTextBox";
            this.nombreProveedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreProveedorTextBox.TabIndex = 5;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(43, 108);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(174, 105);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 7;
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(43, 134);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            codigoPostalLabel.TabIndex = 8;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "CodigoPostal", true));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(174, 131);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoPostalTextBox.TabIndex = 9;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(43, 160);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(174, 157);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(43, 186);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(174, 183);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // webLabel
            // 
            webLabel.AutoSize = true;
            webLabel.Location = new System.Drawing.Point(43, 212);
            webLabel.Name = "webLabel";
            webLabel.Size = new System.Drawing.Size(33, 13);
            webLabel.TabIndex = 14;
            webLabel.Text = "Web:";
            // 
            // webTextBox
            // 
            this.webTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Web", true));
            this.webTextBox.Location = new System.Drawing.Point(174, 209);
            this.webTextBox.Name = "webTextBox";
            this.webTextBox.Size = new System.Drawing.Size(100, 20);
            this.webTextBox.TabIndex = 15;
            // 
            // nombreRepresentanteLabel
            // 
            nombreRepresentanteLabel.AutoSize = true;
            nombreRepresentanteLabel.Location = new System.Drawing.Point(43, 238);
            nombreRepresentanteLabel.Name = "nombreRepresentanteLabel";
            nombreRepresentanteLabel.Size = new System.Drawing.Size(120, 13);
            nombreRepresentanteLabel.TabIndex = 16;
            nombreRepresentanteLabel.Text = "Nombre Representante:";
            // 
            // nombreRepresentanteTextBox
            // 
            this.nombreRepresentanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "NombreRepresentante", true));
            this.nombreRepresentanteTextBox.Location = new System.Drawing.Point(174, 235);
            this.nombreRepresentanteTextBox.Name = "nombreRepresentanteTextBox";
            this.nombreRepresentanteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreRepresentanteTextBox.TabIndex = 17;
            // 
            // emailRepresentanteLabel
            // 
            emailRepresentanteLabel.AutoSize = true;
            emailRepresentanteLabel.Location = new System.Drawing.Point(43, 264);
            emailRepresentanteLabel.Name = "emailRepresentanteLabel";
            emailRepresentanteLabel.Size = new System.Drawing.Size(108, 13);
            emailRepresentanteLabel.TabIndex = 18;
            emailRepresentanteLabel.Text = "Email Representante:";
            // 
            // emailRepresentanteTextBox
            // 
            this.emailRepresentanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "EmailRepresentante", true));
            this.emailRepresentanteTextBox.Location = new System.Drawing.Point(174, 261);
            this.emailRepresentanteTextBox.Name = "emailRepresentanteTextBox";
            this.emailRepresentanteTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailRepresentanteTextBox.TabIndex = 19;
            // 
            // telefonoRepresentanteLabel
            // 
            telefonoRepresentanteLabel.AutoSize = true;
            telefonoRepresentanteLabel.Location = new System.Drawing.Point(43, 290);
            telefonoRepresentanteLabel.Name = "telefonoRepresentanteLabel";
            telefonoRepresentanteLabel.Size = new System.Drawing.Size(125, 13);
            telefonoRepresentanteLabel.TabIndex = 20;
            telefonoRepresentanteLabel.Text = "Telefono Representante:";
            // 
            // telefonoRepresentanteTextBox
            // 
            this.telefonoRepresentanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "TelefonoRepresentante", true));
            this.telefonoRepresentanteTextBox.Location = new System.Drawing.Point(174, 287);
            this.telefonoRepresentanteTextBox.Name = "telefonoRepresentanteTextBox";
            this.telefonoRepresentanteTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoRepresentanteTextBox.TabIndex = 21;
            // 
            // codigoProveedorLabel
            // 
            codigoProveedorLabel.AutoSize = true;
            codigoProveedorLabel.Location = new System.Drawing.Point(43, 316);
            codigoProveedorLabel.Name = "codigoProveedorLabel";
            codigoProveedorLabel.Size = new System.Drawing.Size(95, 13);
            codigoProveedorLabel.TabIndex = 22;
            codigoProveedorLabel.Text = "Codigo Proveedor:";
            // 
            // codigoProveedorTextBox
            // 
            this.codigoProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "CodigoProveedor", true));
            this.codigoProveedorTextBox.Location = new System.Drawing.Point(174, 313);
            this.codigoProveedorTextBox.Name = "codigoProveedorTextBox";
            this.codigoProveedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoProveedorTextBox.TabIndex = 23;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 628);
            this.Controls.Add(cifLabel);
            this.Controls.Add(this.cifTextBox);
            this.Controls.Add(nombreProveedorLabel);
            this.Controls.Add(this.nombreProveedorTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(codigoPostalLabel);
            this.Controls.Add(this.codigoPostalTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(webLabel);
            this.Controls.Add(this.webTextBox);
            this.Controls.Add(nombreRepresentanteLabel);
            this.Controls.Add(this.nombreRepresentanteTextBox);
            this.Controls.Add(emailRepresentanteLabel);
            this.Controls.Add(this.emailRepresentanteTextBox);
            this.Controls.Add(telefonoRepresentanteLabel);
            this.Controls.Add(this.telefonoRepresentanteTextBox);
            this.Controls.Add(codigoProveedorLabel);
            this.Controls.Add(this.codigoProveedorTextBox);
            this.Controls.Add(this.proveedoresDataGridView);
            this.Controls.Add(this.proveedoresBindingNavigator);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).EndInit();
            this.proveedoresBindingNavigator.ResumeLayout(false);
            this.proveedoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultas consultas;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private ConsultasTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private ConsultasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton proveedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView proveedoresDataGridView;
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
        private System.Windows.Forms.TextBox cifTextBox;
        private System.Windows.Forms.TextBox nombreProveedorTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox webTextBox;
        private System.Windows.Forms.TextBox nombreRepresentanteTextBox;
        private System.Windows.Forms.TextBox emailRepresentanteTextBox;
        private System.Windows.Forms.TextBox telefonoRepresentanteTextBox;
        private System.Windows.Forms.TextBox codigoProveedorTextBox;
    }
}