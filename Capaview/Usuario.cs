using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BtnPrinterExcel.Capacontroller;
using BtnPrinterExcel.Capamodelo;
using System.Drawing.Printing;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace BtnPrinterExcel.Capaview
{
    public partial class Usuario : Form

    {
        Empleadocontroller emple = new Empleadocontroller();
        ExportarExcel Excel = new ExportarExcel();
        UsuarioModel model = new UsuarioModel();
        Imprimir impre = new Imprimir();
        Exportpdf impdf = new Exportpdf();
        string id; 

        public Usuario()
        {
            InitializeComponent();
        }
        private void refrescar()
        {
            dgvempleados.DataSource = emple.getempleados();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            string filtername = "NombreUsuario";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtnom.Text);
        }

        private void textRol_TextChanged(object sender, EventArgs e)
        {
            string filtername = "RolUsuario";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtRol.Text);
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            string filtername = "codigoempleado";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtCod.Text);
        }

        private void textApe_TextChanged(object sender, EventArgs e)
        {
            string filtername = "ApelldoUsuario";
            ((DataTable)dgvempleados.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                textApe.Text);
        }

        private int i = -1;
        

        //private void btnimprimir_Click(object sender, EventArgs e)
        //{


        //    PrintDocument doc = new PrintDocument();
        //    doc.DefaultPageSettings.Landscape = true;
        //    doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

        //    PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
        //    ((Form)ppd).WindowState = FormWindowState.Maximized;

        //    doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
        //    {
        //        const int DGV_ALTO = 35;
        //        float valorhead = 0;
        //        int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
        //        // float yposition = ep.MarginBounds.Top;


        //        foreach (DataGridViewColumn col in dgvempleados.Columns)
        //        {
        //            if (col.Index >= 1 && col.Index < 6)
        //            {

        //                ep.Graphics.DrawString(col.HeaderText, new Font("Arial", 12, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
        //                left += col.Width;

        //            }


        //            //if (col.Index < dgvempleados.ColumnCount - 1)
        //            //{
        //            //    ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvempleados.RowCount - 1) * DGV_ALTO);
        //            //}

        //        }
        //        left = ep.MarginBounds.Left;
        //        ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
        //        top += 43;

        //        foreach (DataGridViewRow row in dgvempleados.Rows)
        //        {

        //            if (row.Index == dgvempleados.RowCount - 1) break;
        //            left = ep.MarginBounds.Left;
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                if (cell.ColumnIndex > 0 && cell.ColumnIndex < 6)
        //                {
        //                    ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 10), Brushes.Black, left, top + 4);
        //                    left += cell.OwningColumn.Width;
        //                }



        //            }
        //            top += +DGV_ALTO;
        //            ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);

        //        }
        //    };


        //    ppd.ShowDialog();
        //}


        private void btnimprimir_Click_1(object sender, EventArgs e)
        {
            impre.imprimir(dgvempleados,1,6);
        }

        private void btnToxls_Click(object sender, EventArgs e)
        {

            Excel.ExportarDataGridViewExcel(dgvempleados);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            model.NombreUsuario = txtempleadoi.Text;
            model.ApelldoUsuario = txtapellido.Text;
            model.RolUsuario = txtantiguedad.Text;
            model.clave = txtrap.Text;
            model.intentoLogueos = 0;
     
            emple.CrearEmpleado(model);
            this.refrescar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            model.idusuario = this.id;
            this.refrescar();

            emple.delusuario(model);
        }

        private void dgvempleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dgvempleados.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btntopdf_Click(object sender, EventArgs e)
        {
            impdf.expopdf(dgvempleados, 1, 5);
        }
    }
}





