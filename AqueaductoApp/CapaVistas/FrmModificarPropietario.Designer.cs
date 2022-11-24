
namespace AqueaductoApp.CapaVistas
{
    partial class FrmModificarPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarPropietario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pROPIETARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.pROPIETARIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridPropietario = new System.Windows.Forms.DataGridView();
            this.idPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPropietario)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 49);
            this.panel1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(252, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Modificar Propietarios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.GridPropietario);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.comboEstado);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 686);
            this.panel2.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // GridPropietario
            // 
            this.GridPropietario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.Black;
            this.GridPropietario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.GridPropietario.AutoGenerateColumns = false;
            this.GridPropietario.BackgroundColor = System.Drawing.Color.White;
            this.GridPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPropietario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPropietario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridPropietario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPropietario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
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
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPropietario.DefaultCellStyle = dataGridViewCellStyle63;
            this.GridPropietario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridPropietario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridPropietario.Location = new System.Drawing.Point(231, 56);
            this.GridPropietario.Name = "GridPropietario";
            this.GridPropietario.ReadOnly = true;
            this.GridPropietario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPropietario.RowHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.GridPropietario.RowHeadersVisible = false;
            this.GridPropietario.RowHeadersWidth = 42;
            this.GridPropietario.RowTemplate.Height = 25;
            this.GridPropietario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridPropietario.Size = new System.Drawing.Size(307, 96);
            this.GridPropietario.TabIndex = 83;
            this.GridPropietario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPropietario_CellContentClick);
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
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.cedulaPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle59;
            this.cedulaPropietarioDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaPropietarioDataGridViewTextBoxColumn.Name = "cedulaPropietarioDataGridViewTextBoxColumn";
            this.cedulaPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePropietarioDataGridViewTextBoxColumn
            // 
            this.nombrePropietarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Propietario";
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.nombrePropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle60;
            this.nombrePropietarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrePropietarioDataGridViewTextBoxColumn.Name = "nombrePropietarioDataGridViewTextBoxColumn";
            this.nombrePropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoPropietarioDataGridViewTextBoxColumn
            // 
            this.apellidoPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Propietario";
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.apellidoPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle61;
            this.apellidoPropietarioDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoPropietarioDataGridViewTextBoxColumn.Name = "apellidoPropietarioDataGridViewTextBoxColumn";
            this.apellidoPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularPropietarioDataGridViewTextBoxColumn
            // 
            this.celularPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Celular_Propietario";
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.celularPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle62;
            this.celularPropietarioDataGridViewTextBoxColumn.HeaderText = "Celular";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(416, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "Estado Usuario:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.ItemHeight = 16;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstado.Location = new System.Drawing.Point(419, 507);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(144, 24);
            this.comboEstado.TabIndex = 81;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(416, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Apellido Propietario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(393, 576);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 33);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(221, 576);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 33);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(416, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 77;
            this.label9.Text = "Correo Electrónico:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(416, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Teléfono Propietario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.DimGray;
            this.labelName.Location = new System.Drawing.Point(416, 238);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(154, 16);
            this.labelName.TabIndex = 75;
            this.labelName.Text = "Nombre Propietario:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(416, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Cédula Propietario:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.txtLastName.Location = new System.Drawing.Point(419, 330);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(187, 16);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.txtCorreo.Location = new System.Drawing.Point(419, 440);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 16);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.txtTelefono.Location = new System.Drawing.Point(419, 378);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(187, 16);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.txtName.Location = new System.Drawing.Point(419, 266);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 16);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCedula.ForeColor = System.Drawing.Color.White;
            this.txtCedula.Location = new System.Drawing.Point(419, 203);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(187, 16);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // FrmModificarPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarPropietario";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Modificar Propietario";
            this.Load += new System.EventHandler(this.FrmModificarPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPropietario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pROPIETARIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter pROPIETARIOSTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridPropietario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPropietarioDataGridViewTextBoxColumn;
    }
}