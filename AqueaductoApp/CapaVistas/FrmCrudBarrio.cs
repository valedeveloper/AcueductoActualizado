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
        string barrio;
        private void cONSUMOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONSUMOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmCrudBarri_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dataSet1.BARRIOS' Puede moverla o quitarla según sea necesario.
            //this.bARRIOSTableAdapter.Fill(this.dataSet1.BARRIOS);
            //// TODO: esta línea de código carga datos en la tabla 'dataSet1.CONSUMOS' Puede moverla o quitarla según sea necesario.
            //this.cONSUMOSTableAdapter.Fill(this.dataSet1.CONSUMOS);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
          
        }

        private void bARRIOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = GridBarrio.CurrentRow.Index;
             barrio = GridBarrio.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter barrioInsertar = new CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();

          

            if (this.txtBarrio.Text == "")
            {
                MessageBox.Show("Digite el barrio");

            }
            else
            {
                int validarBarrio = (int)barrioInsertar.validarBarrio(this.txtBarrio.Text);

                if (validarBarrio == 0)
                {
                    if (this.txtPostal.Text == "")
                    {
                        MessageBox.Show("Digite el código postal");
                    }
                    else
                    {
                        barrioInsertar.InsertarBarrio(this.txtBarrio.Text, this.txtPostal.Text);


                        //Mensaje despuès de agregado
                        MessageBox.Show("Predio Agregado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtBarrio.Text = "";
                        this.txtPostal.Text = "";


                    }
                }
            
                    else
                {
                    MessageBox.Show("El Barrio ya existe");
                }
           }
                    



     }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtBarrio.Text = "";
                this.txtPostal.Text = "";

                //Recarfar Data Grid
                this.bARRIOSTableAdapter.Fill(this.dataSet1.BARRIOS);
            }

        }

        private void btnCalcularFac_Click(object sender, EventArgs e)
        {
            if(this.txtBarrio.Text=="")
            {
                MessageBox.Show("Digite el nombre del Barrio");
            }
            else
            {
                if(this.txtPostal.Text=="")
                {
                    MessageBox.Show("Digite el Código Postal");
                }
                else
                {
                    CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter barrioModificar = new CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();


                    int validarBarrio = (int)barrioModificar.validarBarrio(this.txtBarrio.Text);

                    if(validarBarrio==0 || this.txtBarrio.Text == barrio)
                    {
                        barrioModificar.ModificarBarrio(this.txtBarrio.Text, this.txtPostal.Text, int.Parse(this.txtId.Text));



                        MessageBox.Show("Predio modificado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtPostal.Text = "";
                        this.txtBarrio.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el barrio");
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
