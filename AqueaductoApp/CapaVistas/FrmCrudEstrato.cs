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
            estratoInsertar.InsertarEstrato(this.txtNumeroEstrato.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter estratoModificar = new CapaDatos.DataSet1TableAdapters.ESTRATOSTableAdapter();
            estratoModificar.ModificarEstrato(this.txtNumeroEstrato.Text,int.Parse(this.txtIdEstrato.Text));
        }
    }
}
