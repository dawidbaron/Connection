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
using System.Net.NetworkInformation;

namespace Projek_polaczenia
{
    public partial class NetDetect : Form
    {
        public NetDetect()
        {
            InitializeComponent();
        }
        public void WyslijPingAsynchronicznie(IPAddress adres, int timeout, byte[] bufor,PingOptions opcje)
        {
            Ping ping = new Ping();
            ping.PingCompleted += new PingCompletedEventHandler(KoniecPing);
            try
            {
                ping.SendAsync(adres, timeout, bufor, opcje, null);
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Błąd: " + adres + " " + ex.Message);
            }
        }
        public void KoniecPing(object sender, PingCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error != null)
            {
                listBox1.Items.Add("Błąd: Operacja przerwana bądź nieprawidłowy adres ");
                ((IDisposable)(Ping)sender).Dispose();
                return;
            }
            PingReply odpowiedz = e.Reply;
            if (odpowiedz.Status == IPStatus.Success)
                listBox1.Items.Add("Odpowiedź z " + odpowiedz.Address.ToString() + "bajtów = " + odpowiedz.Buffer.Length + " czas = " + odpowiedz.RoundtripTime + "ms TTL=" + odpowiedz.Options.Ttl);
            else
                listBox1.Items.Add("Błąd: Brak odpowiedzi z " + e.Reply.Address + ": " + odpowiedz.Status);
            ((IDisposable)(Ping)sender).Dispose();
        }

        private void NetDetect_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress poczatekIP = null;
            IPAddress koniecIP = null;
            try
            {
                poczatekIP = IPAddress.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Błędnie wprowadzony startowy adres IP", "Błąd");
                textBox1.Text = string.Empty;
                return;
            }
            try
            {
                koniecIP = IPAddress.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Błędnie wprowadzony końcowy adres IP", "Błąd");
                textBox2.Text = string.Empty;
                return;
            }
            byte[] start = poczatekIP.GetAddressBytes();
            byte[] end = koniecIP.GetAddressBytes();
            PingOptions opcje = new PingOptions();
            opcje.Ttl = 128;
            opcje.DontFragment = true;
            string dane = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] bufor = Encoding.ASCII.GetBytes(dane);
            int timeout = 120;
            for (byte oktet1 = start[0]; oktet1 <= end[0]; oktet1++)
                for (byte oktet2 = start[1]; oktet2 <= end[1]; oktet2++)
                    for (byte oktet3 = start[2]; oktet3 <= end[2]; oktet3++)
                        for (byte oktet4 = start[3]; oktet4 <= end[3]; oktet4++)
                        {
                            IPAddress adres = new IPAddress(new byte[] { oktet1,oktet2, oktet3, oktet4 });
                            WyslijPingAsynchronicznie(adres, timeout, bufor, opcje);                          
                        }
        }
    }
}
