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
    public partial class FrmImprimirFactura : Form
    {
        public FrmImprimirFactura()
        {
            InitializeComponent();
        }

        string factEstado;
        string consecutivo;



        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            if(this.txtConsecutivo.Text=="")
            {
                MessageBox.Show("Ingrese el consecutivo de la Factura");
            }
            else
            {
                //Modifica el estado de la Factura de Pendiente a Generada
                CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter facturas = new CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
                facturas.modificarEstadofact(consecutivo);
                ////////////////////////////////////////
                ///



                //Generar Factura////
                //Traigo el reporte
                Cursor.Current = Cursors.WaitCursor;//Aparece Icono de esperar
                Reportes.CrystalReportFactura reporteFactura = new Reportes.CrystalReportFactura();

                //Lleno el reporte
                this.fACTURASTableAdapter.crearFactura(this.dataSet1.FACTURAS, consecutivo); //Traigo el procedimiento almenacedo, entra por parámetro el dataset y el consecutivo
                reporteFactura.SetDataSource(this.dataSet1); 
                Cursor.Current = Cursors.Default;

                //Muestro Reportes
                Reportes.FrmFactura frmFactura = new Reportes.FrmFactura();
                frmFactura.crystalReportViewer1.ReportSource = reporteFactura;
                frmFactura.ShowDialog();
                frmFactura.Close();

                this.txtConsecutivo.Text = "";

                //Actualizo el datagrid

                CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter facturasImprimir = new CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
                CapaDatos.DataSet1.FACTURASDataTable facturasDatos = new CapaDatos.DataSet1.FACTURASDataTable();
                facturasDatos = facturasImprimir.VerFacturasImprimirTable(factEstado);
                GridImprimir.DataSource = facturasDatos;

            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void fACTURASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fACTURASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmImprimirFactura_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dataSet1.FACTURAS' Puede moverla o quitarla según sea necesario.
            //this.fACTURASTableAdapter.Fill(this.dataSet1.FACTURAS);

            factEstado = "Pendiente";
            CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter facturasImprimir = new CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
            CapaDatos.DataSet1.FACTURASDataTable facturasDatos = new CapaDatos.DataSet1.FACTURASDataTable();

            facturasDatos = facturasImprimir.VerFacturasImprimirTable(factEstado);
            GridImprimir.DataSource = facturasDatos;



        }

        private void GridImprimir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = GridImprimir.CurrentRow.Index;
            consecutivo = GridImprimir.CurrentRow.Cells[0].Value.ToString();
            this.labelConsecutivo.Text = consecutivo;
            this.labelConsecutivo.Visible = true;
        }

        private void GridConsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = GridImprimir.CurrentRow.Index;
            consecutivo = GridImprimir.CurrentRow.Cells[0].Value.ToString();
            this.txtConsecutivo.Text = consecutivo;
        }

        private void labelConsecutivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {
            if(this.txtConsecutivo.Text=="")
            {
                MessageBox.Show("Escoja de la tabla el consecutivo para crear la Factura","Notificaciòn");
            }
        }
    }
}
