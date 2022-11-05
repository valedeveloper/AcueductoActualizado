
namespace AqueaductoApp.CapaVistas
{
    partial class FrmCrudBarrio
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
            System.Windows.Forms.Label id_BarrioLabel;
            System.Windows.Forms.Label nombre_BarrioLabel;
            System.Windows.Forms.Label codigo_PostalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudBarrio));
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.cONSUMOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSUMOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager();
            this.bARRIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();
            this.cONSUMOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bARRIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            id_BarrioLabel = new System.Windows.Forms.Label();
            nombre_BarrioLabel = new System.Windows.Forms.Label();
            codigo_PostalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingNavigator)).BeginInit();
            this.cONSUMOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_BarrioLabel
            // 
            id_BarrioLabel.AutoSize = true;
            id_BarrioLabel.Location = new System.Drawing.Point(530, 191);
            id_BarrioLabel.Name = "id_BarrioLabel";
            id_BarrioLabel.Size = new System.Drawing.Size(49, 13);
            id_BarrioLabel.TabIndex = 1;
            id_BarrioLabel.Text = "Id Barrio:";
            // 
            // nombre_BarrioLabel
            // 
            nombre_BarrioLabel.AutoSize = true;
            nombre_BarrioLabel.Location = new System.Drawing.Point(530, 217);
            nombre_BarrioLabel.Name = "nombre_BarrioLabel";
            nombre_BarrioLabel.Size = new System.Drawing.Size(77, 13);
            nombre_BarrioLabel.TabIndex = 3;
            nombre_BarrioLabel.Text = "Nombre Barrio:";
            // 
            // codigo_PostalLabel
            // 
            codigo_PostalLabel.AutoSize = true;
            codigo_PostalLabel.Location = new System.Drawing.Point(530, 243);
            codigo_PostalLabel.Name = "codigo_PostalLabel";
            codigo_PostalLabel.Size = new System.Drawing.Size(75, 13);
            codigo_PostalLabel.TabIndex = 5;
            codigo_PostalLabel.Text = "Codigo Postal:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BARRIOSTableAdapter = this.bARRIOSTableAdapter;
            this.tableAdapterManager.CONSUMOSTableAdapter = this.cONSUMOSTableAdapter;
            this.tableAdapterManager.ESTRATOSTableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.PREDIOSTableAdapter = null;
            this.tableAdapterManager.PROPIETARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // bARRIOSTableAdapter
            // 
            this.bARRIOSTableAdapter.ClearBeforeFill = true;
            // 
            // cONSUMOSBindingNavigator
            // 
            this.cONSUMOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cONSUMOSBindingNavigator.BindingSource = this.cONSUMOSBindingSource;
            this.cONSUMOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cONSUMOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cONSUMOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.cONSUMOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cONSUMOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cONSUMOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cONSUMOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cONSUMOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cONSUMOSBindingNavigator.Name = "cONSUMOSBindingNavigator";
            this.cONSUMOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cONSUMOSBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cONSUMOSBindingNavigator.TabIndex = 0;
            this.cONSUMOSBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // bARRIOSBindingSource
            // 
            this.bARRIOSBindingSource.DataMember = "BARRIOS";
            this.bARRIOSBindingSource.DataSource = this.dataSet1;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bARRIOSBindingSource, "Id_Barrio", true));
            this.txtId.Location = new System.Drawing.Point(613, 188);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtBarrio
            // 
            this.txtBarrio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bARRIOSBindingSource, "Nombre_Barrio", true));
            this.txtBarrio.Location = new System.Drawing.Point(613, 214);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(100, 20);
            this.txtBarrio.TabIndex = 4;
            // 
            // txtPostal
            // 
            this.txtPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bARRIOSBindingSource, "Codigo_Postal", true));
            this.txtPostal.Location = new System.Drawing.Point(613, 240);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(100, 20);
            this.txtPostal.TabIndex = 6;
            // 
            // FrmCrudBarri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_BarrioLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(nombre_BarrioLabel);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(codigo_PostalLabel);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.cONSUMOSBindingNavigator);
            this.Name = "FrmCrudBarri";
            this.Text = "FrmCrudBarri";
            this.Load += new System.EventHandler(this.FrmCrudBarri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingNavigator)).EndInit();
            this.cONSUMOSBindingNavigator.ResumeLayout(false);
            this.cONSUMOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bARRIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONSUMOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter cONSUMOSTableAdapter;
        private CapaDatos.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cONSUMOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter bARRIOSTableAdapter;
        private System.Windows.Forms.BindingSource bARRIOSBindingSource;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtPostal;
    }
}