using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Shutdowner
{
    public partial class Shutdowner : Form
    {
        private string command = "shutdown";
        private string flags = "";
        int shutTimer = 0;

        public Shutdowner()
        {
            InitializeComponent();
            gpbRestante.Hide();
            this.Size = new Size(280, 212);
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                flags = "";

                if (rbApagar.Checked){ flags += "/s "; }
                if (rbRestart.Checked){ flags += "/r "; }
                if (rbHibernar.Checked){ flags += "/h "; }
                if (chbForzar.Checked) { flags += "/f "; }

                shutTimer =
                    ((int)nudSegundos.Value) +
                    (((int)nudMinutos.Value) * 60) +
                    (((int)nudHoras.Value) * 3600) +
                    (((int)nudDias.Value) * 86400);



                flags += shutTimer > 0 && !rbHibernar.Checked ? "/t " + shutTimer.ToString() : "";
                gpbRestante.Show();
                this.Size = new Size(280, 300);
                //Debug del comando de apagado
                //MessageBox.Show("shutdown " + flags);

                nudDias.Enabled = false;
                nudHoras.Enabled = false;
                nudMinutos.Enabled = false;
                nudSegundos.Enabled = false;

                Process.Start(command, flags);

                tmrApagado.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(280, 212);
                nudDias.Enabled = true;
                nudHoras.Enabled = true;
                nudMinutos.Enabled = true;
                nudSegundos.Enabled = true;
                gpbRestante.Hide();

                flags = "/a";
                tmrApagado.Stop();
                Process.Start(command, flags);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (nudSegundos.Value > 0)
                    nudSegundos.Value--;
                else if (nudMinutos.Value > 0)
                {
                    nudMinutos.Value--;
                    nudSegundos.Value += 59;
                }
                else if (nudHoras.Value > 0)
                {
                    nudHoras.Value--;
                    nudMinutos.Value += 59;
                }
                else if (nudDias.Value > 0)
                {
                    nudDias.Value--;
                    nudHoras.Value += 23;
                }
                else
                {
                    tmrApagado.Stop();
                    this.Size = new Size(280, 212);
                    gpbRestante.Hide();
                    nudDias.Enabled = true;
                    nudHoras.Enabled = true;
                    nudMinutos.Enabled = true;
                    nudSegundos.Enabled = true;
                }

                txbRestante.Text = String.Format(
                    "{0} dias, {1} horas, {2} minutos, {3} segundos",
                    nudDias.Value, nudHoras.Value, nudMinutos.Value, nudSegundos.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
        }

        private void Shutdowner_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
        }

        private void rbHibernar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbHibernar.Checked)
            {
                nudDias.Enabled = false;
                nudHoras.Enabled = false;
                nudMinutos.Enabled = false;
                nudSegundos.Enabled = false;
            }
            else
            {
                nudDias.Enabled = true;
                nudHoras.Enabled = true;
                nudMinutos.Enabled = true;
                nudSegundos.Enabled = true;
            }
        }
    }
}
