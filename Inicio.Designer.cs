namespace HONO
{
    partial class Inicio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_tareas = new System.Windows.Forms.RadioButton();
            this.rb_notas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_nivel = new System.Windows.Forms.RadioButton();
            this.rb_fecha_mod = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_notas = new System.Windows.Forms.ListBox();
            this.list_tareas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(171)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_generar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(444, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 493);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_todos);
            this.groupBox3.Controls.Add(this.rb_tareas);
            this.groupBox3.Controls.Add(this.rb_notas);
            this.groupBox3.Location = new System.Drawing.Point(0, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 91);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.BackColor = System.Drawing.Color.Transparent;
            this.rb_todos.Checked = true;
            this.rb_todos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.ForeColor = System.Drawing.Color.White;
            this.rb_todos.Location = new System.Drawing.Point(177, 33);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(84, 26);
            this.rb_todos.TabIndex = 2;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "TODOS";
            this.rb_todos.UseVisualStyleBackColor = false;
            // 
            // rb_tareas
            // 
            this.rb_tareas.AutoSize = true;
            this.rb_tareas.BackColor = System.Drawing.Color.Transparent;
            this.rb_tareas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tareas.ForeColor = System.Drawing.Color.White;
            this.rb_tareas.Location = new System.Drawing.Point(91, 33);
            this.rb_tareas.Name = "rb_tareas";
            this.rb_tareas.Size = new System.Drawing.Size(87, 26);
            this.rb_tareas.TabIndex = 1;
            this.rb_tareas.Text = "TAREAS";
            this.rb_tareas.UseVisualStyleBackColor = false;
            // 
            // rb_notas
            // 
            this.rb_notas.AutoSize = true;
            this.rb_notas.BackColor = System.Drawing.Color.Transparent;
            this.rb_notas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_notas.ForeColor = System.Drawing.Color.White;
            this.rb_notas.Location = new System.Drawing.Point(3, 33);
            this.rb_notas.Name = "rb_notas";
            this.rb_notas.Size = new System.Drawing.Size(82, 26);
            this.rb_notas.TabIndex = 0;
            this.rb_notas.Text = "NOTAS";
            this.rb_notas.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_nivel);
            this.groupBox2.Controls.Add(this.rb_fecha_mod);
            this.groupBox2.Controls.Add(this.rb_fecha);
            this.groupBox2.Location = new System.Drawing.Point(3, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 106);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // rb_nivel
            // 
            this.rb_nivel.AutoSize = true;
            this.rb_nivel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nivel.ForeColor = System.Drawing.Color.White;
            this.rb_nivel.Location = new System.Drawing.Point(7, 77);
            this.rb_nivel.Name = "rb_nivel";
            this.rb_nivel.Size = new System.Drawing.Size(77, 26);
            this.rb_nivel.TabIndex = 2;
            this.rb_nivel.Text = "NIVEL";
            this.rb_nivel.UseVisualStyleBackColor = true;
            // 
            // rb_fecha_mod
            // 
            this.rb_fecha_mod.AutoSize = true;
            this.rb_fecha_mod.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fecha_mod.ForeColor = System.Drawing.Color.White;
            this.rb_fecha_mod.Location = new System.Drawing.Point(7, 45);
            this.rb_fecha_mod.Name = "rb_fecha_mod";
            this.rb_fecha_mod.Size = new System.Drawing.Size(235, 26);
            this.rb_fecha_mod.TabIndex = 1;
            this.rb_fecha_mod.Text = "FECHA DE MODIFICACION";
            this.rb_fecha_mod.UseVisualStyleBackColor = true;
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Checked = true;
            this.rb_fecha.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fecha.ForeColor = System.Drawing.Color.White;
            this.rb_fecha.Location = new System.Drawing.Point(7, 13);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(190, 26);
            this.rb_fecha.TabIndex = 0;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "FECHA DE REGISTRO";
            this.rb_fecha.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 44);
            this.label6.TabIndex = 7;
            this.label6.Text = "ORDENAR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 44);
            this.label4.TabIndex = 2;
            this.label4.Text = "INCLUIR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(104)))));
            this.btn_generar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_generar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_generar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_generar.Location = new System.Drawing.Point(0, 0);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(261, 53);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "GENERAR LISTA";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(98, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA DE NOTAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(98, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "LISTA DE TAREAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_notas
            // 
            this.list_notas.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.list_notas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.list_notas.FormattingEnabled = true;
            this.list_notas.ItemHeight = 23;
            this.list_notas.Location = new System.Drawing.Point(34, 74);
            this.list_notas.Name = "list_notas";
            this.list_notas.Size = new System.Drawing.Size(382, 165);
            this.list_notas.TabIndex = 3;
            this.list_notas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.list_notas_KeyPress);
            this.list_notas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_notas_MouseDoubleClick);
            // 
            // list_tareas
            // 
            this.list_tareas.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.list_tareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.list_tareas.FormattingEnabled = true;
            this.list_tareas.ItemHeight = 23;
            this.list_tareas.Location = new System.Drawing.Point(34, 299);
            this.list_tareas.Name = "list_tareas";
            this.list_tareas.Size = new System.Drawing.Size(382, 165);
            this.list_tareas.TabIndex = 4;
            this.list_tareas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.list_tareas_KeyPress);
            this.list_tareas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_tareas_MouseDoubleClick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.list_tareas);
            this.Controls.Add(this.list_notas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(705, 493);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_generar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_notas;
        private System.Windows.Forms.ListBox list_tareas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_fecha_mod;
        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_nivel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_tareas;
        private System.Windows.Forms.RadioButton rb_notas;
    }
}
