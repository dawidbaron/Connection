using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_polaczenia
{
    public partial class SkanerPortow : Form
    {
        public SkanerPortow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short[] ListaPortow = { 20, 21, 22, 23, 25, 53, 70, 80, 109, 110, 119, 143, 161, 162, 443, 3389 };
            string host = textBox1.Text;
            listBox1.Items.Add("Skanowanie portów dla " + host);
            listBox1.Items.Add("To może potrwać chwilę ...");
            foreach (short port in ListaPortow)
            {
                this.Refresh();
                try
                {
                    TcpClient klient = new TcpClient(host, port);
                    listBox1.Items.Add("Port:" + port.ToString() + " jest otwarty");
                }
                catch
                {
                    listBox1.Items.Add("Port:" + port.ToString() + " jest zamknięty");
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
