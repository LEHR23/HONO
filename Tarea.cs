using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HONO
{
    public partial class Tarea : UserControl
    {

        private List<Item> list;
        private Item tarea;
        TabControl control;

        public Tarea(TabControl contro)
        {
            control = contro;
            InitializeComponent();
            rellenar_lista();
        }

        public void rellenar_lista()
        {
            lista.Items.Clear();
            list = BasedeDatos.listatareas();
            if (list != null)
            {
                foreach (Item item in list)
                {
                    lista.Items.Add(item.titulo);
                }
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                tarea = BasedeDatos.consulta_tarea(list[lista.SelectedIndex].id);
                txttitulo.Text = tarea.titulo;
                txtfecha.Text = "FECHA: " + tarea.fecha_creacion.Substring(0, 9);
                txtnivel.Text = "NIVEL: " + tarea.nivel;
                txtestado.Text = "ESTADO: " + tarea.estado;
                if (tarea.contenido.Length > 50)
                {
                    txtcontenido.Text = tarea.contenido.Substring(0, 50) + "...";
                }
                else
                {
                    txtcontenido.Text = tarea.contenido;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            control.SelectedIndex = 3;
            Form1.vertarea(tarea);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            control.SelectedIndex = 3;
            Form1.nuevatarea();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(list[lista.SelectedIndex].id);
            BasedeDatos.eliminar_tarea(list[lista.SelectedIndex].id);
            rellenar_lista();
        }
    }
}
