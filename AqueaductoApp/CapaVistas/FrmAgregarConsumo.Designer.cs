
namespace AqueaductoApp.CapaVistas
{
    partial class FrmAgregarConsumo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelIdCatratral = new System.Windows.Forms.Label();
            this.labelFechaConsumo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.GridPredio = new System.Windows.Forms.DataGridView();
            this.idPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCatastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaPropietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPredioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREDIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.pREDIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            this.labelConsumo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdCatratral
            // 
            this.labelIdCatratral.AutoSize = true;
            this.labelIdCatratral.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelIdCatratral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.labelIdCatratral.Location = new System.Drawing.Point(90, 204);
            this.labelIdCatratral.Name = "labelIdCatratral";
            this.labelIdCatratral.Size = new System.Drawing.Size(159, 16);
            this.labelIdCatratral.TabIndex = 0;
            this.labelIdCatratral.Text = "Número de Catastro:";
            // 
            // labelFechaConsumo
            // 
            this.labelFechaConsumo.AutoSize = true;
            this.labelFechaConsumo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelFechaConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.labelFechaConsumo.Location = new System.Drawing.Point(127, 407);
            this.labelFechaConsumo.Name = "labelFechaConsumo";
            this.labelFechaConsumo.Size = new System.Drawing.Size(157, 16);
            this.labelFechaConsumo.TabIndex = 1;
            this.labelFechaConsumo.Text = "Consumo en Metros:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(305, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 26;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(46)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(89, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 33);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtConsumo
            // 
            this.txtConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtConsumo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtConsumo.ForeColor = System.Drawing.Color.White;
            this.txtConsumo.Location = new System.Drawing.Point(300, 404);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(128, 23);
            this.txtConsumo.TabIndex = 23;
            this.txtConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumo_KeyPress);
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtCatastro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCatastro.ForeColor = System.Drawing.Color.White;
            this.txtCatastro.Location = new System.Drawing.Point(266, 199);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.ReadOnly = true;
            this.txtCatastro.Size = new System.Drawing.Size(104, 23);
            this.txtCatastro.TabIndex = 27;
            this.txtCatastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatastro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(400, 199);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 27);
            this.btnBuscar.TabIndex = 61;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(127, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Fecha del  Consumo:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.labelFecha.Location = new System.Drawing.Point(302, 454);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 16);
            this.labelFecha.TabIndex = 73;
            this.labelFecha.Visible = false;
            // 
            // GridPredio
            // 
            this.GridPredio.AllowUserToAddRows = false;
            this.GridPredio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridPredio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPredio.AutoGenerateColumns = false;
            this.GridPredio.BackgroundColor = System.Drawing.Color.White;
            this.GridPredio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPredio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPredio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridPredio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
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
            this.estadoPredioDataGridViewTextBoxColumn});
            this.GridPredio.DataSource = this.pREDIOSBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPredio.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridPredio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridPredio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridPredio.Location = new System.Drawing.Point(130, 251);
            this.GridPredio.Name = "GridPredio";
            this.GridPredio.ReadOnly = true;
            this.GridPredio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPredio.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridPredio.RowHeadersVisible = false;
            this.GridPredio.RowHeadersWidth = 42;
            this.GridPredio.RowTemplate.Height = 25;
            this.GridPredio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridPredio.Size = new System.Drawing.Size(297, 120);
            this.GridPredio.TabIndex = 74;
            this.GridPredio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPropietario_CellContentClick);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.numeroCatastroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.numeroCatastroDataGridViewTextBoxColumn.HeaderText = "Número Catastro";
            this.numeroCatastroDataGridViewTextBoxColumn.Name = "numeroCatastroDataGridViewTextBoxColumn";
            this.numeroCatastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaPropietarioDataGridViewTextBoxColumn
            // 
            this.cedulaPropietarioDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Propietario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.cedulaPropietarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cedulaPropietarioDataGridViewTextBoxColumn.HeaderText = "Cédula Propietario";
            this.cedulaPropietarioDataGridViewTextBoxColumn.Name = "cedulaPropietarioDataGridViewTextBoxColumn";
            this.cedulaPropietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoPredioDataGridViewTextBoxColumn
            // 
            this.estadoPredioDataGridViewTextBoxColumn.DataPropertyName = "Estado_Predio";
            this.estadoPredioDataGridViewTextBoxColumn.HeaderText = "Estado_Predio";
            this.estadoPredioDataGridViewTextBoxColumn.Name = "estadoPredioDataGridViewTextBoxColumn";
            this.estadoPredioDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoPredioDataGridViewTextBoxColumn.Visible = false;
            // 
            // pREDIOSBindingSource
            // 
            this.pREDIOSBindingSource.DataMember = "PREDIOS";
            this.pREDIOSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pREDIOSTableAdapter
            // 
            this.pREDIOSTableAdapter.ClearBeforeFill = true;
            // 
            // labelConsumo
            // 
            this.labelConsumo.AutoSize = true;
            this.labelConsumo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.labelConsumo.Location = new System.Drawing.Point(84, 110);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(252, 29);
            this.labelConsumo.TabIndex = 21;
            this.labelConsumo.Text = "Agregar Consumo";
            // 
            // FrmAgregarConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 647);
            this.Controls.Add(this.GridPredio);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.labelConsumo);
            this.Controls.Add(this.labelFechaConsumo);
            this.Controls.Add(this.labelIdCatratral);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarConsumo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "AgregarLectura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAgregarLectura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdCatratral;
        private System.Windows.Forms.Label labelFechaConsumo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCatastro;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DataGridView GridPredio;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pREDIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter pREDIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCatastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaPropietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estratoPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrioPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPredioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelConsumo;
    }
}