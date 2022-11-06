
namespace AqueaductoApp.CapaVistas
{
    partial class FrmCrudEstrato
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
            System.Windows.Forms.Label numero_EstratoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.eSTRATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTRATOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager();
            this.txtIdEstrato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.GridEstrato = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            numero_EstratoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstrato)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_EstratoLabel
            // 
            numero_EstratoLabel.AutoSize = true;
            numero_EstratoLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_EstratoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            numero_EstratoLabel.Location = new System.Drawing.Point(99, 334);
            numero_EstratoLabel.Name = "numero_EstratoLabel";
            numero_EstratoLabel.Size = new System.Drawing.Size(153, 18);
            numero_EstratoLabel.TabIndex = 3;
            numero_EstratoLabel.Text = "Numero Estrato:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTRATOSBindingSource
            // 
            this.eSTRATOSBindingSource.DataMember = "ESTRATOS";
            this.eSTRATOSBindingSource.DataSource = this.dataSet1;
            // 
            // eSTRATOSTableAdapter
            // 
            this.eSTRATOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BARRIOSTableAdapter = null;
            this.tableAdapterManager.CONSUMOSTableAdapter = null;
            this.tableAdapterManager.ESTRATOSTableAdapter = this.eSTRATOSTableAdapter;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.PREDIOSTableAdapter = null;
            this.tableAdapterManager.PROPIETARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // txtIdEstrato
            // 
            this.txtIdEstrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTRATOSBindingSource, "Id_Estrato", true));
            this.txtIdEstrato.Location = new System.Drawing.Point(291, 384);
            this.txtIdEstrato.Name = "txtIdEstrato";
            this.txtIdEstrato.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstrato.TabIndex = 2;
            this.txtIdEstrato.Visible = false;
            this.txtIdEstrato.TextChanged += new System.EventHandler(this.txtIdEstrato_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(46)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnAgregar.Location = new System.Drawing.Point(90, 450);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 33);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboEstrato
            // 
            this.comboEstrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.comboEstrato.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstrato.ForeColor = System.Drawing.Color.White;
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboEstrato.Location = new System.Drawing.Point(291, 331);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(158, 26);
            this.comboEstrato.TabIndex = 36;
            // 
            // GridEstrato
            // 
            this.GridEstrato.AllowUserToAddRows = false;
            this.GridEstrato.AllowUserToDeleteRows = false;
            this.GridEstrato.AutoGenerateColumns = false;
            this.GridEstrato.BackgroundColor = System.Drawing.Color.White;
            this.GridEstrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEstrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEstrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEstrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GridEstrato.DataSource = this.eSTRATOSBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEstrato.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridEstrato.Location = new System.Drawing.Point(136, 176);
            this.GridEstrato.Name = "GridEstrato";
            this.GridEstrato.ReadOnly = true;
            this.GridEstrato.Size = new System.Drawing.Size(263, 117);
            this.GridEstrato.TabIndex = 36;
            this.GridEstrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eSTRATOSDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Estrato";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Numero_Estrato";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Estrato";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button2.Location = new System.Drawing.Point(310, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(152, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 88;
            this.label2.Text = "Estratos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 87;
            this.label1.Text = "Agregar y Modificar";
            // 
            // FrmCrudEstrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridEstrato);
            this.Controls.Add(this.comboEstrato);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdEstrato);
            this.Controls.Add(numero_EstratoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrudEstrato";
            this.Text = "FrmCrudEstrato";
            this.Load += new System.EventHandler(this.FrmCrudEstrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eSTRATOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter eSTRATOSTableAdapter;
        private CapaDatos.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtIdEstrato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox comboEstrato;
        private System.Windows.Forms.DataGridView GridEstrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}