using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shutdowner
{
    public partial class Shutdowner : Form
    {
        private string command = "shutdown ";
        private string flags = "";
        int shutTimer = 0;

        public Shutdowner()
        {
            InitializeComponent();
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
                    flags += "/s ";
                }
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
                    flags += "/r ";
                }
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
                    flags += "/h ";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
