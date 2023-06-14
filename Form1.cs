using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HONO
{
    public partial class Form1 : Form
    {

        private static Inicio panel_inicio;
        private static Nota panel_nota;
        private static Tarea panel_tarea;
        private static Editar_Agregar panel_nuevo = new Editar_Agregar();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1()
        {
            InitializeComponent();
            panel_inicio = new Inicio(tap_control);
            panel_nota = new Nota(tap_control);
            panel_tarea = new Tarea(tap_control);
            tap_control.SendToBack();
            tab_inicio.Controls.Add(panel_inicio);
            tap_nota.Controls.Add(panel_nota);
            tap_tarea.Controls.Add(panel_tarea);
            tap_agre_edit.Controls.Add(panel_nuevo);
            BasedeDatos.crearbasededatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel_nuevo.nuevo();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            panel_nuevo.nuevo();
            panel_inicio.rellenar_listas();
            tap_control.SelectedIndex = 0;
            btn_inicio.BackColor = Color.Transparent;
            btn_inicio.ForeColor = Color.White;
            btn_notas.BackColor = Color.White;
            btn_notas.ForeColor = Color.FromArgb(105, 106, 138);
            btn_tareas.BackColor = Color.White;
            btn_tareas.ForeColor = Color.FromArgb(105, 106, 138);
            btn_nuevo.BackColor = Color.White;
            btn_nuevo.ForeColor = Color.FromArgb(105, 106, 138);
        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            panel_nuevo.nuevo();
            panel_nota.rellenar_lista();
            tap_control.SelectedIndex = 1;
            btn_inicio.BackColor = Color.White;
            btn_inicio.ForeColor = Color.FromArgb(105, 106, 138);
            btn_notas.BackColor = Color.Transparent;
            btn_notas.ForeColor = Color.White;
            btn_tareas.BackColor = Color.White;
            btn_tareas.ForeColor = Color.FromArgb(105, 106, 138);
            btn_nuevo.BackColor = Color.White;
            btn_nuevo.ForeColor = Color.FromArgb(105, 106, 138);
        }

        private void btn_tareas_Click(object sender, EventArgs e)
        {
            panel_nuevo.nuevo();
            panel_tarea.rellenar_lista();
            tap_control.SelectedIndex = 2;
            btn_inicio.BackColor = Color.White;
            btn_inicio.ForeColor = Color.FromArgb(105, 106, 138);
            btn_notas.BackColor = Color.White;
            btn_notas.ForeColor = Color.FromArgb(105, 106, 138);
            btn_tareas.BackColor = Color.Transparent;
            btn_tareas.ForeColor = Color.White;
            btn_nuevo.BackColor = Color.White;
            btn_nuevo.ForeColor = Color.FromArgb(105, 106, 138);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            panel_nuevo.nuevo();
            tap_control.SelectedIndex = 3;
            btn_inicio.BackColor = Color.White;
            btn_inicio.ForeColor = Color.FromArgb(105, 106, 138);
            btn_notas.BackColor = Color.White;
            btn_notas.ForeColor = Color.FromArgb(105, 106, 138);
            btn_tareas.BackColor = Color.White;
            btn_tareas.ForeColor = Color.FromArgb(105, 106, 138);
            btn_nuevo.BackColor = Color.Transparent;
            btn_nuevo.ForeColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        public static void vernota(Item item)
        {
            panel_nuevo.editar_nota(item);
        }

        public static void vertarea(Item item)
        {
            panel_nuevo.editar_tarea(item);
        }

        public static void nuevanota()
        {
            panel_nuevo.nuevanota();
        }

        public static void nuevatarea()
        {
            panel_nuevo.nuevatarea();
        }

    }
}
