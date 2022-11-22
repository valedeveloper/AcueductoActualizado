using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqueaductoApp.CapaVistas
{
    public partial class FrmCrudEstrato : Form
    {
        public FrmCrudEstrato()
        {
            InitializeComponent();
        }

        private void eSTRATOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eSTRATOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmCrudEstrato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.ESTRATOS' Puede moverla o quitarla según sea necesario.
            this.eSTRATOSTableAdapter.Fill(this.dataSet1.ESTRATOS);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter estratoInsertar = new CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            estratoInsertar.InsertarEstrato(this.comboEstrato.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void txtIdEstrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter estratoInsertar = new CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            int validarEstrato = (int)estratoInsertar.validarEstrato(this.comboEstrato.Text);

            if (this.comboEstrato.Text=="")
            {
                MessageBox.Show("Digite el estrato");
            }
            else
            {
                if(validarEstrato==0)
                {
                    estratoInsertar.InsertarEstrato(this.comboEstrato.Text);
                    MessageBox.Show("Estrato Agregado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.comboEstrato.Text = "";
                    this.eSTRATOSTableAdapter.Fill(this.dataSet1.ESTRATOS);


                }
                else
                {
                    MessageBox.Show("Ya existe el estrato", "Notificaciòn");
                }



       
            }
        }

        private void eSTRATOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.comboEstrato.Text = "";
                //Recarfar Data Grid
                this.eSTRATOSTableAdapter.Fill(this.dataSet1.ESTRATOS);
            }
        }
    }
}
