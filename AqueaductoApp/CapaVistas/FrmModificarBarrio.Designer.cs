
namespace AqueaductoApp.CapaVistas
{
    partial class FrmModificarBarrio
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarBarrio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.GridBarrio = new System.Windows.Forms.DataGridView();
            this.idBarrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBarrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARRIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.bARRIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.DimGray;
            label4.Location = new System.Drawing.Point(475, 333);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 16);
            label4.TabIndex = 81;
            label4.Text = "Nombre Barrio:";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.DimGray;
            label3.Location = new System.Drawing.Point(475, 402);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 16);
            label3.TabIndex = 83;
            label3.Text = "Codigo Postal:";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 50);
            this.panel1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(263, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(269, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Barrio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.txtBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarrio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.ForeColor = System.Drawing.Color.White;
            this.txtBarrio.Location = new System.Drawing.Point(478, 363);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(155, 20);
            this.txtBarrio.TabIndex = 82;
            this.txtBarrio.TextChanged += new System.EventHandler(this.txtBarrio_TextChanged);
            this.txtBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarrio_KeyPress);
            // 
            // txtPostal
            // 
            this.txtPostal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.txtPostal.Location = new System.Drawing.Point(478, 433);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(155, 20);
            this.txtPostal.TabIndex = 84;
            this.txtPostal.TextChanged += new System.EventHandler(this.txtPostal_TextChanged);
            this.txtPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostal_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button2.Location = new System.Drawing.Point(424, 591);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 86;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnAgregar.Location = new System.Drawing.Point(249, 591);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 33);
            this.btnAgregar.TabIndex = 87;
            this.btnAgregar.Text = "Modificar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // GridBarrio
            // 
            this.GridBarrio.AllowUserToAddRows = false;
            this.GridBarrio.AllowUserToDeleteRows = false;
            this.GridBarrio.AutoGenerateColumns = false;
            this.GridBarrio.BackgroundColor = System.Drawing.Color.White;
            this.GridBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridBarrio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBarrio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarrioDataGridViewTextBoxColumn,
            this.nombreBarrioDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn});
            this.GridBarrio.DataSource = this.bARRIOSBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridBarrio.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridBarrio.GridColor = System.Drawing.Color.White;
            this.GridBarrio.Location = new System.Drawing.Point(171, 136);
            this.GridBarrio.Name = "GridBarrio";
            this.GridBarrio.ReadOnly = true;
            this.GridBarrio.Size = new System.Drawing.Size(449, 98);
            this.GridBarrio.TabIndex = 88;
            this.GridBarrio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBarrio_CellContentClick);
            // 
            // idBarrioDataGridViewTextBoxColumn
            // 
            this.idBarrioDataGridViewTextBoxColumn.DataPropertyName = "Id_Barrio";
            this.idBarrioDataGridViewTextBoxColumn.HeaderText = "Id_Barrio";
            this.idBarrioDataGridViewTextBoxColumn.Name = "idBarrioDataGridViewTextBoxColumn";
            this.idBarrioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBarrioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreBarrioDataGridViewTextBoxColumn
            // 
            this.nombreBarrioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Barrio";
            this.nombreBarrioDataGridViewTextBoxColumn.HeaderText = "Nombre Barrio";
            this.nombreBarrioDataGridViewTextBoxColumn.Name = "nombreBarrioDataGridViewTextBoxColumn";
            this.nombreBarrioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreBarrioDataGridViewTextBoxColumn.Width = 200;
            // 
            // codigoPostalDataGridViewTextBoxColumn
            // 
            this.codigoPostalDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Postal";
            this.codigoPostalDataGridViewTextBoxColumn.HeaderText = "Codigo Postal";
            this.codigoPostalDataGridViewTextBoxColumn.Name = "codigoPostalDataGridViewTextBoxColumn";
            this.codigoPostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoPostalDataGridViewTextBoxColumn.Width = 200;
            // 
            // bARRIOSBindingSource
            // 
            this.bARRIOSBindingSource.DataMember = "BARRIOS";
            this.bARRIOSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bARRIOSTableAdapter
            // 
            this.bARRIOSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // FrmModificarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 745);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GridBarrio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarBarrio";
            this.Text = "FrmModificarBarrio";
            this.Load += new System.EventHandler(this.FrmModificarBarrio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView GridBarrio;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bARRIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter bARRIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBarrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}