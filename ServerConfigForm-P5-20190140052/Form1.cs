using ServiceMtk_P1_20190140052;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_20190140052
{
    public partial class Form1 : Form
    {


        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            buttonON.Enabled = true;
            buttonOFF.Enabled = false;
            Host.Close();
            labelket1.Text = "Klik ON untuk Menjalankan Server";
            labelOnOff.Text = "Server OFF";
        }

        private void labelket1_Click(object sender, EventArgs e)
        {

        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOff.Text = "Server ON";
            labelket1.Text = "klik OFF untuk mematikan Server";
            Host.Open();
            buttonON.Enabled = false;
            buttonOFF.Enabled = true;
        }
    }
}
