using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_polaczenia
{
    public partial class WyslijPing : Form
    {
        public WyslijPing()
        {
            InitializeComponent();
        }
        public String WyslijPingAsynchronicznie(string adres, int timeout, byte[] bufor, PingOptions opcje)
        {
            Ping ping = new Ping(); ping.PingCompleted += new PingCompletedEventHandler(KoniecPing);
            try
            { ping.SendAsync(adres, timeout, bufor, opcje, null); }
            catch (Exception ex)
            {
                listBox1.Items.Add("Błąd: " + adres + " " + ex.Message);
            }
            return adres;
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
                listBox1.Items.Add("Odpowiedź z " + odpowiedz.Address.ToString() + "bajtów=" + odpowiedz.Buffer.Length + " czas=" + odpowiedz.RoundtripTime + "ms TTL=" + odpowiedz.Options.Ttl);
            else listBox1.Items.Add("Błąd: Brak odpowiedzi z " + e.Reply.Address + ":" + odpowiedz.Status);
            ((IDisposable)(Ping)sender).Dispose();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || listBox2.Items.Count > 0)
            {
                PingOptions opcje = new PingOptions(); opcje.Ttl = (int)numericUpDown2.Value;
                opcje.DontFragment = true;
                string dane = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

                byte[] bufor = Encoding.ASCII.GetBytes(dane);
                int timeout = 120; if (textBox1.Text != "")
                {
                    for (int i = 0; i < (int)numericUpDown1.Value; i++)
                        listBox1.Items.Add(this.WyslijPingAsynchronicznie(textBox1.Text, timeout, bufor, opcje));
                    listBox1.Items.Add("----------------");
                }
                if (listBox2.Items.Count > 0)
                {
                    foreach (string host in listBox2.Items)
                    {
                        for (int i = 0; i < (int)numericUpDown1.Value; i++)
                            listBox1.Items.Add(this.WyslijPingAsynchronicznie(host, timeout, bufor, opcje));
                        listBox1.Items.Add("----------------");
                    }
                }
            }
            else { MessageBox.Show("Nie wprowadzono żadnych adresów", "Błąd"); }



        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
                if (textBox2.Text.Trim().Length > 0)
                { listBox2.Items.Add(textBox2.Text); textBox1.Clear(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void WyslijPing_Load(object sender, EventArgs e)
        {

        }
    }
}
