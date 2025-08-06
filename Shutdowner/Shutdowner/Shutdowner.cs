using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbApagar.Checked){ flags += "/s "; }
                if (chbRestart.Checked){ flags += "/r "; }
                if (chbHibernar.Checked){ flags += "/h "; }
                if (chbForzar.Checked) { flags += "/f "; }

                shutTimer =
                    ((int)nudSegundos.Value) +
                    (((int)nudMinutos.Value) * 60) +
                    (((int)nudHoras.Value) * 3600) +
                    (((int)nudDias.Value) * 86400);



                flags += "/t " + shutTimer.ToString();
                gpbRestante.Show();
                this.Size = new Size(280, 300);
                //Debug del comando de apagado
                //MessageBox.Show("shutdown " + flags);
                Process.Start(command, flags);
                flags = "";

                tmrApagado.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chbApagar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbApagar.Checked)
                {
                    chbRestart.Checked = false;
                    chbHibernar.Checked = false;
                }
                checkByDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chbRestart_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbRestart.Checked)
                {
                    chbApagar.Checked = false;
                    chbHibernar.Checked = false;
                }
                checkByDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chbHibernar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbHibernar.Checked)
                {
                    chbApagar.Checked = false;
                    chbRestart.Checked = false;
                }
                checkByDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(280, 212);
                flags = "/a";
                tmrApagado.Stop();
                Process.Start(command, flags);
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void checkByDefault()
        {
            try
            {
                if( !chbApagar.Checked && !chbRestart.Checked && !chbHibernar.Checked)
                {
                    chbApagar.Checked |= true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (nudSegundos.Value > 0) nudSegundos.Value--;
                if (nudSegundos.Value <= 1)
                {
                    if(nudMinutos.Value > 0) nudMinutos.Value--;
                    if (nudMinutos.Value <= 0)
                    {
                        if (nudHoras.Value > 0) nudHoras.Value--;
                        if (nudHoras.Value <= 0)
                        {
                            if (nudDias.Value > 0) nudDias.Value--;
                        }
                    }
                }

                txbRestante.Text = String.Format(
                    "{0} dias, {1} horas, {2} minutos, {3} segundos",
                    nudDias.Value, nudHoras.Value, nudMinutos.Value, nudSegundos.Value);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Shutdowner_Load(object sender, EventArgs e)
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
