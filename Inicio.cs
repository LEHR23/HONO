using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace HONO
{
    public partial class Inicio : UserControl
    {
    
        List<Item> lista_notas;
        List<Item> lista_tareas;
        TabControl control;
        String[] tipos_orden = {"Fecha de Creación","Fecha de Modificación", "Nivel" };

        public Inicio(TabControl contro)
        {
            control = contro;
            InitializeComponent();
            rellenar_listas();
        }

        public void rellenar_listas()
        {
            list_notas.Items.Clear();
            list_tareas.Items.Clear();
            lista_notas = BasedeDatos.listanotas();
            if (lista_notas != null)
            {
                foreach (Item item in lista_notas)
                {
                    list_notas.Items.Add(item.titulo);
                }
            }
            lista_tareas = BasedeDatos.listatareas();
            if (lista_tareas != null)
            {
                foreach (Item item in lista_tareas)
                {
                    list_tareas.Items.Add(item.titulo);
                }
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if(rb_notas.Checked && rb_fecha.Checked)
            {
                generar_solo(1,0);
            }
            if (rb_notas.Checked && rb_fecha_mod.Checked)
            {
                generar_solo(1, 1);
            }
            if (rb_notas.Checked && rb_nivel.Checked)
            {
                generar_solo(1, 2);
            }
            if (rb_tareas.Checked && rb_fecha.Checked)
            {
                generar_solo(2, 0);
            }
            if (rb_tareas.Checked && rb_fecha_mod.Checked)
            {
                generar_solo(2, 1);
            }
            if (rb_tareas.Checked && rb_nivel.Checked)
            {
                generar_solo(2, 2);
            }
            if (rb_todos.Checked && rb_fecha.Checked)
            {
                generar_todo(0);
            }
            if (rb_todos.Checked && rb_fecha_mod.Checked)
            {
                generar_todo(1);
            }
            if (rb_todos.Checked && rb_nivel.Checked)
            {
                generar_todo(2);
            }

        }

        private void generar_todo(int orden)
        {

            List<Item> lista = new List<Item>();
            List<Item> listaorden = new List<Item>();
            switch (orden)
            {
                case 0: lista = BasedeDatos.generarallfecha(); break;
                case 1: lista = BasedeDatos.generarallfechamod(); break;
                case 2: lista = BasedeDatos.generarallnivel(); break;
            }
            listaorden.Add(new Item("Orden por " + tipos_orden[orden],"-5"));
            String orden_tip = "";
            switch (orden)
            {
                case 0: orden_tip = lista[0].fecha_creacion.Substring(0, 10); break;
                case 1: orden_tip = lista[0].fecha_modificacion.Substring(0, 10); break;
                case 2: orden_tip = lista[0].nivel; break;
            }
            if (orden == 2)
            {
                listaorden.Add(new Item("Nivel: " + orden_tip, "-4"));
            }
            else
            {
                listaorden.Add(new Item("Fecha: " + orden_tip, "-4"));
            }
            foreach (Item item in lista)
            {
                switch (orden)
                {
                    case 0:
                        if (item.fecha_creacion.Substring(0, 10).Equals(orden_tip))
                        {
                            listaorden.Add(item);
                        }
                        else
                        {
                            orden_tip = item.fecha_creacion.Substring(0, 10);
                            listaorden.Add(new Item("Fecha: " + orden_tip, "-4"));
                            listaorden.Add(item);
                        }
                        break;
                    case 1:
                        if (item.fecha_modificacion.Substring(0, 10).Equals(orden_tip))
                        {
                            listaorden.Add(item);
                        }
                        else
                        {
                            orden_tip = item.fecha_modificacion.Substring(0, 10);
                            listaorden.Add(new Item("Fecha: " + orden_tip, "-4"));
                            listaorden.Add(item);
                        }
                        break;
                    case 2:
                        Console.WriteLine(item.titulo);
                        if (item.nivel.Equals(orden_tip))
                        {
                            listaorden.Add(item);
                        }
                        else
                        {
                            orden_tip = item.nivel;
                            listaorden.Add(new Item("Nivel: " + orden_tip, "-4"));
                            listaorden.Add(item);
                        }
                        break;
                }

            }
            generarall(listaorden);
        }

        private void generarall(List<Item> lista)
        {
            //// Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            //// Indicamos donde vamos a guardar el documento
            String path = String.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path + "\\LISTA.pdf", FileMode.Create));

                //// Le colocamos el título y el autor
                //// **Nota: Esto no será visible en el documento
                doc.AddTitle("LISTA DE REGISTROS");
                doc.AddCreator("Ctrl Solution");

                //// Abrimos el archivo
                doc.Open();
                //// Creamos el tipo de Font que vamos utilizar
                iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //// Escribimos el encabezamiento en el documento
                doc.Add(new Paragraph("LISTA DE REGISTROS"));
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph(lista[0].titulo));
                Paragraph ayuda;
                PdfPTable tblPrueba = null;
                PdfPCell cltipo;
                PdfPCell cltitulo;
                PdfPCell clfecha;
                PdfPCell clnivel;
                PdfPCell clestado = null;
                PdfPCell clcontenido;
                PdfPCell clfechmod;
                PdfPCell clfechentre = null;

                foreach (Item i in lista)
                {
                    if (i.id.Equals("0"))
                    {
                        cltipo = new PdfPCell(new Phrase(i.tipo,standardFont));
                        cltipo.BorderWidth = 0;
                        cltitulo = new PdfPCell(new Phrase(i.titulo, standardFont));
                        cltitulo.BorderWidth = 0;
                        clfecha = new PdfPCell(new Phrase(i.fecha_creacion.Substring(0, 10).ToString(), standardFont));
                        clfecha.BorderWidth = 0;
                        clnivel = new PdfPCell(new Phrase(i.nivel, standardFont));
                        clnivel.BorderWidth = 0; 
                        clestado = new PdfPCell(new Phrase(i.estado, standardFont));
                        clestado.BorderWidth = 0;
                        clcontenido = new PdfPCell(new Phrase(i.contenido, standardFont));
                        clcontenido.BorderWidth = 0;
                        clfechmod = new PdfPCell(new Phrase(i.fecha_modificacion.Substring(0, 10).ToString(), standardFont));
                        clfechmod.BorderWidth = 0;
                        clfechentre = new PdfPCell(new Phrase(i.fecha_entrega.Substring(0, 10).ToString(), standardFont));
                        clfechentre.BorderWidth = 0;

                        tblPrueba.AddCell(cltipo);
                        tblPrueba.AddCell(cltitulo);
                        tblPrueba.AddCell(clfecha);
                        tblPrueba.AddCell(clnivel);
                        tblPrueba.AddCell(clestado);
                        tblPrueba.AddCell(clcontenido);
                        tblPrueba.AddCell(clfechmod);
                        tblPrueba.AddCell(clfechentre);

                    }
                    else
                    {
                        if (i.id.Equals("-4"))
                        {
                            if (tblPrueba == null)
                            {
                                
                                tblPrueba = new PdfPTable(8);
                                tblPrueba.WidthPercentage = 100;
                                //// Configuramos el título de las columnas de la tabla
                                cltipo = new PdfPCell(new Phrase("Tipo",standardFont));
                                cltipo.BorderWidth = 0;
                                cltipo.BorderWidthBottom = 0.5f;
                                cltitulo = new PdfPCell(new Phrase("Titulo", standardFont));
                                cltitulo.BorderWidth = 0;
                                cltitulo.BorderWidthBottom = 0.5f;
                                clfecha = new PdfPCell(new Phrase("Fecha", standardFont));
                                clfecha.BorderWidth = 0;
                                clfecha.BorderWidthBottom = 0.5f;
                                clnivel = new PdfPCell(new Phrase("Nivel", standardFont));
                                clnivel.BorderWidth = 0;
                                clnivel.BorderWidthBottom = 0.5f;
                                clestado = new PdfPCell(new Phrase("Estado", standardFont));
                                clestado.BorderWidth = 0;
                                clestado.BorderWidthBottom = 0.5f;
                                clcontenido = new PdfPCell(new Phrase("Contenido", standardFont));
                                clcontenido.BorderWidth = 0;
                                clcontenido.BorderWidthBottom = 0.5f;
                                clfechmod = new PdfPCell(new Phrase("Fecha Modificacion", standardFont));
                                clfechmod.BorderWidth = 0;
                                clfechmod.BorderWidthBottom = 0.5f;
                                clfechentre = new PdfPCell(new Phrase("Fecha Entrega", standardFont));
                                clfechentre.BorderWidth = 0;
                                clfechentre.BorderWidthBottom = 0.5f;

                                //// Añadimos las celdas a la tabla
                                tblPrueba.AddCell(cltipo);
                                tblPrueba.AddCell(cltitulo);
                                tblPrueba.AddCell(clfecha);
                                tblPrueba.AddCell(clnivel);
                                tblPrueba.AddCell(clestado);
                                tblPrueba.AddCell(clcontenido);
                                tblPrueba.AddCell(clfechmod);
                                tblPrueba.AddCell(clfechentre);
                                
                            }
                            else
                            {
                                doc.Add(tblPrueba);
                                tblPrueba = new PdfPTable(8);
                                tblPrueba.WidthPercentage = 100;

                                //// Configuramos el título de las columnas de la tabla
                                cltipo = new PdfPCell(new Phrase("Tipo", standardFont));
                                cltipo.BorderWidth = 0;
                                cltipo.BorderWidthBottom = 0.5f;
                                cltitulo = new PdfPCell(new Phrase("Titulo", standardFont));
                                cltitulo.BorderWidth = 0;
                                cltitulo.BorderWidthBottom = 0.5f;
                                clfecha = new PdfPCell(new Phrase("Fecha", standardFont));
                                clfecha.BorderWidth = 0;
                                clfecha.BorderWidthBottom = 0.5f;
                                clnivel = new PdfPCell(new Phrase("Nivel", standardFont));
                                clnivel.BorderWidth = 0;
                                clnivel.BorderWidthBottom = 0.5f;
                                clestado = new PdfPCell(new Phrase("Estado", standardFont));
                                clestado.BorderWidth = 0;
                                clestado.BorderWidthBottom = 0.5f;
                                clcontenido = new PdfPCell(new Phrase("Contenido", standardFont));
                                clcontenido.BorderWidth = 0;
                                clcontenido.BorderWidthBottom = 0.5f;
                                clfechmod = new PdfPCell(new Phrase("Fecha Modificacion", standardFont));
                                clfechmod.BorderWidth = 0;
                                clfechmod.BorderWidthBottom = 0.5f;
                                clfechentre = new PdfPCell(new Phrase("Fecha Entrega", standardFont));
                                clfechentre.BorderWidth = 0;
                                clfechentre.BorderWidthBottom = 0.5f;

                                //// Añadimos las celdas a la tabla
                                tblPrueba.AddCell(cltipo);
                                tblPrueba.AddCell(cltitulo);
                                tblPrueba.AddCell(clfecha);
                                tblPrueba.AddCell(clnivel);
                                tblPrueba.AddCell(clestado);
                                tblPrueba.AddCell(clcontenido);
                                tblPrueba.AddCell(clfechmod);
                                tblPrueba.AddCell(clfechentre);
                            }
                            doc.Add(Chunk.NEWLINE);
                            ayuda = new Paragraph(i.titulo);
                            doc.Add(ayuda);
                            doc.Add(new Paragraph(Chunk.NEWLINE));
                        }
                    }
                }

                //// Finalmente, añadimos la tabla al documento PDF y cerramos el documento
                doc.Add(tblPrueba);
                doc.Close();
                writer.Close();
            }
        }

        private void generar_solo(int tipo,int orden)
        {
            List<Item> lista = new List<Item>();
            if (tipo == 1)
            {
                lista.Add(new Item("Notas por " + tipos_orden[orden], "-5"));
            }
            else
            {
                lista.Add(new Item("Tareas por " + tipos_orden[orden], "-5"));
            }
            List<Item> listregis = null;
            switch (orden)
            {
                case 0: listregis = BasedeDatos.generarfecha(tipo); break;
                case 1: listregis = BasedeDatos.generarmodif(tipo); break;
                case 2: listregis = BasedeDatos.generarnivel(tipo); break;
            }
            String orden_tip = "";
            switch (orden)
            {
                case 0: orden_tip = listregis[0].fecha_creacion.Substring(0,10); break;
                case 1: orden_tip = listregis[0].fecha_modificacion.Substring(0, 10); break;
                case 2: orden_tip = listregis[0].nivel; break;
            }
            if (orden == 2)
            {
                lista.Add(new Item("Nivel: " + orden_tip, "-4"));
            }
            else
            {
                lista.Add(new Item("Fecha: " + orden_tip, "-4"));
            }
            foreach (Item item in listregis)
            {
                switch (orden)
                {
                    case 0:
                        if (item.fecha_creacion.Substring(0,10).Equals(orden_tip))
                        {
                            lista.Add(item);
                        }
                        else
                        {
                            orden_tip = item.fecha_creacion.Substring(0,10);
                            lista.Add(new Item("Fecha: " + orden_tip, "-4"));
                            lista.Add(item);
                        }
                        break;
                    case 1:
                        if (item.fecha_modificacion.Substring(0, 10).Equals(orden_tip))
                        {
                            lista.Add(item);
                        }
                        else
                        {
                            orden_tip = item.fecha_modificacion.Substring(0, 10);
                            lista.Add(new Item("Fecha: " + orden_tip, "-4"));
                            lista.Add(item);
                        }
                        break;
                    case 2:
                        if (item.nivel.Equals(orden_tip))
                        {
                            lista.Add(item);
                        }
                        else
                        {
                            orden_tip = item.nivel;
                            lista.Add(new Item("Nivel: " + orden_tip, "-4"));
                            lista.Add(item);
                        }
                        break;
                }
                
            }
            generar(lista, tipo);
        }

        private void generar(List<Item> lista, int tipo)
        {
            //// Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            //// Indicamos donde vamos a guardar el documento
            String path = String.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path + "\\LISTA.pdf", FileMode.Create));

                //// Le colocamos el título y el autor
                //// **Nota: Esto no será visible en el documento
                doc.AddTitle("LISTA DE REGISTROS");
                doc.AddCreator("Ctrl Solution");

                //// Abrimos el archivo
                doc.Open();
                //// Creamos el tipo de Font que vamos utilizar
                iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //// Escribimos el encabezamiento en el documento
                doc.Add(new Paragraph("LISTA DE REGISTROS"));
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph(lista[0].titulo));
                Paragraph ayuda;
                PdfPTable tblPrueba = null;
                PdfPCell cltitulo;
                PdfPCell clfecha;
                PdfPCell clnivel;
                PdfPCell clestado = null;
                PdfPCell clcontenido;
                PdfPCell clfechmod;
                PdfPCell clfechentre = null;

                foreach (Item i in lista)
                {
                    if (i.id.Equals("0"))
                    {
                        cltitulo = new PdfPCell(new Phrase(i.titulo, standardFont));
                        cltitulo.BorderWidth = 0;
                        clfecha = new PdfPCell(new Phrase(i.fecha_creacion.Substring(0, 10).ToString(), standardFont));
                        clfecha.BorderWidth = 0;
                        clnivel = new PdfPCell(new Phrase(i.nivel, standardFont));
                        clnivel.BorderWidth = 0;
                        clcontenido = new PdfPCell(new Phrase(i.contenido, standardFont));
                        clcontenido.BorderWidth = 0;
                        clfechmod = new PdfPCell(new Phrase(i.fecha_modificacion.Substring(0, 10).ToString(), standardFont));
                        clfechmod.BorderWidth = 0;
                        if(tipo == 2)
                        {
                            clfechentre = new PdfPCell(new Phrase(i.fecha_entrega.Substring(0, 10).ToString(), standardFont));
                            clfechentre.BorderWidth = 0;
                            clestado = new PdfPCell(new Phrase(i.estado, standardFont));
                            clestado.BorderWidth = 0;
                        }
                        tblPrueba.AddCell(cltitulo);
                        tblPrueba.AddCell(clfecha);
                        tblPrueba.AddCell(clnivel);
                        tblPrueba.AddCell(clcontenido);
                        tblPrueba.AddCell(clfechmod);
                        
                        if(tipo == 2)
                        {
                            tblPrueba.AddCell(clfechentre);
                            tblPrueba.AddCell(clestado);
                        }
                    }
                    else
                    {
                        if (i.id.Equals("-4"))
                        {
                            if(tblPrueba == null)
                            {
                                if (tipo == 2)
                                {
                                    tblPrueba = new PdfPTable(7);
                                    tblPrueba.WidthPercentage = 100;
                                }
                                else
                                {
                                    tblPrueba = new PdfPTable(5);
                                    tblPrueba.WidthPercentage = 100;
                                }
                                //// Configuramos el título de las columnas de la tabla
                                cltitulo = new PdfPCell(new Phrase("Titulo", standardFont));
                                cltitulo.BorderWidth = 0;
                                cltitulo.BorderWidthBottom = 0.5f;
                                clfecha = new PdfPCell(new Phrase("Fecha", standardFont));
                                clfecha.BorderWidth = 0;
                                clfecha.BorderWidthBottom = 0.5f;
                                clnivel = new PdfPCell(new Phrase("Nivel", standardFont));
                                clnivel.BorderWidth = 0;
                                clnivel.BorderWidthBottom = 0.5f;
                                clcontenido = new PdfPCell(new Phrase("Contenido", standardFont));
                                clcontenido.BorderWidth = 0;
                                clcontenido.BorderWidthBottom = 0.5f;
                                clfechmod = new PdfPCell(new Phrase("Fecha Modificacion", standardFont));
                                clfechmod.BorderWidth = 0;
                                clfechmod.BorderWidthBottom = 0.5f;
                                if (tipo == 2)
                                {
                                    clfechentre = new PdfPCell(new Phrase("Fecha Entrega", standardFont));
                                    clfechentre.BorderWidth = 0;
                                    clfechentre.BorderWidthBottom = 0.5f;
                                    clestado = new PdfPCell(new Phrase("Estado", standardFont));
                                    clestado.BorderWidth = 0;
                                    clestado.BorderWidthBottom = 0.5f;
                                }
                                //// Añadimos las celdas a la tabla
                                tblPrueba.AddCell(cltitulo);
                                tblPrueba.AddCell(clfecha);
                                tblPrueba.AddCell(clnivel);
                                tblPrueba.AddCell(clcontenido);
                                tblPrueba.AddCell(clfechmod);
                                if(tipo == 2)
                                {
                                    tblPrueba.AddCell(clfechentre);
                                    tblPrueba.AddCell(clestado);
                                }
                            }
                            else
                            {
                                doc.Add(tblPrueba);
                                if (tipo == 2)
                                {
                                    tblPrueba = new PdfPTable(7);
                                    tblPrueba.WidthPercentage = 100;
                                }
                                else
                                {
                                    tblPrueba = new PdfPTable(5);
                                    tblPrueba.WidthPercentage = 100;
                                }
                                //// Configuramos el título de las columnas de la tabla
                                cltitulo = new PdfPCell(new Phrase("Titulo", standardFont));
                                cltitulo.BorderWidth = 0;
                                cltitulo.BorderWidthBottom = 0.5f;
                                clfecha = new PdfPCell(new Phrase("Fecha", standardFont));
                                clfecha.BorderWidth = 0;
                                clfecha.BorderWidthBottom = 0.5f;
                                clnivel = new PdfPCell(new Phrase("Nivel", standardFont));
                                clnivel.BorderWidth = 0;
                                clnivel.BorderWidthBottom = 0.5f;
                                clcontenido = new PdfPCell(new Phrase("Contenido", standardFont));
                                clcontenido.BorderWidth = 0;
                                clcontenido.BorderWidthBottom = 0.5f;
                                clfechmod = new PdfPCell(new Phrase("Fecha Modificacion", standardFont));
                                clfechmod.BorderWidth = 0;
                                clfechmod.BorderWidthBottom = 0.5f;
                                if(tipo == 2)
                                {
                                    clfechentre = new PdfPCell(new Phrase("Fecha Entrega", standardFont));
                                    clfechentre.BorderWidth = 0;
                                    clfechentre.BorderWidthBottom = 0.5f;
                                    clestado = new PdfPCell(new Phrase("Estado", standardFont));
                                    clestado.BorderWidth = 0;
                                    clestado.BorderWidthBottom = 0.5f;
                                }
                                //// Añadimos las celdas a la tabla
                                tblPrueba.AddCell(cltitulo);
                                tblPrueba.AddCell(clfecha);
                                tblPrueba.AddCell(clnivel);
                                tblPrueba.AddCell(clcontenido);
                                tblPrueba.AddCell(clfechmod);
                                if (tipo == 2)
                                {
                                    tblPrueba.AddCell(clfechentre);
                                    tblPrueba.AddCell(clestado);
                                }
                            }
                            doc.Add(Chunk.NEWLINE);
                            ayuda = new Paragraph(i.titulo);
                            doc.Add(ayuda);
                            doc.Add(new Paragraph(Chunk.NEWLINE));
                        }
                    }
                }

                //// Finalmente, añadimos la tabla al documento PDF y cerramos el documento
                doc.Add(tblPrueba);
                doc.Close();
                writer.Close();
            }
        }

        private void mostrarnota()
        {
            Item nota = BasedeDatos.consulta_nota(lista_notas[list_notas.SelectedIndex].id);
            control.SelectedIndex = 3;
            Form1.vernota(nota);
        }

        private void mostrartarea()
        {
            Item tarea = BasedeDatos.consulta_tarea(lista_tareas[list_tareas.SelectedIndex].id);
            control.SelectedIndex = 3;
            Form1.vertarea(tarea);
        }

        private void list_notas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mostrarnota();
        }

        private void list_notas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                mostrarnota();
            }
        }

        private void list_tareas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mostrartarea();
        }

        private void list_tareas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mostrartarea();
            }
        }
    }
}
