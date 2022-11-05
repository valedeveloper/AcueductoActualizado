
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
            System.Windows.Forms.Label id_EstratoLabel;
            System.Windows.Forms.Label numero_EstratoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudEstrato));
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.eSTRATOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTRATOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager();
            this.eSTRATOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtIdEstrato = new System.Windows.Forms.TextBox();
            this.txtNumeroEstrato = new System.Windows.Forms.TextBox();
            id_EstratoLabel = new System.Windows.Forms.Label();
            numero_EstratoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingNavigator)).BeginInit();
            this.eSTRATOSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_EstratoLabel
            // 
            id_EstratoLabel.AutoSize = true;
            id_EstratoLabel.Location = new System.Drawing.Point(34, 196);
            id_EstratoLabel.Name = "id_EstratoLabel";
            id_EstratoLabel.Size = new System.Drawing.Size(55, 13);
            id_EstratoLabel.TabIndex = 1;
            id_EstratoLabel.Text = "Id Estrato:";
            // 
            // numero_EstratoLabel
            // 
            numero_EstratoLabel.AutoSize = true;
            numero_EstratoLabel.Location = new System.Drawing.Point(34, 222);
            numero_EstratoLabel.Name = "numero_EstratoLabel";
            numero_EstratoLabel.Size = new System.Drawing.Size(83, 13);
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
            // eSTRATOSBindingNavigator
            // 
            this.eSTRATOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eSTRATOSBindingNavigator.BindingSource = this.eSTRATOSBindingSource;
            this.eSTRATOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eSTRATOSBindingNavigator.DeleteItem = null;
            this.eSTRATOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripButton1});
            this.eSTRATOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eSTRATOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eSTRATOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eSTRATOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eSTRATOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eSTRATOSBindingNavigator.Name = "eSTRATOSBindingNavigator";
            this.eSTRATOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eSTRATOSBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.eSTRATOSBindingNavigator.TabIndex = 0;
            this.eSTRATOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtIdEstrato
            // 
            this.txtIdEstrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTRATOSBindingSource, "Id_Estrato", true));
            this.txtIdEstrato.Location = new System.Drawing.Point(123, 193);
            this.txtIdEstrato.Name = "txtIdEstrato";
            this.txtIdEstrato.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstrato.TabIndex = 2;
            // 
            // txtNumeroEstrato
            // 
            this.txtNumeroEstrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTRATOSBindingSource, "Numero_Estrato", true));
            this.txtNumeroEstrato.Location = new System.Drawing.Point(123, 219);
            this.txtNumeroEstrato.Name = "txtNumeroEstrato";
            this.txtNumeroEstrato.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEstrato.TabIndex = 4;
            // 
            // FrmCrudEstrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_EstratoLabel);
            this.Controls.Add(this.txtIdEstrato);
            this.Controls.Add(numero_EstratoLabel);
            this.Controls.Add(this.txtNumeroEstrato);
            this.Controls.Add(this.eSTRATOSBindingNavigator);
            this.Name = "FrmCrudEstrato";
            this.Text = "FrmCrudEstrato";
            this.Load += new System.EventHandler(this.FrmCrudEstrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTRATOSBindingNavigator)).EndInit();
            this.eSTRATOSBindingNavigator.ResumeLayout(false);
            this.eSTRATOSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eSTRATOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter eSTRATOSTableAdapter;
        private CapaDatos.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eSTRATOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtIdEstrato;
        private System.Windows.Forms.TextBox txtNumeroEstrato;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}