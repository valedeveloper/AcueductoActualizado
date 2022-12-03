
namespace AqueaductoApp.CapaVistas
{
    partial class FrmAgregarFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarFactura));
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.labelIdCatratral = new System.Windows.Forms.Label();
            this.btnAgregarFact = new FontAwesome.Sharp.IconButton();
            this.btnCalcularFac = new FontAwesome.Sharp.IconButton();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridPredio = new System.Windows.Forms.DataGridView();
            this.idPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCatastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Estrato = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eSTRATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.Id_Barrio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bARRIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREDIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pREDIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pREDIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            this.GridConsumo = new System.Windows.Forms.DataGridView();
            this.idConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCatastroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrosCubicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSUMOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
            this.totalFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConsecutivo = new System.Windows.Forms.Label();
            this.eSTRATOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            this.bARRIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.txtCatastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatastro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCatastro.ForeColor = System.Drawing.Color.White;
            this.txtCatastro.Location = new System.Drawing.Point(439, 246);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.Size = new System.Drawing.Size(192, 16);
            this.txtCatastro.TabIndex = 64;
            this.txtCatastro.TextChanged += new System.EventHandler(this.txtCatastro_TextChanged);
            this.txtCatastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatastro_KeyPress);
            // 
            // labelIdCatratral
            // 
            this.labelIdCatratral.AutoSize = true;
            this.labelIdCatratral.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCatratral.ForeColor = System.Drawing.Color.DimGray;
            this.labelIdCatratral.Location = new System.Drawing.Point(436, 215);
            this.labelIdCatratral.Name = "labelIdCatratral";
            this.labelIdCatratral.Size = new System.Drawing.Size(159, 16);
            this.labelIdCatratral.TabIndex = 63;
            this.labelIdCatratral.Text = "Número de Catastro:";
            // 
            // btnAgregarFact
            // 
            this.btnAgregarFact.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarFact.FlatAppearance.BorderSize = 0;
            this.btnAgregarFact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregarFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFact.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarFact.ForeColor = System.Drawing.Color.MintCream;
            this.btnAgregarFact.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarFact.IconColor = System.Drawing.Color.Black;
            this.btnAgregarFact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarFact.Location = new System.Drawing.Point(439, 590);
            this.btnAgregarFact.Name = "btnAgregarFact";
            this.btnAgregarFact.Size = new System.Drawing.Size(171, 37);
            this.btnAgregarFact.TabIndex = 72;
            this.btnAgregarFact.Text = "Agregar Factura";
            this.btnAgregarFact.UseVisualStyleBackColor = false;
            this.btnAgregarFact.Click += new System.EventHandler(this.btnAgregarFact_Click);
            // 
            // btnCalcularFac
            // 
            this.btnCalcularFac.BackColor = System.Drawing.Color.Green;
            this.btnCalcularFac.FlatAppearance.BorderSize = 0;
            this.btnCalcularFac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalcularFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularFac.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcularFac.ForeColor = System.Drawing.Color.MintCream;
            this.btnCalcularFac.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCalcularFac.IconColor = System.Drawing.Color.Black;
            this.btnCalcularFac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcularFac.Location = new System.Drawing.Point(162, 590);
            this.btnCalcularFac.Name = "btnCalcularFac";
            this.btnCalcularFac.Size = new System.Drawing.Size(171, 37);
            this.btnCalcularFac.TabIndex = 76;
            this.btnCalcularFac.Text = "Calcular Factura";
            this.btnCalcularFac.UseVisualStyleBackColor = false;
            this.btnCalcularFac.Click += new System.EventHandler(this.btnCalcularFac_Click);
            // 
            // txtMetros
            // 
            this.txtMetros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.txtMetros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetros.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMetros.ForeColor = System.Drawing.Color.White;
            this.txtMetros.Location = new System.Drawing.Point(439, 416);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.ReadOnly = true;
            this.txtMetros.Size = new System.Drawing.Size(192, 16);
            this.txtMetros.TabIndex = 79;
            this.txtMetros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetros_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(436, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Lectura Consumo:";
            // 
            // GridPredio
            // 
            this.GridPredio.AllowUserToAddRows = false;
            this.GridPredio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridPredio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.GridPredio.AutoGenerateColumns = false;
            this.GridPredio.BackgroundColor = System.Drawing.Color.White;
            this.GridPredio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPredio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPredio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridPredio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPredio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridPredio.ColumnHeadersHeight = 20;
            this.GridPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridPredio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPredioDataGridViewTextBoxColumn,
            this.numeroCatastroDataGridViewTextBoxColumn,
            this.cedulaPropietarioDataGridViewTextBoxColumn,
            this.Id_Estrato,
            this.Id_Barrio,
            this.estadoPredioDataGridViewTextBoxColumn});
            this.GridPredio.DataSource = this.pREDIOSBindingSource1;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPredio.DefaultCellStyle = dataGridViewCellStyle14;
            this.GridPredio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridPredio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridPredio.Location = new System.Drawing.Point(439, 115);
            this.GridPredio.Name = "GridPredio";
            this.GridPredio.ReadOnly = true;
            this.GridPredio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridPredio.RowHeadersVisible = false;
            this.GridPredio.RowHeadersWidth = 42;
            this.GridPredio.RowTemplate.Height = 25;
            this.GridPredio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridPredio.Size = new System.Drawing.Size(207, 82);
            this.GridPredio.TabIndex = 89;
            this.toolTip1.SetToolTip(this.GridPredio, "Seleccione el Número de Catastro");
            this.GridPredio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.numeroCatastroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.numeroCatastroDataGridViewTextBoxColumn.HeaderText = "Catastro";
            this.numeroCatastroDataGridViewTextBoxColumn.Name = "numeroCatastroDataGridViewTextBoxColumn";
            this.numeroCatastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaPropietarioDataGridViewTextBoxColumn
            // 
            this.cedulaPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Propietario";
            this.cedulaPropietarioDataGridViewTextBoxColumn.HeaderText = "Cedula_Propietario";
            this.cedulaPropietarioDataGridViewTextBoxColumn.Name = "cedulaPropietarioDataGridViewTextBoxColumn";
            this.cedulaPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaPropietarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // Id_Estrato
            // 
            this.Id_Estrato.DataPropertyName = "Id_Estrato";
            this.Id_Estrato.DataSource = this.eSTRATOSBindingSource;
            this.Id_Estrato.DisplayMember = "Numero_Estrato";
            this.Id_Estrato.DisplayStyleForCurrentCellOnly = true;
            this.Id_Estrato.HeaderText = "Estrato";
            this.Id_Estrato.Name = "Id_Estrato";
            this.Id_Estrato.ReadOnly = true;
            this.Id_Estrato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Estrato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Id_Estrato.ValueMember = "Id_Estrato";
            // 
            // eSTRATOSBindingSource
            // 
            this.eSTRATOSBindingSource.DataMember = "ESTRATOS";
            this.eSTRATOSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Id_Barrio
            // 
            this.Id_Barrio.DataPropertyName = "Id_Barrio";
            this.Id_Barrio.DataSource = this.bARRIOSBindingSource;
            this.Id_Barrio.DisplayMember = "Nombre_Barrio";
            this.Id_Barrio.HeaderText = "Id_Barrio";
            this.Id_Barrio.Name = "Id_Barrio";
            this.Id_Barrio.ReadOnly = true;
            this.Id_Barrio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Barrio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Id_Barrio.ValueMember = "Id_Barrio";
            this.Id_Barrio.Visible = false;
            // 
            // bARRIOSBindingSource
            // 
            this.bARRIOSBindingSource.DataMember = "BARRIOS";
            this.bARRIOSBindingSource.DataSource = this.dataSet1;
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
            // pREDIOSBindingSource
            // 
            this.pREDIOSBindingSource.DataMember = "PREDIOS";
            this.pREDIOSBindingSource.DataSource = this.dataSet1;
            // 
            // pREDIOSTableAdapter
            // 
            this.pREDIOSTableAdapter.ClearBeforeFill = true;
            // 
            // GridConsumo
            // 
            this.GridConsumo.AllowUserToAddRows = false;
            this.GridConsumo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridConsumo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.GridConsumo.AutoGenerateColumns = false;
            this.GridConsumo.BackgroundColor = System.Drawing.Color.White;
            this.GridConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridConsumo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridConsumo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridConsumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.GridConsumo.ColumnHeadersHeight = 20;
            this.GridConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridConsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsumoDataGridViewTextBoxColumn,
            this.numeroCatastroDataGridViewTextBoxColumn1,
            this.fechaConsumoDataGridViewTextBoxColumn,
            this.mesConsumoDataGridViewTextBoxColumn,
            this.metrosCubicosDataGridViewTextBoxColumn});
            this.GridConsumo.DataSource = this.cONSUMOSBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridConsumo.DefaultCellStyle = dataGridViewCellStyle20;
            this.GridConsumo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridConsumo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridConsumo.Location = new System.Drawing.Point(439, 293);
            this.GridConsumo.Name = "GridConsumo";
            this.GridConsumo.ReadOnly = true;
            this.GridConsumo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridConsumo.RowHeadersVisible = false;
            this.GridConsumo.RowHeadersWidth = 42;
            this.GridConsumo.RowTemplate.Height = 25;
            this.GridConsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridConsumo.Size = new System.Drawing.Size(249, 79);
            this.GridConsumo.TabIndex = 90;
            this.GridConsumo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idConsumoDataGridViewTextBoxColumn
            // 
            this.idConsumoDataGridViewTextBoxColumn.DataPropertyName = "Id_Consumo";
            this.idConsumoDataGridViewTextBoxColumn.HeaderText = "Id_Consumo";
            this.idConsumoDataGridViewTextBoxColumn.Name = "idConsumoDataGridViewTextBoxColumn";
            this.idConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConsumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroCatastroDataGridViewTextBoxColumn1
            // 
            this.numeroCatastroDataGridViewTextBoxColumn1.DataPropertyName = "Numero_Catastro";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.numeroCatastroDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle17;
            this.numeroCatastroDataGridViewTextBoxColumn1.HeaderText = "Numero Catastro";
            this.numeroCatastroDataGridViewTextBoxColumn1.Name = "numeroCatastroDataGridViewTextBoxColumn1";
            this.numeroCatastroDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numeroCatastroDataGridViewTextBoxColumn1.Width = 120;
            // 
            // fechaConsumoDataGridViewTextBoxColumn
            // 
            this.fechaConsumoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Consumo";
            this.fechaConsumoDataGridViewTextBoxColumn.HeaderText = "Fecha_Consumo";
            this.fechaConsumoDataGridViewTextBoxColumn.Name = "fechaConsumoDataGridViewTextBoxColumn";
            this.fechaConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaConsumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // mesConsumoDataGridViewTextBoxColumn
            // 
            this.mesConsumoDataGridViewTextBoxColumn.DataPropertyName = "Mes_Consumo";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.mesConsumoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.mesConsumoDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesConsumoDataGridViewTextBoxColumn.Name = "mesConsumoDataGridViewTextBoxColumn";
            this.mesConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesConsumoDataGridViewTextBoxColumn.Visible = false;
            this.mesConsumoDataGridViewTextBoxColumn.Width = 50;
            // 
            // metrosCubicosDataGridViewTextBoxColumn
            // 
            this.metrosCubicosDataGridViewTextBoxColumn.DataPropertyName = "Metros_Cubicos";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.metrosCubicosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.metrosCubicosDataGridViewTextBoxColumn.HeaderText = "Metros Cúbicos";
            this.metrosCubicosDataGridViewTextBoxColumn.Name = "metrosCubicosDataGridViewTextBoxColumn";
            this.metrosCubicosDataGridViewTextBoxColumn.ReadOnly = true;
            this.metrosCubicosDataGridViewTextBoxColumn.Width = 120;
            // 
            // cONSUMOSBindingSource
            // 
            this.cONSUMOSBindingSource.DataMember = "CONSUMOS";
            this.cONSUMOSBindingSource.DataSource = this.dataSet1;
            // 
            // cONSUMOSTableAdapter
            // 
            this.cONSUMOSTableAdapter.ClearBeforeFill = true;
            // 
            // totalFactura
            // 
            this.totalFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.totalFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalFactura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFactura.ForeColor = System.Drawing.Color.White;
            this.totalFactura.Location = new System.Drawing.Point(339, 504);
            this.totalFactura.Name = "totalFactura";
            this.totalFactura.ReadOnly = true;
            this.totalFactura.Size = new System.Drawing.Size(192, 20);
            this.totalFactura.TabIndex = 92;
            this.totalFactura.TextChanged += new System.EventHandler(this.totalFactura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(260, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 91;
            this.label2.Text = "Total:";
            // 
            // labelConsecutivo
            // 
            this.labelConsecutivo.AutoSize = true;
            this.labelConsecutivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsecutivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.labelConsecutivo.Location = new System.Drawing.Point(443, 41);
            this.labelConsecutivo.Name = "labelConsecutivo";
            this.labelConsecutivo.Size = new System.Drawing.Size(23, 16);
            this.labelConsecutivo.TabIndex = 100;
            this.labelConsecutivo.Text = "...";
            this.labelConsecutivo.Visible = false;
            // 
            // eSTRATOSTableAdapter
            // 
            this.eSTRATOSTableAdapter.ClearBeforeFill = true;
            // 
            // bARRIOSTableAdapter
            // 
            this.bARRIOSTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 50);
            this.panel1.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(267, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Agregar Factura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 112;
            this.label3.Text = "Seleccione Número de Catastro";
            // 
            // FrmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 745);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelConsecutivo);
            this.Controls.Add(this.totalFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridConsumo);
            this.Controls.Add(this.GridPredio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.btnCalcularFac);
            this.Controls.Add(this.btnAgregarFact);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.labelIdCatratral);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarFactura";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9";
            this.Load += new System.EventHandler(this.FrmAgregarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCatastro;
        private System.Windows.Forms.Label labelIdCatratral;
        private FontAwesome.Sharp.IconButton btnAgregarFact;
        private FontAwesome.Sharp.IconButton btnCalcularFac;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridPredio;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pREDIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter pREDIOSTableAdapter;
        private System.Windows.Forms.DataGridView GridConsumo;
        private System.Windows.Forms.BindingSource cONSUMOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter cONSUMOSTableAdapter;
        private System.Windows.Forms.TextBox totalFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estratoPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrioPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pREDIOSBindingSource1;
        private System.Windows.Forms.BindingSource eSTRATOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter eSTRATOSTableAdapter;
        private System.Windows.Forms.BindingSource bARRIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter bARRIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCatastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Id_Estrato;
        private System.Windows.Forms.DataGridViewComboBoxColumn Id_Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCatastroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrosCubicosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}