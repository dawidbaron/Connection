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
    public partial class TraceRout : Form
    {

        private Ping ping = new Ping();
        private byte[] bufor;
        private int i = 1;



        public TraceRout()
        {
            InitializeComponent();
            ping.PingCompleted += new PingCompletedEventHandler(ping_PingCompleted);
        }

        void ping_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                listBox1.Items.Add(e.Error.Message);
                return;
            }
            if (e.Cancelled)
            {
                listBox1.Items.Add("Przerwano operację na życzenie użytkownika.");
            }
            else
            {
                if (e.Reply.Status == IPStatus.TtlExpired) listBox1.Items.Add("Skok " + i.ToString() + " host: " + e.Reply.Address.ToString());
                if (e.Reply.Status == IPStatus.TimedOut) listBox1.Items.Add("Skok " + i.ToString() + " host: * Upłynął limit czasu żądania.");
                if (e.Reply.Status == IPStatus.Success)
                {
                    listBox1.Items.Add("Skok " + i.ToString() + " host: " + e.Reply.Address.ToString());

                    return; button1.Enabled = true;
                }
                if (i++ < (int)numericUpDown1.Value)
                {
                    PingOptions opcjePing = new PingOptions(i, true);
                    ping.SendAsync(textBox1.Text, (int)numericUpDown2.Value, bufor, opcjePing, null);
                }
                else
                {
                    listBox1.Items.Add("Przekroczono maksymalną liczbę skoków (parametr TTL = " + numericUpDown1.Value.ToString());
                    button1.Enabled = true;


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ping.SendAsyncCancel();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            i = 1;
            PingOptions opcjePing = new PingOptions(i, true);
            string s = null;
            int wielkoscBuforu = 32;
            if (textBox1.Text != "" && textBox1.Text.Trim() != "")
            {
                //int wielkoscBuforu = 32;
                try
                {
                    wielkoscBuforu = System.Convert.ToInt16(comboBox1.Text);
                }
                catch
                {
                    wielkoscBuforu = 32;

                }
                comboBox1.Text = "32";
            }
            for (int j = 0; j < wielkoscBuforu; j++)
            {
                s += "a";
            }
            bufor = Encoding.ASCII.GetBytes(s);
            ping.SendAsync(textBox1.Text, (int)numericUpDown2.Value, bufor, opcjePing, null);
            listBox1.Items.Add("Rozpoczęcie badania drogi do " + textBox1.Text);
            button1.Enabled = false;
        }

        private void TraceRout_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
