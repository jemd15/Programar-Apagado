namespace ProgramarApagado
{
    partial class ventanaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbHibernar = new System.Windows.Forms.RadioButton();
            this.rbApagar = new System.Windows.Forms.RadioButton();
            this.segundos = new System.Windows.Forms.NumericUpDown();
            this.minutos = new System.Windows.Forms.NumericUpDown();
            this.horas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonApagar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbHibernar);
            this.panel1.Controls.Add(this.rbApagar);
            this.panel1.Controls.Add(this.segundos);
            this.panel1.Controls.Add(this.minutos);
            this.panel1.Controls.Add(this.horas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.botonApagar);
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 132);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbHibernar
            // 
            this.rbHibernar.AutoSize = true;
            this.rbHibernar.Location = new System.Drawing.Point(109, 16);
            this.rbHibernar.Name = "rbHibernar";
            this.rbHibernar.Size = new System.Drawing.Size(65, 17);
            this.rbHibernar.TabIndex = 10;
            this.rbHibernar.Text = "Hibernar";
            this.rbHibernar.UseVisualStyleBackColor = true;
            // 
            // rbApagar
            // 
            this.rbApagar.AutoSize = true;
            this.rbApagar.Checked = true;
            this.rbApagar.Location = new System.Drawing.Point(15, 16);
            this.rbApagar.Name = "rbApagar";
            this.rbApagar.Size = new System.Drawing.Size(59, 17);
            this.rbApagar.TabIndex = 9;
            this.rbApagar.TabStop = true;
            this.rbApagar.Text = "Apagar";
            this.rbApagar.UseVisualStyleBackColor = true;
            this.rbApagar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // segundos
            // 
            this.segundos.Location = new System.Drawing.Point(208, 59);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(48, 20);
            this.segundos.TabIndex = 3;
            this.segundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.segundos.ValueChanged += new System.EventHandler(this.valorCambiado);
            // 
            // minutos
            // 
            this.minutos.Location = new System.Drawing.Point(142, 59);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(48, 20);
            this.minutos.TabIndex = 2;
            this.minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutos.ValueChanged += new System.EventHandler(this.valorCambiado);
            // 
            // horas
            // 
            this.horas.Location = new System.Drawing.Point(76, 59);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(48, 20);
            this.horas.TabIndex = 1;
            this.horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.horas.ValueChanged += new System.EventHandler(this.valorCambiado);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Horas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonApagar
            // 
            this.botonApagar.Location = new System.Drawing.Point(99, 98);
            this.botonApagar.Name = "botonApagar";
            this.botonApagar.Size = new System.Drawing.Size(75, 23);
            this.botonApagar.TabIndex = 4;
            this.botonApagar.Text = "Apagar";
            this.botonApagar.UseVisualStyleBackColor = true;
            this.botonApagar.Click += new System.EventHandler(this.botonApagar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(183, 98);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 5;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 132);
            this.Controls.Add(this.panel1);
            this.Name = "ventanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programar Apagado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonApagar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown segundos;
        private System.Windows.Forms.NumericUpDown minutos;
        private System.Windows.Forms.NumericUpDown horas;
        private System.Windows.Forms.RadioButton rbHibernar;
        private System.Windows.Forms.RadioButton rbApagar;
    }
}

