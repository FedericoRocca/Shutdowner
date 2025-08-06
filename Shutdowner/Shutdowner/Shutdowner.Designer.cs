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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shutdowner));
            this.label1 = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSegundos = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbForzar = new System.Windows.Forms.CheckBox();
            this.chbHibernar = new System.Windows.Forms.CheckBox();
            this.chbApagar = new System.Windows.Forms.CheckBox();
            this.chbRestart = new System.Windows.Forms.CheckBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.gpbRestante = new System.Windows.Forms.GroupBox();
            this.txbRestante = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tmrApagado = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gpbRestante.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(72, 95);
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(79, 20);
            this.nudDias.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(72, 69);
            this.nudHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(79, 20);
            this.nudHoras.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudHoras);
            this.groupBox1.Controls.Add(this.nudMinutos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudDias);
            this.groupBox1.Controls.Add(this.nudSegundos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temporizador";
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(72, 43);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(79, 20);
            this.nudMinutos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segundos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutos";
            // 
            // nudSegundos
            // 
            this.nudSegundos.Location = new System.Drawing.Point(72, 17);
            this.nudSegundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSegundos.Name = "nudSegundos";
            this.nudSegundos.Size = new System.Drawing.Size(79, 20);
            this.nudSegundos.TabIndex = 7;
            this.nudSegundos.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbForzar);
            this.groupBox2.Controls.Add(this.chbHibernar);
            this.groupBox2.Controls.Add(this.chbApagar);
            this.groupBox2.Controls.Add(this.chbRestart);
            this.groupBox2.Location = new System.Drawing.Point(177, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
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
            // chbApagar
            // 
            this.chbApagar.AutoSize = true;
            this.chbApagar.Checked = true;
            this.chbApagar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbApagar.Location = new System.Drawing.Point(7, 20);
            this.chbApagar.Name = "chbApagar";
            this.chbApagar.Size = new System.Drawing.Size(60, 17);
            this.chbApagar.TabIndex = 1;
            this.chbApagar.Text = "Apagar";
            this.chbApagar.UseVisualStyleBackColor = true;
            this.chbApagar.CheckedChanged += new System.EventHandler(this.chbApagar_CheckedChanged);
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
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(13, 142);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(244, 23);
            this.btnLanzar.TabIndex = 6;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // gpbRestante
            // 
            this.gpbRestante.Controls.Add(this.txbRestante);
            this.gpbRestante.Controls.Add(this.btnCancelar);
            this.gpbRestante.Location = new System.Drawing.Point(12, 171);
            this.gpbRestante.Name = "gpbRestante";
            this.gpbRestante.Size = new System.Drawing.Size(244, 85);
            this.gpbRestante.TabIndex = 7;
            this.gpbRestante.TabStop = false;
            this.gpbRestante.Text = "Tiempo restante";
            // 
            // txbRestante
            // 
            this.txbRestante.Enabled = false;
            this.txbRestante.Location = new System.Drawing.Point(7, 20);
            this.txbRestante.Name = "txbRestante";
            this.txbRestante.ReadOnly = true;
            this.txbRestante.Size = new System.Drawing.Size(230, 20);
            this.txbRestante.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(7, 47);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(230, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar apagado";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // tmrApagado
            // 
            this.tmrApagado.Interval = 1000;
            this.tmrApagado.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Shutdowner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.gpbRestante);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shutdowner";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Shutdowner";
            this.Load += new System.EventHandler(this.Shutdowner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbRestante.ResumeLayout(false);
            this.gpbRestante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudSegundos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbRestart;
        private System.Windows.Forms.CheckBox chbForzar;
        private System.Windows.Forms.CheckBox chbHibernar;
        private System.Windows.Forms.CheckBox chbApagar;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.GroupBox gpbRestante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer tmrApagado;
        private System.Windows.Forms.TextBox txbRestante;
    }
}

