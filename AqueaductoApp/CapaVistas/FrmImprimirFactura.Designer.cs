
namespace AqueaductoApp.CapaVistas
{
    partial class FrmImprimirFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.labelConsecutivo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.fACTURASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURASTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager();
            this.GridImprimir = new System.Windows.Forms.DataGridView();
            this.consecutivoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCatastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estratoPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrioPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.codigoQrDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.mesFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumoMetrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTURASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(68, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imprimir Facturas";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DeepPink;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(162, 477);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(3);
            this.iconButton1.Size = new System.Drawing.Size(213, 47);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Generar Factura";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(385, 207);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 26);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelConsecutivo
            // 
            this.labelConsecutivo.AutoSize = true;
            this.labelConsecutivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsecutivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.labelConsecutivo.Location = new System.Drawing.Point(193, 217);
            this.labelConsecutivo.Name = "labelConsecutivo";
            this.labelConsecutivo.Size = new System.Drawing.Size(0, 16);
            this.labelConsecutivo.TabIndex = 86;
            this.labelConsecutivo.Visible = false;
            this.labelConsecutivo.TextChanged += new System.EventHandler(this.labelConsecutivo_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label.Location = new System.Drawing.Point(70, 217);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 16);
            this.label.TabIndex = 85;
            this.label.Text = "Consecutivo:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURASBindingSource
            // 
            this.fACTURASBindingSource.DataMember = "FACTURAS";
            this.fACTURASBindingSource.DataSource = this.dataSet1;
            // 
            // fACTURASTableAdapter
            // 
            this.fACTURASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONSUMOSTableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = this.fACTURASTableAdapter;
            this.tableAdapterManager.PREDIOSTableAdapter = null;
            this.tableAdapterManager.PROPIETARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // GridImprimir
            // 
            this.GridImprimir.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridImprimir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridImprimir.AutoGenerateColumns = false;
            this.GridImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.GridImprimir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridImprimir.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridImprimir.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridImprimir.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridImprimir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridImprimir.ColumnHeadersHeight = 20;
            this.GridImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridImprimir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.consecutivoFacturaDataGridViewTextBoxColumn,
            this.numeroCatastroDataGridViewTextBoxColumn,
            this.fechaConsumoDataGridViewTextBoxColumn,
            this.cedulaPropietarioDataGridViewTextBoxColumn,
            this.nombrePropietarioDataGridViewTextBoxColumn,
            this.celularPropietarioDataGridViewTextBoxColumn,
            this.correoPropietarioDataGridViewTextBoxColumn,
            this.estratoPredioDataGridViewTextBoxColumn,
            this.barrioPredioDataGridViewTextBoxColumn,
            this.idConsumoDataGridViewTextBoxColumn,
            this.valorFacturaDataGridViewTextBoxColumn,
            this.estadoFacturaDataGridViewTextBoxColumn,
            this.codigoBarrasDataGridViewImageColumn,
            this.codigoQrDataGridViewImageColumn,
            this.mesFacturaDataGridViewTextBoxColumn,
            this.consumoMetrosDataGridViewTextBoxColumn});
            this.GridImprimir.DataSource = this.fACTURASBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridImprimir.DefaultCellStyle = dataGridViewCellStyle7;
            this.GridImprimir.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridImprimir.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridImprimir.Location = new System.Drawing.Point(59, 282);
            this.GridImprimir.Name = "GridImprimir";
            this.GridImprimir.ReadOnly = true;
            this.GridImprimir.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridImprimir.RowHeadersVisible = false;
            this.GridImprimir.RowHeadersWidth = 42;
            this.GridImprimir.RowTemplate.Height = 25;
            this.GridImprimir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridImprimir.Size = new System.Drawing.Size(435, 126);
            this.GridImprimir.TabIndex = 87;
            this.GridImprimir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsumo_CellContentClick);
            // 
            // consecutivoFacturaDataGridViewTextBoxColumn
            // 
            this.consecutivoFacturaDataGridViewTextBoxColumn.DataPropertyName = "Consecutivo_Factura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.consecutivoFacturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.consecutivoFacturaDataGridViewTextBoxColumn.HeaderText = "Consecutivo";
            this.consecutivoFacturaDataGridViewTextBoxColumn.Name = "consecutivoFacturaDataGridViewTextBoxColumn";
            this.consecutivoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.consecutivoFacturaDataGridViewTextBoxColumn.Width = 110;
            // 
            // numeroCatastroDataGridViewTextBoxColumn
            // 
            this.numeroCatastroDataGridViewTextBoxColumn.DataPropertyName = "Numero_Catastro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.numeroCatastroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.numeroCatastroDataGridViewTextBoxColumn.HeaderText = "Catastro";
            this.numeroCatastroDataGridViewTextBoxColumn.Name = "numeroCatastroDataGridViewTextBoxColumn";
            this.numeroCatastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaConsumoDataGridViewTextBoxColumn
            // 
            this.fechaConsumoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Consumo";
            this.fechaConsumoDataGridViewTextBoxColumn.HeaderText = "Fecha_Consumo";
            this.fechaConsumoDataGridViewTextBoxColumn.Name = "fechaConsumoDataGridViewTextBoxColumn";
            this.fechaConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaConsumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cedulaPropietarioDataGridViewTextBoxColumn
            // 
            this.cedulaPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Propietario";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.cedulaPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cedulaPropietarioDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaPropietarioDataGridViewTextBoxColumn.Name = "cedulaPropietarioDataGridViewTextBoxColumn";
            this.cedulaPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePropietarioDataGridViewTextBoxColumn
            // 
            this.nombrePropietarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Propietario";
            this.nombrePropietarioDataGridViewTextBoxColumn.HeaderText = "Nombre_Propietario";
            this.nombrePropietarioDataGridViewTextBoxColumn.Name = "nombrePropietarioDataGridViewTextBoxColumn";
            this.nombrePropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePropietarioDataGridViewTextBoxColumn.Visible = false;
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
            // estratoPredioDataGridViewTextBoxColumn
            // 
            this.estratoPredioDataGridViewTextBoxColumn.DataPropertyName = "Estrato_Predio";
            this.estratoPredioDataGridViewTextBoxColumn.HeaderText = "Estrato_Predio";
            this.estratoPredioDataGridViewTextBoxColumn.Name = "estratoPredioDataGridViewTextBoxColumn";
            this.estratoPredioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estratoPredioDataGridViewTextBoxColumn.Visible = false;
            // 
            // barrioPredioDataGridViewTextBoxColumn
            // 
            this.barrioPredioDataGridViewTextBoxColumn.DataPropertyName = "Barrio_Predio";
            this.barrioPredioDataGridViewTextBoxColumn.HeaderText = "Barrio_Predio";
            this.barrioPredioDataGridViewTextBoxColumn.Name = "barrioPredioDataGridViewTextBoxColumn";
            this.barrioPredioDataGridViewTextBoxColumn.ReadOnly = true;
            this.barrioPredioDataGridViewTextBoxColumn.Visible = false;
            // 
            // idConsumoDataGridViewTextBoxColumn
            // 
            this.idConsumoDataGridViewTextBoxColumn.DataPropertyName = "Id_Consumo";
            this.idConsumoDataGridViewTextBoxColumn.HeaderText = "Id_Consumo";
            this.idConsumoDataGridViewTextBoxColumn.Name = "idConsumoDataGridViewTextBoxColumn";
            this.idConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConsumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorFacturaDataGridViewTextBoxColumn
            // 
            this.valorFacturaDataGridViewTextBoxColumn.DataPropertyName = "Valor_Factura";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.valorFacturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorFacturaDataGridViewTextBoxColumn.HeaderText = "Valor Factura";
            this.valorFacturaDataGridViewTextBoxColumn.Name = "valorFacturaDataGridViewTextBoxColumn";
            this.valorFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoFacturaDataGridViewTextBoxColumn
            // 
            this.estadoFacturaDataGridViewTextBoxColumn.DataPropertyName = "Estado_Factura";
            this.estadoFacturaDataGridViewTextBoxColumn.HeaderText = "Estado_Factura";
            this.estadoFacturaDataGridViewTextBoxColumn.Name = "estadoFacturaDataGridViewTextBoxColumn";
            this.estadoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoBarrasDataGridViewImageColumn
            // 
            this.codigoBarrasDataGridViewImageColumn.DataPropertyName = "codigo_Barras";
            this.codigoBarrasDataGridViewImageColumn.HeaderText = "codigo_Barras";
            this.codigoBarrasDataGridViewImageColumn.Name = "codigoBarrasDataGridViewImageColumn";
            this.codigoBarrasDataGridViewImageColumn.ReadOnly = true;
            this.codigoBarrasDataGridViewImageColumn.Visible = false;
            // 
            // codigoQrDataGridViewImageColumn
            // 
            this.codigoQrDataGridViewImageColumn.DataPropertyName = "codigo_Qr";
            this.codigoQrDataGridViewImageColumn.HeaderText = "codigo_Qr";
            this.codigoQrDataGridViewImageColumn.Name = "codigoQrDataGridViewImageColumn";
            this.codigoQrDataGridViewImageColumn.ReadOnly = true;
            this.codigoQrDataGridViewImageColumn.Visible = false;
            // 
            // mesFacturaDataGridViewTextBoxColumn
            // 
            this.mesFacturaDataGridViewTextBoxColumn.DataPropertyName = "Mes_Factura";
            this.mesFacturaDataGridViewTextBoxColumn.HeaderText = "Mes_Factura";
            this.mesFacturaDataGridViewTextBoxColumn.Name = "mesFacturaDataGridViewTextBoxColumn";
            this.mesFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // consumoMetrosDataGridViewTextBoxColumn
            // 
            this.consumoMetrosDataGridViewTextBoxColumn.DataPropertyName = "Consumo_Metros";
            this.consumoMetrosDataGridViewTextBoxColumn.HeaderText = "Consumo_Metros";
            this.consumoMetrosDataGridViewTextBoxColumn.Name = "consumoMetrosDataGridViewTextBoxColumn";
            this.consumoMetrosDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumoMetrosDataGridViewTextBoxColumn.Visible = false;
            // 
            // fACTURASBindingSource1
            // 
            this.fACTURASBindingSource1.DataMember = "FACTURAS";
            this.fACTURASBindingSource1.DataSource = this.dataSet1;
            // 
            // FrmImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(560, 647);
            this.Controls.Add(this.GridImprimir);
            this.Controls.Add(this.labelConsecutivo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(195, 43);
            this.Name = "FrmImprimirFactura";
            this.Text = "Imprimir_Factura";
            this.Load += new System.EventHandler(this.FrmImprimirFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label labelConsecutivo;
        private System.Windows.Forms.Label label;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource fACTURASBindingSource;
        private CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter fACTURASTableAdapter;
        private CapaDatos.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView GridImprimir;
        private System.Windows.Forms.BindingSource fACTURASBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCatastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estratoPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrioPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn codigoBarrasDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn codigoQrDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumoMetrosDataGridViewTextBoxColumn;
    }
}