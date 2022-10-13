
namespace AqueaductoApp.CapaVistas
{
    partial class FrmagregarPredio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAgregarPredio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.labelBarrio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.comboBarrio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.GridPropietario = new System.Windows.Forms.DataGridView();
            this.idPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIETARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.pROPIETARIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAgregarPredio
            // 
            this.labelAgregarPredio.AutoSize = true;
            this.labelAgregarPredio.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.labelAgregarPredio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.labelAgregarPredio.Location = new System.Drawing.Point(63, 73);
            this.labelAgregarPredio.Name = "labelAgregarPredio";
            this.labelAgregarPredio.Size = new System.Drawing.Size(231, 29);
            this.labelAgregarPredio.TabIndex = 21;
            this.labelAgregarPredio.Text = "Agregar Predios";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button2.Location = new System.Drawing.Point(319, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(46)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnAgregar.Location = new System.Drawing.Point(114, 514);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 33);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtCedula.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.txtCedula.Location = new System.Drawing.Point(260, 141);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(139, 23);
            this.txtCedula.TabIndex = 51;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // labelBarrio
            // 
            this.labelBarrio.AutoSize = true;
            this.labelBarrio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.labelBarrio.Location = new System.Drawing.Point(141, 369);
            this.labelBarrio.Name = "labelBarrio";
            this.labelBarrio.Size = new System.Drawing.Size(107, 16);
            this.labelBarrio.TabIndex = 67;
            this.labelBarrio.Text = "Barrio Predio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label12.Location = new System.Drawing.Point(135, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 75;
            this.label12.Text = "Estado Predio:";
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.comboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstado.Location = new System.Drawing.Point(336, 461);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(91, 24);
            this.comboEstado.TabIndex = 74;
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(128, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Estrato Predio: ";
            // 
            // comboEstrato
            // 
            this.comboEstrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.comboEstrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboEstrato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboEstrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboEstrato.Location = new System.Drawing.Point(336, 417);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(91, 24);
            this.comboEstrato.TabIndex = 76;
            this.comboEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstrato_KeyPress);
            // 
            // comboBarrio
            // 
            this.comboBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.comboBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBarrio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.comboBarrio.FormattingEnabled = true;
            this.comboBarrio.Items.AddRange(new object[] {
            "Colombia",
            "Colombina",
            "San Pedro",
            "Sembrador",
            "Petruc",
            "Independencia",
            "Las Flores"});
            this.comboBarrio.Location = new System.Drawing.Point(288, 366);
            this.comboBarrio.Name = "comboBarrio";
            this.comboBarrio.Size = new System.Drawing.Size(139, 24);
            this.comboBarrio.TabIndex = 78;
            this.comboBarrio.SelectedIndexChanged += new System.EventHandler(this.comboBarrio_SelectedIndexChanged);
            this.comboBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBarrio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(111, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Número Catastro:";
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtCatastro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCatastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.txtCatastro.Location = new System.Drawing.Point(288, 322);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.Size = new System.Drawing.Size(139, 23);
            this.txtCatastro.TabIndex = 80;
            this.txtCatastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatastro_KeyPress);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(411, 141);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(83, 20);
            this.iconButton1.TabIndex = 82;
            this.iconButton1.Text = "Buscar Propietario";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(83, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "Cédula Propietario";
            // 
            // GridPropietario
            // 
            this.GridPropietario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridPropietario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPropietario.AutoGenerateColumns = false;
            this.GridPropietario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.GridPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPropietario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPropietario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridPropietario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPropietario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridPropietario.ColumnHeadersHeight = 20;
            this.GridPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridPropietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPropietarioDataGridViewTextBoxColumn,
            this.cedulaPropietarioDataGridViewTextBoxColumn,
            this.nombrePropietarioDataGridViewTextBoxColumn,
            this.apellidoPropietarioDataGridViewTextBoxColumn,
            this.celularPropietarioDataGridViewTextBoxColumn,
            this.correoPropietarioDataGridViewTextBoxColumn,
            this.estadoPropietarioDataGridViewTextBoxColumn});
            this.GridPropietario.DataSource = this.pROPIETARIOSBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPropietario.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridPropietario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridPropietario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridPropietario.Location = new System.Drawing.Point(114, 190);
            this.GridPropietario.Name = "GridPropietario";
            this.GridPropietario.ReadOnly = true;
            this.GridPropietario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridPropietario.RowHeadersVisible = false;
            this.GridPropietario.RowHeadersWidth = 42;
            this.GridPropietario.RowTemplate.Height = 25;
            this.GridPropietario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridPropietario.Size = new System.Drawing.Size(367, 113);
            this.GridPropietario.TabIndex = 85;
            this.GridPropietario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPredio_CellContentClick_1);
            // 
            // idPropietarioDataGridViewTextBoxColumn
            // 
            this.idPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Propietario";
            this.idPropietarioDataGridViewTextBoxColumn.HeaderText = "Id_Propietario";
            this.idPropietarioDataGridViewTextBoxColumn.Name = "idPropietarioDataGridViewTextBoxColumn";
            this.idPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPropietarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // cedulaPropietarioDataGridViewTextBoxColumn
            // 
            this.cedulaPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Propietario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.cedulaPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cedulaPropietarioDataGridViewTextBoxColumn.HeaderText = "Cédula Propietario";
            this.cedulaPropietarioDataGridViewTextBoxColumn.Name = "cedulaPropietarioDataGridViewTextBoxColumn";
            this.cedulaPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaPropietarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombrePropietarioDataGridViewTextBoxColumn
            // 
            this.nombrePropietarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Propietario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.nombrePropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombrePropietarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrePropietarioDataGridViewTextBoxColumn.Name = "nombrePropietarioDataGridViewTextBoxColumn";
            this.nombrePropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoPropietarioDataGridViewTextBoxColumn
            // 
            this.apellidoPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Propietario";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.apellidoPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.apellidoPropietarioDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoPropietarioDataGridViewTextBoxColumn.Name = "apellidoPropietarioDataGridViewTextBoxColumn";
            this.apellidoPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularPropietarioDataGridViewTextBoxColumn
            // 
            this.celularPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Celular_Propietario";
            this.celularPropietarioDataGridViewTextBoxColumn.HeaderText = "Celular_Propietario";
            this.celularPropietarioDataGridViewTextBoxColumn.Name = "celularPropietarioDataGridViewTextBoxColumn";
            this.celularPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularPropietarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // correoPropietarioDataGridViewTextBoxColumn
            // 
            this.correoPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Correo_Propietario";
            this.correoPropietarioDataGridViewTextBoxColumn.HeaderText = "Correo_Propietario";
            this.correoPropietarioDataGridViewTextBoxColumn.Name = "correoPropietarioDataGridViewTextBoxColumn";
            this.correoPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoPropietarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoPropietarioDataGridViewTextBoxColumn
            // 
            this.estadoPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Estado_Propietario";
            this.estadoPropietarioDataGridViewTextBoxColumn.HeaderText = "Estado_Propietario";
            this.estadoPropietarioDataGridViewTextBoxColumn.Name = "estadoPropietarioDataGridViewTextBoxColumn";
            this.estadoPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoPropietarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROPIETARIOSBindingSource
            // 
            this.pROPIETARIOSBindingSource.DataMember = "PROPIETARIOS";
            this.pROPIETARIOSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROPIETARIOSTableAdapter
            // 
            this.pROPIETARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmagregarPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(586, 581);
            this.Controls.Add(this.GridPropietario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBarrio);
            this.Controls.Add(this.comboEstrato);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBarrio);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelAgregarPredio);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmagregarPredio";
            this.Text = "Agregar Propietario";
            this.Load += new System.EventHandler(this.FrmagregarPredio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAgregarPredio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label labelBarrio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEstrato;
        private System.Windows.Forms.ComboBox comboBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatastro;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridPropietario;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pROPIETARIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter pROPIETARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPropietarioDataGridViewTextBoxColumn;
    }
}