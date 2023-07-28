using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;



namespace BtnPrinterExcel.Capacontroller
{ 
    class Imprimir
    {
        public void imprimir(DataGridView grd,  int columnaini, int colunmafin) {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                float valorhead = 0;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                // float yposition = ep.MarginBounds.Top;


                foreach (DataGridViewColumn col in grd.Columns)
                {
                    if (col.Index >= columnaini /*1*/ && col.Index < colunmafin /*6*/)
                    {

                        ep.Graphics.DrawString(col.HeaderText, new Font("Arial", 12, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                        left += col.Width;

                    }


                    //if (col.Index < dgvempleados.ColumnCount - 1)
                    //{
                    //    ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvempleados.RowCount - 1) * DGV_ALTO);
                    //}

                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in grd.Rows)
                {

                    if (row.Index == grd.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex >= columnaini && cell.ColumnIndex < colunmafin)
                        {
                            ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 10), Brushes.Black, left, top + 4);
                            left += cell.OwningColumn.Width;
                        }



                    }
                    top += +DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);

                }
            };


            ppd.ShowDialog();


        }
    }
}
