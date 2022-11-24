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
    public partial class FrmModificarBarrio : Form
    {
        public FrmModificarBarrio()
        {
            InitializeComponent();
        }
        string barrio;
        int id;
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtBarrio.Text == "")
            {
                MessageBox.Show("Digite el nombre del Barrio");
            }
            else
            {
                if (this.txtPostal.Text == "")
                {
                    MessageBox.Show("Digite el Código Postal");
                }
                else
                {
                    CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter barrioModificar = new CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();


                    int validarBarrio = (int)barrioModificar.validarBarrio(this.txtBarrio.Text);

                    if (validarBarrio == 0 || this.txtBarrio.Text == barrio)
                    {
                        barrioModificar.ModificarBarrio(this.txtBarrio.Text, this.txtPostal.Text, id);


                        this.bARRIOSTableAdapter.Fill(this.dataSet1.BARRIOS);
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

        private void FrmModificarBarrio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.BARRIOS' Puede moverla o quitarla según sea necesario.
            this.bARRIOSTableAdapter.Fill(this.dataSet1.BARRIOS);

        }

        private void GridBarrio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = GridBarrio.CurrentRow.Index;
             id = int.Parse(GridBarrio.CurrentRow.Cells[0].Value.ToString());
            barrio = GridBarrio.CurrentRow.Cells[1].Value.ToString();
            this.txtBarrio.Text = barrio;
            this.txtPostal.Text = GridBarrio.CurrentRow.Cells[2].Value.ToString();
           


        }

        private void txtBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txtPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }


            }
        }
    }
}
