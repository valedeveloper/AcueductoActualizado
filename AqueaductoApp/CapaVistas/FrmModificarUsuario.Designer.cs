
namespace AqueaductoApp.CapaVistas
{
    partial class FrmModificarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoUsuarioDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónImagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.uSUARIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
            this.pictureUser = new AqueaductoApp.CapaModelos.PictureRound();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCancelar.Location = new System.Drawing.Point(302, 563);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 33);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(46)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnModificar.Location = new System.Drawing.Point(103, 563);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 33);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Modificar Usuario";
            // 
            // GridUser
            // 
            this.GridUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.GridUser.AutoGenerateColumns = false;
            this.GridUser.BackgroundColor = System.Drawing.Color.White;
            this.GridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridUser.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.GridUser.ColumnHeadersHeight = 20;
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Usuario,
            this.cedulaUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.apellidoUsuarioDataGridViewTextBoxColumn,
            this.correoUsuarioDataGridViewTextBoxColumn,
            this.celularUsuarioDataGridViewTextBoxColumn,
            this.passwordUsuarioDataGridViewTextBoxColumn,
            this.photoUsuarioDataGridViewImageColumn,
            this.idRolDataGridViewTextBoxColumn,
            this.estadoUsuarioDataGridViewTextBoxColumn,
            this.direcciónImagenDataGridViewTextBoxColumn});
            this.GridUser.DataSource = this.uSUARIOSBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUser.DefaultCellStyle = dataGridViewCellStyle27;
            this.GridUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridUser.Location = new System.Drawing.Point(40, 166);
            this.GridUser.Name = "GridUser";
            this.GridUser.ReadOnly = true;
            this.GridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridUser.RowHeadersVisible = false;
            this.GridUser.RowHeadersWidth = 42;
            this.GridUser.RowTemplate.Height = 25;
            this.GridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridUser.Size = new System.Drawing.Size(437, 116);
            this.GridUser.TabIndex = 42;
            this.GridUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_CellContentClick);
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.DataPropertyName = "Id_Usuario";
            this.Id_Usuario.DividerWidth = 50;
            this.Id_Usuario.HeaderText = "Id_Usuario";
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            this.Id_Usuario.Visible = false;
            // 
            // cedulaUsuarioDataGridViewTextBoxColumn
            // 
            this.cedulaUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Usuario";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.cedulaUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.cedulaUsuarioDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaUsuarioDataGridViewTextBoxColumn.Name = "cedulaUsuarioDataGridViewTextBoxColumn";
            this.cedulaUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaUsuarioDataGridViewTextBoxColumn.Width = 105;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Usuario";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.nombreUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 105;
            // 
            // apellidoUsuarioDataGridViewTextBoxColumn
            // 
            this.apellidoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Usuario";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            this.apellidoUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.apellidoUsuarioDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoUsuarioDataGridViewTextBoxColumn.Name = "apellidoUsuarioDataGridViewTextBoxColumn";
            this.apellidoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoUsuarioDataGridViewTextBoxColumn.Width = 105;
            // 
            // correoUsuarioDataGridViewTextBoxColumn
            // 
            this.correoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Correo_Usuario";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.correoUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.correoUsuarioDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoUsuarioDataGridViewTextBoxColumn.Name = "correoUsuarioDataGridViewTextBoxColumn";
            this.correoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // celularUsuarioDataGridViewTextBoxColumn
            // 
            this.celularUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Celular_Usuario";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            this.celularUsuarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.celularUsuarioDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularUsuarioDataGridViewTextBoxColumn.Name = "celularUsuarioDataGridViewTextBoxColumn";
            this.celularUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularUsuarioDataGridViewTextBoxColumn.Width = 105;
            // 
            // passwordUsuarioDataGridViewTextBoxColumn
            // 
            this.passwordUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Password_Usuario";
            this.passwordUsuarioDataGridViewTextBoxColumn.HeaderText = "Password_Usuario";
            this.passwordUsuarioDataGridViewTextBoxColumn.Name = "passwordUsuarioDataGridViewTextBoxColumn";
            this.passwordUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // photoUsuarioDataGridViewImageColumn
            // 
            this.photoUsuarioDataGridViewImageColumn.DataPropertyName = "Photo_Usuario";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.NullValue = null;
            this.photoUsuarioDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.photoUsuarioDataGridViewImageColumn.FillWeight = 50F;
            this.photoUsuarioDataGridViewImageColumn.HeaderText = "Foto";
            this.photoUsuarioDataGridViewImageColumn.Name = "photoUsuarioDataGridViewImageColumn";
            this.photoUsuarioDataGridViewImageColumn.ReadOnly = true;
            this.photoUsuarioDataGridViewImageColumn.Visible = false;
            this.photoUsuarioDataGridViewImageColumn.Width = 105;
            // 
            // idRolDataGridViewTextBoxColumn
            // 
            this.idRolDataGridViewTextBoxColumn.DataPropertyName = "Id_Rol";
            this.idRolDataGridViewTextBoxColumn.HeaderText = "Id_Rol";
            this.idRolDataGridViewTextBoxColumn.Name = "idRolDataGridViewTextBoxColumn";
            this.idRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRolDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoUsuarioDataGridViewTextBoxColumn
            // 
            this.estadoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Estado_Usuario";
            this.estadoUsuarioDataGridViewTextBoxColumn.HeaderText = "Estado_Usuario";
            this.estadoUsuarioDataGridViewTextBoxColumn.Name = "estadoUsuarioDataGridViewTextBoxColumn";
            this.estadoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // direcciónImagenDataGridViewTextBoxColumn
            // 
            this.direcciónImagenDataGridViewTextBoxColumn.DataPropertyName = "Dirección_Imagen";
            this.direcciónImagenDataGridViewTextBoxColumn.HeaderText = "Dirección_Imagen";
            this.direcciónImagenDataGridViewTextBoxColumn.Name = "direcciónImagenDataGridViewTextBoxColumn";
            this.direcciónImagenDataGridViewTextBoxColumn.ReadOnly = true;
            this.direcciónImagenDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(49, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cedula Usuario:";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtCedula.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCedula.ForeColor = System.Drawing.Color.White;
            this.txtCedula.Location = new System.Drawing.Point(193, 124);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(133, 23);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCedula_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label9.Location = new System.Drawing.Point(40, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Correo Electrónico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label8.Location = new System.Drawing.Point(276, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(276, 377);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label7.Location = new System.Drawing.Point(36, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Agregue una Foto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label6.Location = new System.Drawing.Point(342, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label5.Location = new System.Drawing.Point(187, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(40, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(407, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFile
            // 
            this.txtFile.AllowDrop = true;
            this.txtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFile.ForeColor = System.Drawing.Color.White;
            this.txtFile.Location = new System.Drawing.Point(36, 504);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(357, 20);
            this.txtFile.TabIndex = 53;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtCorreo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(40, 377);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(193, 23);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label10.Location = new System.Drawing.Point(37, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "Rol ";
            // 
            // comboRol
            // 
            this.comboRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.comboRol.DisplayMember = "dDD";
            this.comboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRol.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboRol.ForeColor = System.Drawing.Color.White;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "Administrador",
            "Digitador",
            "Facturador"});
            this.comboRol.Location = new System.Drawing.Point(74, 423);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(126, 24);
            this.comboRol.TabIndex = 5;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.combotxtRol_SelectedIndexChanged);
            this.comboRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combotxtRol_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(344, 319);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 23);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtLastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(187, 319);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 23);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(40, 319);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 23);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.comboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboEstado.ForeColor = System.Drawing.Color.White;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo\t\t"});
            this.comboEstado.Location = new System.Drawing.Point(348, 428);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(123, 24);
            this.comboEstado.TabIndex = 10;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label12.Location = new System.Drawing.Point(228, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Estado Usuario";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(37, 101);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 67;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureUser
            // 
            this.pictureUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.pictureUser.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pictureUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureUser.BorderSize = 2;
            this.pictureUser.GradientAngle = 50F;
            this.pictureUser.Location = new System.Drawing.Point(399, 16);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(132, 132);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 43;
            this.pictureUser.TabStop = false;
            this.pictureUser.Click += new System.EventHandler(this.pictureUser_Click);
            // 
            // FrmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 647);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.GridUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarUsuario";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.FrmModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridUser;
        private CapaModelos.PictureRound pictureUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelID;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoUsuarioDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciónImagenDataGridViewTextBoxColumn;
    }
}