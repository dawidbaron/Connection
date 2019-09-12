using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_polaczenia
{
    public partial class SkanerLokalnychPortow : Form
    {
        public SkanerLokalnychPortow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("Błędny zakres portów.");
                return;
            }
            listBox1.Items.Add("Rozpoczęcie skanowania ...");
            for (int i = (int)numericUpDown1.Value; i <= (int)numericUpDown2.Value; i++)
            {
                this.Refresh();
                label1.Text = "Aktualnie skanowany port: " + i;
                try
                {
                    TcpListener serwer = new TcpListener(IPAddress.Loopback, i);
                    serwer.Start(); serwer.Stop();
                }
                catch
                {
                    listBox1.Items.Add("Port: " + i + " jest zajęty");
                }
            }
            listBox1.Items.Add("Zakończenie skanowania");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SkanerLokalnychPortow_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
