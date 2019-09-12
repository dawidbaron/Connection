using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_polaczenia
{
    public partial class PokarzIp : Form
    {
        public PokarzIp()
        {
            InitializeComponent();
        }

        private void PokarzIp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // listBox1.Items.Add("Port:" + port.ToString() + " jest otwarty");
        private void button1_Click(object sender, EventArgs e)
        {

            string NazwaHosta = Dns.GetHostName();
            IPHostEntry AdresyIP = Dns.GetHostEntry(NazwaHosta);
            listBox1.Items.Add("nazwa komputera: " + NazwaHosta);
            int licznik = 0;
            foreach (IPAddress AdresIP in AdresyIP.AddressList)
            {
                if (AdresIP.ToString() == "127.0.0.1")
                    listBox1.Items.Add("Komputer nie jest podłączony do sieci. Adres IP: " + AdresIP.ToString());
                else listBox1.Items.Add(" adres IP #" + ++licznik + ": " + AdresIP.ToString());
            }
            

        }
    }
}
