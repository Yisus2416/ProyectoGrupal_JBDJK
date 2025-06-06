
namespace ProyectoGrupal_JBDJK
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gasto = new System.Windows.Forms.Button();
            this.Ingreso = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.razoningreso = new System.Windows.Forms.ComboBox();
            this.razongasto = new System.Windows.Forms.ComboBox();
            this.tablatotal = new System.Windows.Forms.ListBox();
            this.nota = new System.Windows.Forms.Button();
            this.notasfinales = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.montogasto = new System.Windows.Forms.TextBox();
            this.montoingreso = new System.Windows.Forms.TextBox();
            this.escribirnota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla gastos e ingresos";
            // 
            // Gasto
            // 
            this.Gasto.Location = new System.Drawing.Point(17, 66);
            this.Gasto.Name = "Gasto";
            this.Gasto.Size = new System.Drawing.Size(231, 61);
            this.Gasto.TabIndex = 1;
            this.Gasto.Text = "Gasto";
            this.Gasto.UseVisualStyleBackColor = true;
            this.Gasto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ingreso
            // 
            this.Ingreso.Location = new System.Drawing.Point(263, 66);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Size = new System.Drawing.Size(231, 61);
            this.Ingreso.TabIndex = 1;
            this.Ingreso.Text = "Ingreso";
            this.Ingreso.UseVisualStyleBackColor = true;
            this.Ingreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(524, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // razoningreso
            // 
            this.razoningreso.FormattingEnabled = true;
            this.razoningreso.Location = new System.Drawing.Point(263, 133);
            this.razoningreso.Name = "razoningreso";
            this.razoningreso.Size = new System.Drawing.Size(229, 21);
            this.razoningreso.TabIndex = 3;
            this.razoningreso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // razongasto
            // 
            this.razongasto.FormattingEnabled = true;
            this.razongasto.Location = new System.Drawing.Point(17, 133);
            this.razongasto.Name = "razongasto";
            this.razongasto.Size = new System.Drawing.Size(229, 21);
            this.razongasto.TabIndex = 3;
            this.razongasto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tablatotal
            // 
            this.tablatotal.FormattingEnabled = true;
            this.tablatotal.Location = new System.Drawing.Point(18, 212);
            this.tablatotal.Name = "tablatotal";
            this.tablatotal.Size = new System.Drawing.Size(476, 199);
            this.tablatotal.TabIndex = 4;
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(525, 211);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(247, 31);
            this.nota.TabIndex = 5;
            this.nota.Text = "agregar una nota";
            this.nota.UseVisualStyleBackColor = true;
            this.nota.Click += new System.EventHandler(this.nota_Click);
            // 
            // notasfinales
            // 
            this.notasfinales.FormattingEnabled = true;
            this.notasfinales.Location = new System.Drawing.Point(524, 298);
            this.notasfinales.Name = "notasfinales";
            this.notasfinales.Size = new System.Drawing.Size(246, 108);
            this.notasfinales.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // montogasto
            // 
            this.montogasto.Location = new System.Drawing.Point(67, 164);
            this.montogasto.Name = "montogasto";
            this.montogasto.Size = new System.Drawing.Size(100, 20);
            this.montogasto.TabIndex = 8;
            // 
            // montoingreso
            // 
            this.montoingreso.Location = new System.Drawing.Point(311, 167);
            this.montoingreso.Name = "montoingreso";
            this.montoingreso.Size = new System.Drawing.Size(100, 20);
            this.montoingreso.TabIndex = 8;
            // 
            // escribirnota
            // 
            this.escribirnota.Location = new System.Drawing.Point(525, 257);
            this.escribirnota.Name = "escribirnota";
            this.escribirnota.Size = new System.Drawing.Size(245, 20);
            this.escribirnota.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.escribirnota);
            this.Controls.Add(this.montoingreso);
            this.Controls.Add(this.montogasto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notasfinales);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.tablatotal);
            this.Controls.Add(this.razongasto);
            this.Controls.Add(this.razoningreso);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Ingreso);
            this.Controls.Add(this.Gasto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ProyetoGrupal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gasto;
        private System.Windows.Forms.Button Ingreso;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox razoningreso;
        private System.Windows.Forms.ComboBox razongasto;
        private System.Windows.Forms.ListBox tablatotal;
        private System.Windows.Forms.Button nota;
        private System.Windows.Forms.ListBox notasfinales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox montogasto;
        private System.Windows.Forms.TextBox montoingreso;
        private System.Windows.Forms.TextBox escribirnota;
    }
}

