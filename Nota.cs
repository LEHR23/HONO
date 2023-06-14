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
    public partial class Nota : UserControl
    {
        private List<Item> list;
        private Item nota;
        TabControl control;

        public Nota(TabControl contro)
        {
            control = contro;
            InitializeComponent();
            rellenar_lista();
        }

        public void rellenar_lista()
        {
            lista.Items.Clear();
            list = BasedeDatos.listanotas();
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
                nota = BasedeDatos.consulta_nota(list[lista.SelectedIndex].id);
                txt_titulo.Text = nota.titulo;
                txt_fecha.Text = "FECHA: " + nota.fecha_creacion.Substring(0, 9);
                txt_nivel.Text = "NIVEL: " + nota.nivel;
                if (nota.contenido.Length > 50)
                {
                    txt_contenido.Text = nota.contenido.Substring(0, 50) + "...";
                }
                else
                {
                    txt_contenido.Text = nota.contenido;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            control.SelectedIndex = 3;
            Form1.vernota(nota);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            control.SelectedIndex = 3;
            Form1.nuevanota();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(lista.SelectedIndex >= 0)
            {
                Console.WriteLine(list[lista.SelectedIndex].id);
                BasedeDatos.eliminar_nota(list[lista.SelectedIndex].id);
                rellenar_lista();
            }
        }
    }
}
