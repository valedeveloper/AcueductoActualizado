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
    public partial class FrmCrudBarrio : Form
    {
        public FrmCrudBarrio()
        {
            InitializeComponent();
        }

        private void cONSUMOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONSUMOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmCrudBarri_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.BARRIOS' Puede moverla o quitarla según sea necesario.
            this.bARRIOSTableAdapter.Fill(this.dataSet1.BARRIOS);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.CONSUMOS' Puede moverla o quitarla según sea necesario.
            this.cONSUMOSTableAdapter.Fill(this.dataSet1.CONSUMOS);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter barrioInsertar = new CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();
            barrioInsertar.InsertarBarrio(this.txtBarrio.Text, this.txtPostal.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter barrioModificar = new CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();
            barrioModificar.ModificarBarrio(this.txtBarrio.Text,this.txtPostal.Text,int.Parse(this.txtId.Text));
        }
    }
}
