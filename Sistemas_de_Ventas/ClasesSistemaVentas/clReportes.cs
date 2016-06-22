using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

//Para el manejo de Archivos
using System.IO;

//Clases necesarias de iTextSharp
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ClasesSistemaVentas
{
    public class clReportes
    {
        public static void PorFecha(string nombre, DataGridView dgCortes)
        {
            if (dgCortes.RowCount != 0)
            {
                //crear documento
                Document doc = new Document(PageSize.LETTER);
                //indicar direccion y nombre
                //string nombreFile = "Ventas(" + dTInicial.Value.Day + "-" + dTInicial.Value.Month + "-" + dTInicial.Value.Year + ")";

                string carpeta = @"C:\\PuntoVenta_Reportes";
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                    Console.WriteLine("Exito!!!");
                    Console.Read();
                }
                string ruta = @"C:\\PuntoVenta_Reportes\";

                PdfWriter destino = PdfWriter.GetInstance(doc, new FileStream(@ruta + nombre + ".pdf", FileMode.Create));
                doc.AddTitle("Reporte PDF");
                doc.AddCreator("Administrador");
                //abrir pdf
                doc.Open();

                //fuente
                iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                //encabezado
                doc.Add(new Paragraph("REPORTE DE VENTAS POR FECHA"));
                doc.Add(Chunk.NEWLINE);

                //crear tabla
                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;

                //titulos de columnas
                PdfPCell numCorte = new PdfPCell(new Phrase("Corte No.", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                numCorte.BorderWidth = 0;
                numCorte.BorderWidthBottom = 0.75f;

                PdfPCell fecha = new PdfPCell(new Phrase("Fecha", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                fecha.BorderWidth = 0;
                fecha.BorderWidthBottom = 0.75f;

                PdfPCell cajero = new PdfPCell(new Phrase("Cajero", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                cajero.BorderWidth = 0;
                cajero.BorderWidthBottom = 0.75f;

                PdfPCell turno = new PdfPCell(new Phrase("Turno", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                turno.BorderWidth = 0;
                turno.BorderWidthBottom = 0.75f;

                PdfPCell total = new PdfPCell(new Phrase("Total", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                cajero.BorderWidth = 0;
                cajero.BorderWidthBottom = 0.75f;

                //agregar titulos
                tabla.AddCell(numCorte);
                tabla.AddCell(fecha);
                tabla.AddCell(cajero);
                tabla.AddCell(turno);
                tabla.AddCell(total);

                //agregar datos del datagrid
                foreach (DataGridViewRow linea in dgCortes.Rows)
                {
                    numCorte = new PdfPCell(new Phrase(linea.Cells[0].Value.ToString()));
                    fecha = new PdfPCell(new Phrase(linea.Cells[1].Value.ToString()));
                    cajero = new PdfPCell(new Phrase(linea.Cells[2].Value.ToString()));
                    turno = new PdfPCell(new Phrase(linea.Cells[3].Value.ToString()));
                    total = new PdfPCell(new Phrase(linea.Cells[4].Value.ToString()));

                    tabla.AddCell(numCorte);
                    tabla.AddCell(fecha);
                    tabla.AddCell(cajero);
                    tabla.AddCell(turno);
                    tabla.AddCell(total);
                }

                //añadir tabla al pdf
                doc.Add(tabla);
                doc.Close();
                destino.Close();
                MessageBox.Show("Se guardó su reporte en " + ruta + nombre + ".pdf");
            }
            else
            {
                MessageBox.Show("No existen datos!!!");
            }
        }

        public static void PorTurno(string nombre, DataGridView dgCortes)
        {
            if (dgCortes.RowCount != 0)
            {
                //crear documento
                Document doc = new Document(PageSize.LETTER);
                //indicar direccion y nombre
                //string nombreFile = "Ventas(" + dTInicial.Value.Day + "-" + dTInicial.Value.Month + "-" + dTInicial.Value.Year + ")";

                string carpeta = @"C:\\PuntoVenta_Reportes";
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                    Console.WriteLine("Exito!!!");
                    Console.Read();
                }
                string ruta = @"C:\\PuntoVenta_Reportes\";

                PdfWriter destino = PdfWriter.GetInstance(doc, new FileStream(@ruta + nombre + ".pdf", FileMode.Create));
                doc.AddTitle("Reporte PDF");
                doc.AddCreator("Administrador");
                //abrir pdf
                doc.Open();

                //fuente
                iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                //encabezado
                doc.Add(new Paragraph("REPORTE DE VENTAS POR TURNO"));
                doc.Add(Chunk.NEWLINE);

                //crear tabla
                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;

                //titulos de columnas
                PdfPCell numCorte = new PdfPCell(new Phrase("Corte No.", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                numCorte.BorderWidth = 0;
                numCorte.BorderWidthBottom = 0.75f;

                PdfPCell fecha = new PdfPCell(new Phrase("Fecha", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                fecha.BorderWidth = 0;
                fecha.BorderWidthBottom = 0.75f;

                PdfPCell cajero = new PdfPCell(new Phrase("Cajero", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                cajero.BorderWidth = 0;
                cajero.BorderWidthBottom = 0.75f;

                PdfPCell turno = new PdfPCell(new Phrase("Turno", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                turno.BorderWidth = 0;
                turno.BorderWidthBottom = 0.75f;

                PdfPCell total = new PdfPCell(new Phrase("Total", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                cajero.BorderWidth = 0;
                cajero.BorderWidthBottom = 0.75f;

                //agregar titulos
                tabla.AddCell(numCorte);
                tabla.AddCell(fecha);
                tabla.AddCell(cajero);
                tabla.AddCell(turno);
                tabla.AddCell(total);

                //agregar datos del datagrid
                foreach (DataGridViewRow linea in dgCortes.Rows)
                {
                    numCorte = new PdfPCell(new Phrase(linea.Cells[0].Value.ToString()));
                    fecha = new PdfPCell(new Phrase(linea.Cells[1].Value.ToString()));
                    cajero = new PdfPCell(new Phrase(linea.Cells[2].Value.ToString()));
                    turno = new PdfPCell(new Phrase(linea.Cells[3].Value.ToString()));
                    total = new PdfPCell(new Phrase(linea.Cells[4].Value.ToString()));

                    tabla.AddCell(numCorte);
                    tabla.AddCell(fecha);
                    tabla.AddCell(cajero);
                    tabla.AddCell(turno);
                    tabla.AddCell(total);
                }

                //añadir tabla al pdf
                doc.Add(tabla);
                doc.Close();
                destino.Close();
                MessageBox.Show("Se guardó su reporte en " + ruta + nombre + ".pdf");
            }
            else
            {
                MessageBox.Show("No existen datos!!!");
            }
        }

        public static void PorCajero(string nombre, DataGridView dgCortes)
        {
            if (dgCortes.RowCount != 0)
            {
                //crear documento
                Document doc = new Document(PageSize.LETTER);
                //indicar direccion y nombre
                //string nombreFile = "Ventas(" + dTInicial.Value.Day + "-" + dTInicial.Value.Month + "-" + dTInicial.Value.Year + ")";

                string carpeta = @"C:\\PuntoVenta_Reportes";
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                    Console.WriteLine("Exito!!!");
                    Console.Read();
                }
                string ruta = @"C:\\PuntoVenta_Reportes\";

                PdfWriter destino = PdfWriter.GetInstance(doc, new FileStream(@ruta + nombre + ".pdf", FileMode.Create));
                doc.AddTitle("Reporte PDF");
                doc.AddCreator("Administrador");
                //abrir pdf
                doc.Open();

                //fuente
                iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                //encabezado
                doc.Add(new Paragraph("REPORTE DE VENTAS POR TURNO"));
                doc.Add(Chunk.NEWLINE);

                //crear tabla
                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;

                //titulos de columnas
                PdfPCell numCorte = new PdfPCell(new Phrase("Corte No.", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                numCorte.BorderWidth = 0;
                numCorte.BorderWidthBottom = 0.75f;

                PdfPCell fecha = new PdfPCell(new Phrase("Fecha", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                fecha.BorderWidth = 0;
                fecha.BorderWidthBottom = 0.75f;

                PdfPCell cajero = new PdfPCell(new Phrase("Cajero", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                cajero.BorderWidth = 0;
                cajero.BorderWidthBottom = 0.75f;

                PdfPCell turno = new PdfPCell(new Phrase("Turno", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                turno.BorderWidth = 0;
                turno.BorderWidthBottom = 0.75f;

                PdfPCell total = new PdfPCell(new Phrase("Total", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                cajero.BorderWidth = 0;
                cajero.BorderWidthBottom = 0.75f;

                //agregar titulos
                tabla.AddCell(numCorte);
                tabla.AddCell(fecha);
                tabla.AddCell(cajero);
                tabla.AddCell(turno);
                tabla.AddCell(total);

                //agregar datos del datagrid
                foreach (DataGridViewRow linea in dgCortes.Rows)
                {
                    numCorte = new PdfPCell(new Phrase(linea.Cells[0].Value.ToString()));
                    fecha = new PdfPCell(new Phrase(linea.Cells[1].Value.ToString()));
                    cajero = new PdfPCell(new Phrase(linea.Cells[2].Value.ToString()));
                    turno = new PdfPCell(new Phrase(linea.Cells[3].Value.ToString()));
                    total = new PdfPCell(new Phrase(linea.Cells[4].Value.ToString()));

                    tabla.AddCell(numCorte);
                    tabla.AddCell(fecha);
                    tabla.AddCell(cajero);
                    tabla.AddCell(turno);
                    tabla.AddCell(total);
                }

                //añadir tabla al pdf
                doc.Add(tabla);
                doc.Close();
                destino.Close();
                MessageBox.Show("Se guardó su reporte en " + ruta + nombre + ".pdf");
            }
            else
            {
                MessageBox.Show("No existen datos!!!");
            }
        }
    }
}
