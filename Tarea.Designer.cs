namespace HONO
{
    partial class Tarea
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
            this.label8 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcontenido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "CONTENIDO:";
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lista.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 36;
            this.lista.Location = new System.Drawing.Point(0, 57);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(447, 436);
            this.lista.TabIndex = 7;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 69);
            this.label2.TabIndex = 6;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(191)))), ((int)(((byte)(216)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.txtcontenido);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtestado);
            this.panel1.Controls.Add(this.txtnivel);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Controls.Add(this.txttitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(447, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 493);
            this.panel1.TabIndex = 5;
            // 
            // txtcontenido
            // 
            this.txtcontenido.BackColor = System.Drawing.Color.Transparent;
            this.txtcontenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtcontenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtcontenido.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontenido.ForeColor = System.Drawing.Color.White;
            this.txtcontenido.Location = new System.Drawing.Point(0, 205);
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(256, 186);
            this.txtcontenido.TabIndex = 8;
            this.txtcontenido.Text = "...";
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
            this.label9.Text = "VER TAREA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtestado
            // 
            this.txtestado.BackColor = System.Drawing.Color.Transparent;
            this.txtestado.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtestado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.ForeColor = System.Drawing.Color.White;
            this.txtestado.Location = new System.Drawing.Point(0, 134);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(256, 37);
            this.txtestado.TabIndex = 5;
            this.txtestado.Text = "ESTADO:";
            this.txtestado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnivel
            // 
            this.txtnivel.BackColor = System.Drawing.Color.Transparent;
            this.txtnivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtnivel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnivel.ForeColor = System.Drawing.Color.White;
            this.txtnivel.Location = new System.Drawing.Point(0, 106);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(256, 28);
            this.txtnivel.TabIndex = 4;
            this.txtnivel.Text = "NIVEL: ";
            this.txtnivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.Transparent;
            this.txtfecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtfecha.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.ForeColor = System.Drawing.Color.White;
            this.txtfecha.Location = new System.Drawing.Point(0, 53);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(256, 53);
            this.txtfecha.TabIndex = 2;
            this.txtfecha.Text = "FECHA: ";
            this.txtfecha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(104)))));
            this.txttitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txttitulo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.White;
            this.txttitulo.Location = new System.Drawing.Point(0, 0);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(256, 53);
            this.txttitulo.TabIndex = 1;
            this.txttitulo.Text = "TITULO DE TAREA";
            this.txttitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTA";
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
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Tarea";
            this.Size = new System.Drawing.Size(705, 493);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtestado;
        private System.Windows.Forms.Label txtnivel;
        private System.Windows.Forms.Label txtfecha;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtcontenido;
        private System.Windows.Forms.Label btn_eliminar;
    }
}
