﻿
namespace AqueaductoApp.CapaVistas
{
    partial class FrmModificarConsumo
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
            this.labelConsumo = new System.Windows.Forms.Label();
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.labelFechaConsumo = new System.Windows.Forms.Label();
            this.labelIdCatratral = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridConsumo = new System.Windows.Forms.DataGridView();
            this.idConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCatastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesConsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrosCubicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.cONSUMOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button2.Location = new System.Drawing.Point(297, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 35;
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
            this.btnModificar.Location = new System.Drawing.Point(124, 519);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 33);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // labelConsumo
            // 
            this.labelConsumo.AutoSize = true;
            this.labelConsumo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.labelConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.labelConsumo.Location = new System.Drawing.Point(84, 105);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(267, 29);
            this.labelConsumo.TabIndex = 30;
            this.labelConsumo.Text = "Modificar Consumo";
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtCatastro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCatastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.txtCatastro.Location = new System.Drawing.Point(266, 199);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.ReadOnly = true;
            this.txtCatastro.Size = new System.Drawing.Size(104, 23);
            this.txtCatastro.TabIndex = 39;
            this.txtCatastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatastro_KeyPress);
            // 
            // txtConsumo
            // 
            this.txtConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.txtConsumo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.txtConsumo.Location = new System.Drawing.Point(277, 400);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(175, 23);
            this.txtConsumo.TabIndex = 38;
            this.txtConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumo_KeyPress);
            // 
            // labelFechaConsumo
            // 
            this.labelFechaConsumo.Location = new System.Drawing.Point(0, 0);
            this.labelFechaConsumo.Name = "labelFechaConsumo";
            this.labelFechaConsumo.Size = new System.Drawing.Size(100, 23);
            this.labelFechaConsumo.TabIndex = 69;
            // 
            // labelIdCatratral
            // 
            this.labelIdCatratral.AutoSize = true;
            this.labelIdCatratral.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelIdCatratral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.labelIdCatratral.Location = new System.Drawing.Point(90, 204);
            this.labelIdCatratral.Name = "labelIdCatratral";
            this.labelIdCatratral.Size = new System.Drawing.Size(159, 16);
            this.labelIdCatratral.TabIndex = 36;
            this.labelIdCatratral.Text = "Número de Catastro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(97, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Fecha del Consumo:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.labelFecha.Location = new System.Drawing.Point(272, 454);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 16);
            this.labelFecha.TabIndex = 66;
            this.labelFecha.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(97, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Consumo en Metros:";
            // 
            // GridConsumo
            // 
            this.GridConsumo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridConsumo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridConsumo.AutoGenerateColumns = false;
            this.GridConsumo.BackgroundColor = System.Drawing.Color.White;
            this.GridConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridConsumo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridConsumo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GridConsumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridConsumo.ColumnHeadersHeight = 20;
            this.GridConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridConsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsumoDataGridViewTextBoxColumn,
            this.numeroCatastroDataGridViewTextBoxColumn,
            this.fechaConsumoDataGridViewTextBoxColumn,
            this.mesConsumoDataGridViewTextBoxColumn,
            this.metrosCubicosDataGridViewTextBoxColumn});
            this.GridConsumo.DataSource = this.cONSUMOSBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridConsumo.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridConsumo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridConsumo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.GridConsumo.Location = new System.Drawing.Point(82, 248);
            this.GridConsumo.Name = "GridConsumo";
            this.GridConsumo.ReadOnly = true;
            this.GridConsumo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridConsumo.RowHeadersVisible = false;
            this.GridConsumo.RowHeadersWidth = 42;
            this.GridConsumo.RowTemplate.Height = 25;
            this.GridConsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridConsumo.Size = new System.Drawing.Size(383, 121);
            this.GridConsumo.TabIndex = 86;
            this.GridConsumo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsumo_CellContentClick);
            // 
            // idConsumoDataGridViewTextBoxColumn
            // 
            this.idConsumoDataGridViewTextBoxColumn.DataPropertyName = "Id_Consumo";
            this.idConsumoDataGridViewTextBoxColumn.HeaderText = "Id_Consumo";
            this.idConsumoDataGridViewTextBoxColumn.Name = "idConsumoDataGridViewTextBoxColumn";
            this.idConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idConsumoDataGridViewTextBoxColumn.Visible = false;
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
            // fechaConsumoDataGridViewTextBoxColumn
            // 
            this.fechaConsumoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Consumo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.fechaConsumoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaConsumoDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaConsumoDataGridViewTextBoxColumn.Name = "fechaConsumoDataGridViewTextBoxColumn";
            this.fechaConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaConsumoDataGridViewTextBoxColumn.Width = 150;
            // 
            // mesConsumoDataGridViewTextBoxColumn
            // 
            this.mesConsumoDataGridViewTextBoxColumn.DataPropertyName = "Mes_Consumo";
            this.mesConsumoDataGridViewTextBoxColumn.HeaderText = "Mes_Consumo";
            this.mesConsumoDataGridViewTextBoxColumn.Name = "mesConsumoDataGridViewTextBoxColumn";
            this.mesConsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesConsumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // metrosCubicosDataGridViewTextBoxColumn
            // 
            this.metrosCubicosDataGridViewTextBoxColumn.DataPropertyName = "Metros_Cubicos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(58)))), ((int)(((byte)(164)))));
            this.metrosCubicosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.metrosCubicosDataGridViewTextBoxColumn.HeaderText = "Lectura ";
            this.metrosCubicosDataGridViewTextBoxColumn.Name = "metrosCubicosDataGridViewTextBoxColumn";
            this.metrosCubicosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONSUMOSBindingSource
            // 
            this.cONSUMOSBindingSource.DataMember = "CONSUMOS";
            this.cONSUMOSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONSUMOSTableAdapter
            // 
            this.cONSUMOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModificarConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 647);
            this.Controls.Add(this.GridConsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.labelFechaConsumo);
            this.Controls.Add(this.labelIdCatratral);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.labelConsumo);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarConsumo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Modificar Lectura";
            this.Load += new System.EventHandler(this.FrmModificarConsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label labelConsumo;
        private System.Windows.Forms.TextBox txtCatastro;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label labelFechaConsumo;
        private System.Windows.Forms.Label labelIdCatratral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridConsumo;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONSUMOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter cONSUMOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCatastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrosCubicosDataGridViewTextBoxColumn;
    }
}