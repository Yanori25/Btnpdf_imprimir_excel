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
    public partial class Rolfrm : Form
    {

        RolController rol = new RolController();
     

        RolModel model = new RolModel();
        string id = "";
        ExportarExcel Excel = new ExportarExcel();

        Imprimir impre = new Imprimir();
        Exportpdf impdf = new Exportpdf();

        public Rolfrm()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dgvroles.DataSource = rol.GetRol();

        }

        private void Rolfrm_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            model.descripcion = txtdescripcion.Text;

            rol.Crear(model);
            txtdescripcion.Text = "";
            this.refrescar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                model.rolid = id;
                rol.eliminar(model);
                this.refrescar();

            }
        }

        private void dgvroles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dgvroles.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void txtfilnombre_TextChanged(object sender, EventArgs e)
        {
            string filtername = "descripcion";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilnombre.Text);
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDataGridViewExcel(dgvroles);
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            impdf.expopdf(dgvroles, 1, 2);
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            impre.imprimir(dgvroles, 1, 3);
        }
    }
}
