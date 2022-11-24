
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudEstrato));
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.eSTRATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTRATOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager();
            this.txtIdEstrato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            numero_EstratoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_EstratoLabel
            // 
            numero_EstratoLabel.AutoSize = true;
            numero_EstratoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            numero_EstratoLabel.ForeColor = System.Drawing.Color.DimGray;
            numero_EstratoLabel.Location = new System.Drawing.Point(421, 190);
            numero_EstratoLabel.Name = "numero_EstratoLabel";
            numero_EstratoLabel.Size = new System.Drawing.Size(127, 16);
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
            this.txtIdEstrato.Location = new System.Drawing.Point(587, 232);
            this.txtIdEstrato.Name = "txtIdEstrato";
            this.txtIdEstrato.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstrato.TabIndex = 2;
            this.txtIdEstrato.Visible = false;
            this.txtIdEstrato.TextChanged += new System.EventHandler(this.txtIdEstrato_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnAgregar.Location = new System.Drawing.Point(234, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 33);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboEstrato
            // 
            this.comboEstrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(227)))));
            this.comboEstrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEstrato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboEstrato.ForeColor = System.Drawing.Color.White;
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboEstrato.Location = new System.Drawing.Point(587, 180);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(100, 24);
            this.comboEstrato.TabIndex = 1;
            this.comboEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstrato_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button2.Location = new System.Drawing.Point(424, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 83);
            this.panel1.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(266, 22);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6);
            this.label3.Size = new System.Drawing.Size(265, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "Agregar Estrato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 113;
            this.pictureBox2.TabStop = false;
            // 
            // FrmCrudEstrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 745);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboEstrato);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdEstrato);
            this.Controls.Add(numero_EstratoLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrudEstrato";
            this.Text = "FrmCrudEstrato";
            this.Load += new System.EventHandler(this.FrmCrudEstrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}