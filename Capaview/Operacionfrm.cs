using BtnPrinterExcel.Capacontroller;
using BtnPrinterExcel.Capamodelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtnPrinterExcel.Capaview
{
    public partial class Operacionfrm : Form
    {

        OperacionController opercontrol = new OperacionController();
        OperacionModel opemodel = new OperacionModel();

        ExportarExcel Excel = new ExportarExcel();
       
        Imprimir impre = new Imprimir();
        Exportpdf impdf = new Exportpdf();
        string id;


        public Operacionfrm()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dgvroles.DataSource = opercontrol.getOperacion();

        }
        private void Operacionfrm_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {

            Excel.ExportarDataGridViewExcel(dgvroles);
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            impdf.expopdf(dgvroles, 1, 1);
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            impre.imprimir(dgvroles, 1, 2);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            opemodel.nombre = txtdescripcion.Text;
            opemodel.indicador = cmbindicador.Text;

            opercontrol.Crear(opemodel);
            this.refrescar();
            txtfilnombre.Text = "";

        }

        private void dgvroles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dgvroles.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            opemodel.id = this.id;
            opercontrol.delOperacion(opemodel);
            this.refrescar();
        }
    }
}
