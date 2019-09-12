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
    public partial class PolaczenieTcpServer : Form
    {
        public PolaczenieTcpServer()
        {
            InitializeComponent();
        }
        private TcpListener serwer;
        private TcpClient klient;

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress adresIP;
            try { adresIP = IPAddress.Parse(textBox1.Text); }
            catch
            {
                MessageBox.Show("Błędny format adresu IP!", "Błąd");
                textBox1.Text = String.Empty;
                return;
            }
            int port = System.Convert.ToInt16(numericUpDown1.Value);
            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();
                klient = serwer.AcceptTcpClient();
                IPEndPoint IP = (IPEndPoint)klient.Client.RemoteEndPoint;
                listBox1.Items.Add("[" + IP.ToString() + "] :Nawiązano połączenie");
                klient.Close();
                serwer.Stop();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Błąd inicjacji serwera!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serwer.Stop();
            klient.Close();
            listBox1.Items.Add("Zakończono pracę serwera ...");
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PolaczenieTcpServer_Load(object sender, EventArgs e)
        {

        }
    }
}
