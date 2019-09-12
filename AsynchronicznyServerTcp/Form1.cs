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

namespace AsynchronicznyServerTcp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private TcpListener serwer;
        private TcpClient klient;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Oczekiwanie na połączenie ...");
            IPAddress adresIP;
            try
            {
                adresIP = IPAddress.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP!", "Błąd");
                textBox1.Text = String.Empty; return;
            }
            int port = System.Convert.ToInt16(numericUpDown1.Value);
            try
            {
                serwer = new TcpListener(adresIP, port); serwer.Start();
                serwer.BeginAcceptTcpClient(new AsyncCallback(AcceptTcpClientCallback), serwer);
            }
            catch (Exception ex) { listBox1.Items.Add("Błąd: " + ex.Message); }
        }
        private void AcceptTcpClientCallback(IAsyncResult asyncResult)
        {
            TcpListener s = (TcpListener)asyncResult.AsyncState; klient = s.EndAcceptTcpClient(asyncResult); SetListBoxText("Połączenie się powiodło!");
            klient.Close(); serwer.Stop();
        }

        private delegate void SetTextCallBack(string tekst);
        private void SetListBoxText(string tekst)
        {
            if (listBox1.InvokeRequired)
            {
                SetTextCallBack f = new SetTextCallBack(SetListBoxText);
                this.Invoke(f, new object[] { tekst });
            }
            else
            {
                listBox1.Items.Add(tekst);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serwer != null) serwer.Stop();
        }





    }
}
