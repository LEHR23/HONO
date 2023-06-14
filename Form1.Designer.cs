namespace HONO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tap_control = new System.Windows.Forms.TabControl();
            this.tab_inicio = new System.Windows.Forms.TabPage();
            this.tap_nota = new System.Windows.Forms.TabPage();
            this.tap_tarea = new System.Windows.Forms.TabPage();
            this.tap_agre_edit = new System.Windows.Forms.TabPage();
            this.btn_inicio = new System.Windows.Forms.Label();
            this.btn_notas = new System.Windows.Forms.Label();
            this.btn_tareas = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tap_control.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tap_control
            // 
            this.tap_control.Controls.Add(this.tab_inicio);
            this.tap_control.Controls.Add(this.tap_nota);
            this.tap_control.Controls.Add(this.tap_tarea);
            this.tap_control.Controls.Add(this.tap_agre_edit);
            this.tap_control.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tap_control.Location = new System.Drawing.Point(201, 25);
            this.tap_control.Margin = new System.Windows.Forms.Padding(0);
            this.tap_control.Multiline = true;
            this.tap_control.Name = "tap_control";
            this.tap_control.SelectedIndex = 0;
            this.tap_control.Size = new System.Drawing.Size(710, 517);
            this.tap_control.TabIndex = 2;
            this.tap_control.Tag = "";
            // 
            // tab_inicio
            // 
            this.tab_inicio.Location = new System.Drawing.Point(4, 22);
            this.tab_inicio.Name = "tab_inicio";
            this.tab_inicio.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inicio.Size = new System.Drawing.Size(702, 491);
            this.tab_inicio.TabIndex = 0;
            this.tab_inicio.Text = "tap_inicio";
            this.tab_inicio.UseVisualStyleBackColor = true;
            // 
            // tap_nota
            // 
            this.tap_nota.Location = new System.Drawing.Point(4, 22);
            this.tap_nota.Name = "tap_nota";
            this.tap_nota.Padding = new System.Windows.Forms.Padding(3);
            this.tap_nota.Size = new System.Drawing.Size(702, 491);
            this.tap_nota.TabIndex = 1;
            this.tap_nota.Text = "tap_nota";
            this.tap_nota.UseVisualStyleBackColor = true;
            // 
            // tap_tarea
            // 
            this.tap_tarea.Location = new System.Drawing.Point(4, 22);
            this.tap_tarea.Name = "tap_tarea";
            this.tap_tarea.Size = new System.Drawing.Size(702, 491);
            this.tap_tarea.TabIndex = 2;
            this.tap_tarea.Text = "tap_tarea";
            this.tap_tarea.UseVisualStyleBackColor = true;
            // 
            // tap_agre_edit
            // 
            this.tap_agre_edit.Location = new System.Drawing.Point(4, 22);
            this.tap_agre_edit.Name = "tap_agre_edit";
            this.tap_agre_edit.Size = new System.Drawing.Size(702, 491);
            this.tap_agre_edit.TabIndex = 3;
            this.tap_agre_edit.Text = "AE";
            this.tap_agre_edit.UseVisualStyleBackColor = true;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inicio.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inicio.Location = new System.Drawing.Point(0, 0);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(205, 70);
            this.btn_inicio.TabIndex = 0;
            this.btn_inicio.Text = "INICIO";
            this.btn_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_notas
            // 
            this.btn_notas.BackColor = System.Drawing.Color.White;
            this.btn_notas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_notas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_notas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_notas.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.btn_notas.Location = new System.Drawing.Point(0, 70);
            this.btn_notas.Name = "btn_notas";
            this.btn_notas.Size = new System.Drawing.Size(205, 70);
            this.btn_notas.TabIndex = 1;
            this.btn_notas.Text = "NOTAS";
            this.btn_notas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_notas.Click += new System.EventHandler(this.btn_notas_Click);
            // 
            // btn_tareas
            // 
            this.btn_tareas.BackColor = System.Drawing.Color.White;
            this.btn_tareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_tareas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_tareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tareas.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.btn_tareas.Location = new System.Drawing.Point(0, 140);
            this.btn_tareas.Name = "btn_tareas";
            this.btn_tareas.Size = new System.Drawing.Size(205, 70);
            this.btn_tareas.TabIndex = 2;
            this.btn_tareas.Text = "TAREAS";
            this.btn_tareas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tareas.Click += new System.EventHandler(this.btn_tareas_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.panel_menu.Controls.Add(this.btn_nuevo);
            this.panel_menu.Controls.Add(this.btn_tareas);
            this.panel_menu.Controls.Add(this.btn_notas);
            this.panel_menu.Controls.Add(this.btn_inicio);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 49);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(205, 493);
            this.panel_menu.TabIndex = 1;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.White;
            this.btn_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_nuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nuevo.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.btn_nuevo.Location = new System.Drawing.Point(0, 210);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(205, 70);
            this.btn_nuevo.TabIndex = 3;
            this.btn_nuevo.Text = "NUEVA";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "HONO";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(868, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(828, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "__";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 542);
            this.Controls.Add(this.tap_control);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tap_control.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tap_control;
        private System.Windows.Forms.TabPage tab_inicio;
        private System.Windows.Forms.TabPage tap_nota;
        private System.Windows.Forms.Label btn_inicio;
        private System.Windows.Forms.Label btn_notas;
        private System.Windows.Forms.Label btn_tareas;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tap_tarea;
        private System.Windows.Forms.TabPage tap_agre_edit;
        private System.Windows.Forms.Label btn_nuevo;
    }
}

