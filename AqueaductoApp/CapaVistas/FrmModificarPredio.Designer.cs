
namespace AqueaductoApp.CapaVistas
{

    partial class FrmModificarPredio
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.labelModificarPredio = new System.Windows.Forms.Label();
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.labelBarrio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCatastral = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboBarrio = new System.Windows.Forms.ComboBox();
            this.bARRIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.bARRIOSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.eSTRATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.GridPredio = new System.Windows.Forms.DataGridView();
            this.idPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCatastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estratoPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrioPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREDIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acueductoDataSet = new AqueaductoApp.AcueductoDataSet();
            this.pREDIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pREDIOSTableAdapter = new AqueaductoApp.AcueductoDataSetTableAdapters.PREDIOSTableAdapter();
            this.pREDIOSTableAdapter1 = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            this.bARRIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bARRIOSTableAdapter = new AqueaductoApp.AcueductoDataSetTableAdapters.BARRIOSTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTRATOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            this.bARRIOSTableAdapter1 = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acueductoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button2.Location = new System.Drawing.Point(310, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(46)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnModificar.Location = new System.Drawing.Point(100, 557);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 33);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // labelModificarPredio
            // 
            this.labelModificarPredio.AutoSize = true;
            this.labelModificarPredio.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.labelModificarPredio.Location = new System.Drawing.Point(70, 80);
            this.labelModificarPredio.Name = "labelModificarPredio";
            this.labelModificarPredio.Size = new System.Drawing.Size(246, 29);
            this.labelModificarPredio.TabIndex = 49;
            this.labelModificarPredio.Text = "Modificar Predios";
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtCatastro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCatastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.txtCatastro.Location = new System.Drawing.Point(259, 142);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.Size = new System.Drawing.Size(145, 23);
            this.txtCatastro.TabIndex = 1;
            this.txtCatastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatastro_KeyPress);
            // 
            // labelBarrio
            // 
            this.labelBarrio.AutoSize = true;
            this.labelBarrio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.labelBarrio.Location = new System.Drawing.Point(103, 364);
            this.labelBarrio.Name = "labelBarrio";
            this.labelBarrio.Size = new System.Drawing.Size(102, 16);
            this.labelBarrio.TabIndex = 55;
            this.labelBarrio.Text = "Barrio Predio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(103, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cédula Propietario";
            // 
            // labelCatastral
            // 
            this.labelCatastral.AutoSize = true;
            this.labelCatastral.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatastral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.labelCatastral.Location = new System.Drawing.Point(90, 145);
            this.labelCatastral.Name = "labelCatastral";
            this.labelCatastral.Size = new System.Drawing.Size(163, 16);
            this.labelCatastral.TabIndex = 50;
            this.labelCatastral.Text = "Número del Catastro:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(410, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 23);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(103, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Estrato Predio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label12.Location = new System.Drawing.Point(103, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 16);
            this.label12.TabIndex = 69;
            this.label12.Text = "Estado Usuario";
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.comboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstado.Location = new System.Drawing.Point(310, 450);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(149, 24);
            this.comboEstado.TabIndex = 68;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress);
            // 
            // comboBarrio
            // 
            this.comboBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.comboBarrio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bARRIOSBindingSource1, "Nombre_Barrio", true));
            this.comboBarrio.DataSource = this.bARRIOSBindingSource2;
            this.comboBarrio.DisplayMember = "Nombre_Barrio";
            this.comboBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBarrio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.comboBarrio.FormattingEnabled = true;
            this.comboBarrio.Location = new System.Drawing.Point(308, 364);
            this.comboBarrio.Name = "comboBarrio";
            this.comboBarrio.Size = new System.Drawing.Size(149, 24);
            this.comboBarrio.TabIndex = 79;
            this.comboBarrio.ValueMember = "Nombre_Barrio";
            this.comboBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBarrio_KeyPress);
            // 
            // bARRIOSBindingSource1
            // 
            this.bARRIOSBindingSource1.DataMember = "BARRIOS";
            this.bARRIOSBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bARRIOSBindingSource2
            // 
            this.bARRIOSBindingSource2.DataMember = "BARRIOS";
            this.bARRIOSBindingSource2.DataSource = this.dataSet1;
            // 
            // comboEstrato
            // 
            this.comboEstrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.comboEstrato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eSTRATOSBindingSource, "Numero_Estrato", true));
            this.comboEstrato.DataSource = this.eSTRATOSBindingSource;
            this.comboEstrato.DisplayMember = "Numero_Estrato";
            this.comboEstrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEstrato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboEstrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Location = new System.Drawing.Point(308, 409);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(149, 24);
            this.comboEstrato.TabIndex = 80;
            this.comboEstrato.ValueMember = "Numero_Estrato";
            this.comboEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstrato_KeyPress);
            // 
            // eSTRATOSBindingSource
            // 
            this.eSTRATOSBindingSource.DataMember = "ESTRATOS";
            this.eSTRATOSBindingSource.DataSource = this.dataSet1;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtCedula.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.txtCedula.Location = new System.Drawing.Point(308, 310);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(149, 23);
            this.txtCedula.TabIndex = 81;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // GridPredio
            // 
            this.GridPredio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridPredio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPredio.AutoGenerateColumns = false;
            this.GridPredio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.GridPredio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPredio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPredio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridPredio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPredio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridPredio.ColumnHeadersHeight = 20;
            this.GridPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridPredio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPredioDataGridViewTextBoxColumn,
            this.numeroCatastroDataGridViewTextBoxColumn,
            this.cedulaPropietarioDataGridViewTextBoxColumn,
            this.estratoPredioDataGridViewTextBoxColumn,
            this.barrioPredioDataGridViewTextBoxColumn,
            this.estadoPredioDataGridViewTextBoxColumn});
            this.GridPredio.DataSource = this.pREDIOSBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPredio.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridPredio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridPredio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridPredio.Location = new System.Drawing.Point(120, 189);
            this.GridPredio.Name = "GridPredio";
            this.GridPredio.ReadOnly = true;
            this.GridPredio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridPredio.RowHeadersVisible = false;
            this.GridPredio.RowHeadersWidth = 42;
            this.GridPredio.RowTemplate.Height = 25;
            this.GridPredio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridPredio.Size = new System.Drawing.Size(327, 100);
            this.GridPredio.TabIndex = 82;
            this.GridPredio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_CellContentClick);
            // 
            // idPredioDataGridViewTextBoxColumn
            // 
            this.idPredioDataGridViewTextBoxColumn.DataPropertyName = "Id_Predio";
            this.idPredioDataGridViewTextBoxColumn.HeaderText = "Id_Predio";
            this.idPredioDataGridViewTextBoxColumn.Name = "idPredioDataGridViewTextBoxColumn";
            this.idPredioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPredioDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroCatastroDataGridViewTextBoxColumn
            // 
            this.numeroCatastroDataGridViewTextBoxColumn.DataPropertyName = "Numero_Catastro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.numeroCatastroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.numeroCatastroDataGridViewTextBoxColumn.HeaderText = "Catastro";
            this.numeroCatastroDataGridViewTextBoxColumn.Name = "numeroCatastroDataGridViewTextBoxColumn";
            this.numeroCatastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaPropietarioDataGridViewTextBoxColumn
            // 
            this.cedulaPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Propietario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.cedulaPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cedulaPropietarioDataGridViewTextBoxColumn.HeaderText = "Propietario";
            this.cedulaPropietarioDataGridViewTextBoxColumn.Name = "cedulaPropietarioDataGridViewTextBoxColumn";
            this.cedulaPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaPropietarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // estratoPredioDataGridViewTextBoxColumn
            // 
            this.estratoPredioDataGridViewTextBoxColumn.DataPropertyName = "Estrato_Predio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.estratoPredioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.estratoPredioDataGridViewTextBoxColumn.HeaderText = "Estrato";
            this.estratoPredioDataGridViewTextBoxColumn.Name = "estratoPredioDataGridViewTextBoxColumn";
            this.estratoPredioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estratoPredioDataGridViewTextBoxColumn.Width = 60;
            // 
            // barrioPredioDataGridViewTextBoxColumn
            // 
            this.barrioPredioDataGridViewTextBoxColumn.DataPropertyName = "Barrio_Predio";
            this.barrioPredioDataGridViewTextBoxColumn.HeaderText = "Barrio_Predio";
            this.barrioPredioDataGridViewTextBoxColumn.Name = "barrioPredioDataGridViewTextBoxColumn";
            this.barrioPredioDataGridViewTextBoxColumn.ReadOnly = true;
            this.barrioPredioDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoPredioDataGridViewTextBoxColumn
            // 
            this.estadoPredioDataGridViewTextBoxColumn.DataPropertyName = "Estado_Predio";
            this.estadoPredioDataGridViewTextBoxColumn.HeaderText = "Estado_Predio";
            this.estadoPredioDataGridViewTextBoxColumn.Name = "estadoPredioDataGridViewTextBoxColumn";
            this.estadoPredioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoPredioDataGridViewTextBoxColumn.Visible = false;
            // 
            // pREDIOSBindingSource1
            // 
            this.pREDIOSBindingSource1.DataMember = "PREDIOS";
            this.pREDIOSBindingSource1.DataSource = this.dataSet1;
            // 
            // acueductoDataSet
            // 
            this.acueductoDataSet.DataSetName = "AcueductoDataSet";
            this.acueductoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pREDIOSBindingSource
            // 
            this.pREDIOSBindingSource.DataMember = "PREDIOS";
            this.pREDIOSBindingSource.DataSource = this.acueductoDataSet;
            // 
            // pREDIOSTableAdapter
            // 
            this.pREDIOSTableAdapter.ClearBeforeFill = true;
            // 
            // pREDIOSTableAdapter1
            // 
            this.pREDIOSTableAdapter1.ClearBeforeFill = true;
            // 
            // bARRIOSBindingSource
            // 
            this.bARRIOSBindingSource.DataMember = "BARRIOS";
            this.bARRIOSBindingSource.DataSource = this.acueductoDataSet;
            // 
            // bARRIOSTableAdapter
            // 
            this.bARRIOSTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // eSTRATOSTableAdapter
            // 
            this.eSTRATOSTableAdapter.ClearBeforeFill = true;
            // 
            // bARRIOSTableAdapter1
            // 
            this.bARRIOSTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmModificarPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(560, 647);
            this.Controls.Add(this.GridPredio);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.comboEstrato);
            this.Controls.Add(this.comboBarrio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBarrio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCatastral);
            this.Controls.Add(this.labelModificarPredio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModificar);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarPredio";
            this.Text = "Modificar Predio";
            this.Load += new System.EventHandler(this.FrmModificarPredio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acueductoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label labelModificarPredio;
        private System.Windows.Forms.TextBox txtCatastro;
        private System.Windows.Forms.Label labelBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCatastral;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.ComboBox comboBarrio;
        private System.Windows.Forms.ComboBox comboEstrato;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridView GridPredio;
        private AcueductoDataSet acueductoDataSet;
        private System.Windows.Forms.BindingSource pREDIOSBindingSource;
        private AcueductoDataSetTableAdapters.PREDIOSTableAdapter pREDIOSTableAdapter;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pREDIOSBindingSource1;
        private CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter pREDIOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCatastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estratoPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrioPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bARRIOSBindingSource;
        private AcueductoDataSetTableAdapters.BARRIOSTableAdapter bARRIOSTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource eSTRATOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter eSTRATOSTableAdapter;
        private System.Windows.Forms.BindingSource bARRIOSBindingSource1;
        private CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter bARRIOSTableAdapter1;
        private System.Windows.Forms.BindingSource bARRIOSBindingSource2;
    }
}