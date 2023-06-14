namespace HONO
{
    partial class Nota
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_contenido = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nivel = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.btn_eliminar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_contenido);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_nivel);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.txt_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(447, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 493);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(104)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 50);
            this.label9.TabIndex = 7;
            this.label9.Text = "VER NOTA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_contenido
            // 
            this.txt_contenido.BackColor = System.Drawing.Color.Transparent;
            this.txt_contenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_contenido.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contenido.ForeColor = System.Drawing.Color.White;
            this.txt_contenido.Location = new System.Drawing.Point(0, 179);
            this.txt_contenido.Name = "txt_contenido";
            this.txt_contenido.Size = new System.Drawing.Size(256, 212);
            this.txt_contenido.TabIndex = 6;
            this.txt_contenido.Text = "....";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 40);
            this.label7.TabIndex = 5;
            this.label7.Text = "CONTENIDO: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nivel
            // 
            this.txt_nivel.BackColor = System.Drawing.Color.Transparent;
            this.txt_nivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nivel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nivel.ForeColor = System.Drawing.Color.White;
            this.txt_nivel.Location = new System.Drawing.Point(0, 106);
            this.txt_nivel.Name = "txt_nivel";
            this.txt_nivel.Size = new System.Drawing.Size(256, 33);
            this.txt_nivel.TabIndex = 4;
            this.txt_nivel.Text = "NIVEL: ";
            this.txt_nivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.Transparent;
            this.txt_fecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_fecha.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.ForeColor = System.Drawing.Color.White;
            this.txt_fecha.Location = new System.Drawing.Point(0, 53);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(256, 53);
            this.txt_fecha.TabIndex = 2;
            this.txt_fecha.Text = "FECHA: ";
            this.txt_fecha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_titulo
            // 
            this.txt_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(104)))));
            this.txt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titulo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.ForeColor = System.Drawing.Color.White;
            this.txt_titulo.Location = new System.Drawing.Point(0, 0);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(256, 53);
            this.txt_titulo.TabIndex = 1;
            this.txt_titulo.Text = "TITULO DE NOTA";
            this.txt_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lista.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 36;
            this.lista.Items.AddRange(new object[] {
            "nota 1",
            "nota 2",
            "nota 3",
            "nota 4",
            "nota 5",
            "nota 6",
            "nota 7",
            "nota 8"});
            this.lista.Location = new System.Drawing.Point(0, 57);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(447, 436);
            this.lista.TabIndex = 3;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_eliminar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(0, 391);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(256, 50);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Nota";
            this.Size = new System.Drawing.Size(705, 493);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_titulo;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label txt_nivel;
        private System.Windows.Forms.Label txt_fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_contenido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label btn_eliminar;
    }
}
