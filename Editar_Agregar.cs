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
    public partial class Editar_Agregar : UserControl
    {
        Boolean actualizacion = false;
        Item item = new Item();


        public Editar_Agregar()
        {
            //se inician los componentes y los combos se les coloca un valor defaul
            InitializeComponent();
            combo_nivel.SelectedIndex = 0;
            combo_estado.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (btnguardar.Text.Equals("EDITAR"))
            {
                editar();
            }
            else
            {
                guardar();
            }
        }

        private void rbtarea_CheckedChanged(object sender, EventArgs e)
        {
            combo_estado.Visible = true;
            fechaentrega.Visible = true;
            labelentrega.Visible = true;
        }

        private void rbnota_CheckedChanged(object sender, EventArgs e)
        {
            combo_estado.Visible = false;
            fechaentrega.Visible = false;
            labelentrega.Visible = false;
        }

        private String eltitulo()
        {
            String cad = txttitulo.Text.ToString();
            if (!cad.Equals(""))
            {
                return cad;
            }
            return null;
        }

        private String elnivel()
        {
            String cad = combo_nivel.Text.ToString();
            if (!cad.Equals("NIVEL"))
            {
                return cad;
            }
            return null;
        }

        private String elestado()
        {
            String cad = combo_estado.Text.ToString();
            if (!cad.Equals("ESTADO"))
            {
                return cad;
            }
            return null;
        }

        private void nota(String tit, String fecha, String niv, String cont, String fechmod)
        {
            if (niv != null && tit != null)
            {
                BasedeDatos.insertar_nota(tit, fecha, niv, cont, fechmod);
            }
            else
            {
                MessageBox.Show("Verifique todos los campos");
            }
        }

        private void tarea(String tit, String fecha, String niv, String est, String cont, String fechmod, String fechentr)
        {
            if (niv != null && est != null && tit != null)
            {
                BasedeDatos.insertar_tarea(tit, fecha, niv, est, cont, fechmod, fechentr);
            }
            else
            {
                MessageBox.Show("Verifique todos los campos");
            }
        }

        public void nuevo()
        {
            if (!actualizacion)
            {
                txttitulo.Text = "";
                btnguardar.Text = "GUARDAR";
                rbtarea.Checked = true;
                combo_nivel.SelectedIndex = 0;
                combo_estado.SelectedIndex = 0;
                txtcontenido.Text = "";
                fechainicio.Value = System.DateTime.Now;
                fechaentrega.Value = System.DateTime.Now;
                txttitulo.BackColor = Color.FromArgb(105, 106, 138);
                txttitulo.Enabled = true;
                txtcontenido.Enabled = true;
                combo_estado.Enabled = true;
                combo_nivel.Enabled = true;
                fechaentrega.Enabled = true;
                fechainicio.Enabled = true;
                rbnota.Enabled = true;
                rbtarea.Enabled = true;
            }
            else
            {
                var resultado = MessageBox.Show("¿desea actualizar?","guardado",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    guardar();
                }
                else
                {
                    actualizacion = false;
                    nuevo();
                }
            }
        }

        public void editar_nota(Item lanota)
        {
            item = lanota;
            txttitulo.Text = lanota.titulo;
            txttitulo.BackColor = Color.FromArgb(255,255,255);
            txttitulo.Enabled = false;
            rbnota.Checked = true;
            rbnota.Enabled = false;
            rbtarea.Enabled = false;
            switch (lanota.nivel)
            {
                case "ALTA":combo_nivel.SelectedIndex = 1; break;
                case "MEDIA":combo_nivel.SelectedIndex = 2; break;
                case "BAJA":combo_nivel.SelectedIndex = 3; break;
            }
            combo_nivel.Enabled = false;
            String f = lanota.fecha_creacion.Substring(0,10);
            String []fecha = f.Split('/');
            fechainicio.Value = new DateTime(Int32.Parse(fecha[2]), Int32.Parse(fecha[1]), Int32.Parse(fecha[0]));
            fechainicio.Enabled = false;
            txtcontenido.Text = lanota.contenido;
            txtcontenido.Enabled = false;
            btnguardar.Text = "EDITAR";
        }

        public void editar_tarea(Item latarea)
        {
            item = latarea;
            txttitulo.Text = latarea.titulo;
            txttitulo.BackColor = Color.FromArgb(255, 255, 255);
            txttitulo.Enabled = false;
            rbtarea.Checked = true;
            rbnota.Enabled = false;
            rbtarea.Enabled = false;
            switch (latarea.nivel)
            {
                case "ALTA": combo_nivel.SelectedIndex = 1; break;
                case "MEDIA": combo_nivel.SelectedIndex = 2; break;
                case "BAJA": combo_nivel.SelectedIndex = 3; break;
            }
            combo_nivel.Enabled = false;
            String f = latarea.fecha_creacion.Substring(0, 10);
            String[] fecha = f.Split('/');
            fechainicio.Value = new DateTime(Int32.Parse(fecha[2]), Int32.Parse(fecha[1]), Int32.Parse(fecha[0]));
            fechainicio.Enabled = false;
            f = latarea.fecha_entrega.Substring(0, 10);
            fecha = f.Split('/');
            fechaentrega.Value = new DateTime(Int32.Parse(fecha[2]), Int32.Parse(fecha[1]), Int32.Parse(fecha[0]));
            fechaentrega.Enabled = false;
            switch (latarea.estado)
            {
                case "PENDIENTE": combo_estado.SelectedIndex = 1; break;
                case "POSPUESTO": combo_estado.SelectedIndex = 2; break;
                case "TERMINADO": combo_estado.SelectedIndex = 3; break;
                case "SUSPENDIDO": combo_estado.SelectedIndex = 4; break;
            }
            combo_estado.Enabled = false;
            txtcontenido.Text = latarea.contenido;
            txtcontenido.Enabled = false;
            btnguardar.Text = "EDITAR";

        }

        public void guardar()
        {
            //se recuperan los datos
            String tit = eltitulo();
            String fecha = fechainicio.Value.Month + "/" + fechainicio.Value.Day + "/" + fechainicio.Value.Year;
            String niv = elnivel();
            String est = elestado();
            String cont = txtcontenido.Text.ToString();
            String fechmod = System.DateTime.Today.Month + "/" + System.DateTime.Today.Day + "/" + System.DateTime.Today.Year;
            String fechentr = fechaentrega.Value.Month + "/" + fechaentrega.Value.Day + "/" + fechaentrega.Value.Year;
            item.titulo = tit;
            item.fecha_creacion = fecha;
            item.nivel = niv;
            item.estado = est;
            item.contenido = cont;
            item.fecha_modificacion = fechmod;
            item.fecha_entrega = fechentr;
            if (actualizacion)
            {
                if (rbtarea.Checked == true)
                {
                    tareaeditar(item);
                }
                else
                {
                    notaeditar(item);
                }
            }
            else
            {
                if (rbtarea.Checked == true)
                {
                    tarea(tit, fecha, niv, est, cont, fechmod, fechentr);
                }
                else
                {
                    nota(tit, fecha, niv, cont, fechmod);
                }
            }
        }

        private void notaeditar(Item item)
        {
            if (item.nivel != null && item.titulo != null)
            {
                BasedeDatos.editar_nota(item);
                actualizacion = false;
                nuevo();
            }
            else
            {
                MessageBox.Show("Verifique todos los campos");
            }
        }

        private void tareaeditar(Item item)
        {
            if (item.nivel != null && item.estado != null && item.titulo != null)
            {
                BasedeDatos.editar_tarea(item);
                actualizacion = false;
                nuevo();
            }
            else
            {
                MessageBox.Show("Verifique todos los campos");
            }
        }

        public void editar()
        {
            btnguardar.Text = "GUARDAR";
            txttitulo.BackColor = Color.FromArgb(105, 106, 138);
            txttitulo.Enabled = true;
            txtcontenido.Enabled = true;
            combo_estado.Enabled = true;
            combo_nivel.Enabled = true;
            fechaentrega.Enabled = true;
            actualizacion = true;
        }

        public void nuevatarea()
        {
            rbtarea.Checked = true;
        }

        public void nuevanota()
        {
            rbnota.Checked = true;
        }
    }
}
