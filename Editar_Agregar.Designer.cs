namespace HONO
{
    partial class Editar_Agregar
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.combo_estado = new System.Windows.Forms.ComboBox();
            this.fechaentrega = new System.Windows.Forms.DateTimePicker();
            this.labelentrega = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechainicio = new System.Windows.Forms.DateTimePicker();
            this.combo_nivel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnota = new System.Windows.Forms.RadioButton();
            this.rbtarea = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontenido = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.combo_estado);
            this.panel1.Controls.Add(this.fechaentrega);
            this.panel1.Controls.Add(this.labelentrega);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fechainicio);
            this.panel1.Controls.Add(this.combo_nivel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttitulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 188);
            this.panel1.TabIndex = 0;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Location = new System.Drawing.Point(493, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(190, 45);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // combo_estado
            // 
            this.combo_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.combo_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_estado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_estado.ForeColor = System.Drawing.Color.White;
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Items.AddRange(new object[] {
            "ESTADO",
            "PENDIENTE",
            "POSPUESTO",
            "TERMINADO",
            "SUSPENDIDO"});
            this.combo_estado.Location = new System.Drawing.Point(71, 144);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(136, 30);
            this.combo_estado.TabIndex = 13;
            // 
            // fechaentrega
            // 
            this.fechaentrega.CalendarForeColor = System.Drawing.Color.White;
            this.fechaentrega.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.fechaentrega.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.fechaentrega.CalendarTitleForeColor = System.Drawing.Color.White;
            this.fechaentrega.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.fechaentrega.CustomFormat = "22/01/2020";
            this.fechaentrega.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaentrega.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaentrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaentrega.Location = new System.Drawing.Point(299, 105);
            this.fechaentrega.Name = "fechaentrega";
            this.fechaentrega.Size = new System.Drawing.Size(113, 29);
            this.fechaentrega.TabIndex = 11;
            this.fechaentrega.Value = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            // 
            // labelentrega
            // 
            this.labelentrega.AutoSize = true;
            this.labelentrega.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelentrega.ForeColor = System.Drawing.Color.White;
            this.labelentrega.Location = new System.Drawing.Point(204, 105);
            this.labelentrega.Name = "labelentrega";
            this.labelentrega.Size = new System.Drawing.Size(89, 22);
            this.labelentrega.TabIndex = 10;
            this.labelentrega.Text = "ENTREGA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "INICIO:";
            // 
            // fechainicio
            // 
            this.fechainicio.CalendarForeColor = System.Drawing.Color.White;
            this.fechainicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.fechainicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.fechainicio.CalendarTitleForeColor = System.Drawing.Color.White;
            this.fechainicio.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.fechainicio.CustomFormat = "12/25/2020";
            this.fechainicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechainicio.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechainicio.Location = new System.Drawing.Point(71, 105);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(113, 29);
            this.fechainicio.TabIndex = 8;
            this.fechainicio.Value = new System.DateTime(2020, 6, 16, 0, 0, 0, 0);
            // 
            // combo_nivel
            // 
            this.combo_nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.combo_nivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_nivel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_nivel.ForeColor = System.Drawing.Color.White;
            this.combo_nivel.FormattingEnabled = true;
            this.combo_nivel.Items.AddRange(new object[] {
            "NIVEL",
            "ALTA",
            "MEDIA",
            "BAJA"});
            this.combo_nivel.Location = new System.Drawing.Point(276, 62);
            this.combo_nivel.Name = "combo_nivel";
            this.combo_nivel.Size = new System.Drawing.Size(136, 30);
            this.combo_nivel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnota);
            this.groupBox1.Controls.Add(this.rbtarea);
            this.groupBox1.Location = new System.Drawing.Point(71, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbnota
            // 
            this.rbnota.AutoSize = true;
            this.rbnota.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnota.ForeColor = System.Drawing.Color.White;
            this.rbnota.Location = new System.Drawing.Point(110, 20);
            this.rbnota.Name = "rbnota";
            this.rbnota.Size = new System.Drawing.Size(73, 26);
            this.rbnota.TabIndex = 1;
            this.rbnota.Text = "NOTA";
            this.rbnota.UseVisualStyleBackColor = true;
            this.rbnota.CheckedChanged += new System.EventHandler(this.rbnota_CheckedChanged);
            // 
            // rbtarea
            // 
            this.rbtarea.AutoSize = true;
            this.rbtarea.Checked = true;
            this.rbtarea.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtarea.ForeColor = System.Drawing.Color.White;
            this.rbtarea.Location = new System.Drawing.Point(7, 20);
            this.rbtarea.Name = "rbtarea";
            this.rbtarea.Size = new System.Drawing.Size(78, 26);
            this.rbtarea.TabIndex = 0;
            this.rbtarea.TabStop = true;
            this.rbtarea.Text = "TAREA";
            this.rbtarea.UseVisualStyleBackColor = true;
            this.rbtarea.CheckedChanged += new System.EventHandler(this.rbtarea_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "TIPO:";
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.txttitulo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.White;
            this.txttitulo.Location = new System.Drawing.Point(71, 7);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(341, 29);
            this.txttitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO:";
            // 
            // txtcontenido
            // 
            this.txtcontenido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtcontenido.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.txtcontenido.Location = new System.Drawing.Point(0, 185);
            this.txtcontenido.Multiline = true;
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(705, 308);
            this.txtcontenido.TabIndex = 1;
            // 
            // Editar_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.panel1);
            this.Name = "Editar_Agregar";
            this.Size = new System.Drawing.Size(705, 493);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcontenido;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_nivel;
        private System.Windows.Forms.RadioButton rbnota;
        private System.Windows.Forms.DateTimePicker fechainicio;
        private System.Windows.Forms.Label labelentrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaentrega;
        private System.Windows.Forms.ComboBox combo_estado;
        private System.Windows.Forms.Button btnguardar;
    }
}
