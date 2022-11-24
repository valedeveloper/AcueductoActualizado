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
    public partial class FrmAgregarBarrio : Form
    {
        public FrmAgregarBarrio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {



            if (this.txtBarrio.Text == "")
            {
                MessageBox.Show("Digite el barrio");

            }
            else
            {
                CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter barrioInsertar = new CapaDatos.DataSet1TableAdapters.BARRIOSTableAdapter();
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
                  MessageBox.Show("El Barrio ya existe, coloque otro barrio", "Notificación");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtBarrio.Text = "";
                this.txtPostal.Text = "";
            }
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
