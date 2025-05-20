namespace Shutdowner
{
    partial class Shutdowner
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbRestart = new System.Windows.Forms.CheckBox();
            this.chbApagar = new System.Windows.Forms.CheckBox();
            this.chbHibernar = new System.Windows.Forms.CheckBox();
            this.chbForzar = new System.Windows.Forms.CheckBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.gpbRestante = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpbRestante.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(67, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temporizador";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(67, 71);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutos";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(67, 97);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segundos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbForzar);
            this.groupBox2.Controls.Add(this.chbHibernar);
            this.groupBox2.Controls.Add(this.chbApagar);
            this.groupBox2.Controls.Add(this.chbRestart);
            this.groupBox2.Location = new System.Drawing.Point(177, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // chbRestart
            // 
            this.chbRestart.AutoSize = true;
            this.chbRestart.Location = new System.Drawing.Point(7, 43);
            this.chbRestart.Name = "chbRestart";
            this.chbRestart.Size = new System.Drawing.Size(67, 17);
            this.chbRestart.TabIndex = 0;
            this.chbRestart.Text = "Reiniciar";
            this.chbRestart.UseVisualStyleBackColor = true;
            this.chbRestart.CheckedChanged += new System.EventHandler(this.chbRestart_CheckedChanged);
            // 
            // chbApagar
            // 
            this.chbApagar.AutoSize = true;
            this.chbApagar.Location = new System.Drawing.Point(7, 20);
            this.chbApagar.Name = "chbApagar";
            this.chbApagar.Size = new System.Drawing.Size(60, 17);
            this.chbApagar.TabIndex = 1;
            this.chbApagar.Text = "Apagar";
            this.chbApagar.UseVisualStyleBackColor = true;
            this.chbApagar.CheckedChanged += new System.EventHandler(this.chbApagar_CheckedChanged);
            // 
            // chbHibernar
            // 
            this.chbHibernar.AutoSize = true;
            this.chbHibernar.Location = new System.Drawing.Point(7, 66);
            this.chbHibernar.Name = "chbHibernar";
            this.chbHibernar.Size = new System.Drawing.Size(66, 17);
            this.chbHibernar.TabIndex = 2;
            this.chbHibernar.Text = "Hibernar";
            this.chbHibernar.UseVisualStyleBackColor = true;
            this.chbHibernar.CheckedChanged += new System.EventHandler(this.chbHibernar_CheckedChanged);
            // 
            // chbForzar
            // 
            this.chbForzar.AutoSize = true;
            this.chbForzar.Checked = true;
            this.chbForzar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbForzar.Location = new System.Drawing.Point(7, 89);
            this.chbForzar.Name = "chbForzar";
            this.chbForzar.Size = new System.Drawing.Size(55, 17);
            this.chbForzar.TabIndex = 3;
            this.chbForzar.Text = "Forzar";
            this.chbForzar.UseVisualStyleBackColor = true;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(13, 148);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(244, 23);
            this.btnLanzar.TabIndex = 6;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // gpbRestante
            // 
            this.gpbRestante.Controls.Add(this.textBox1);
            this.gpbRestante.Location = new System.Drawing.Point(13, 178);
            this.gpbRestante.Name = "gpbRestante";
            this.gpbRestante.Size = new System.Drawing.Size(244, 47);
            this.gpbRestante.TabIndex = 7;
            this.gpbRestante.TabStop = false;
            this.gpbRestante.Text = "Tiempo restante";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Shutdowner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 235);
            this.Controls.Add(this.gpbRestante);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Shutdowner";
            this.Text = "Shutdowner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbRestante.ResumeLayout(false);
            this.gpbRestante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbRestart;
        private System.Windows.Forms.CheckBox chbForzar;
        private System.Windows.Forms.CheckBox chbHibernar;
        private System.Windows.Forms.CheckBox chbApagar;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.GroupBox gpbRestante;
        private System.Windows.Forms.TextBox textBox1;
    }
}

