using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_polaczenia
{
    public partial class KompletnaInformacjaNaTematPolaczen : Form
    {
        public KompletnaInformacjaNaTematPolaczen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            IPGlobalProperties wlasnosciIP = IPGlobalProperties.GetIPGlobalProperties();
            listBox1.Items.Add("Nazwa hosta: " + wlasnosciIP.HostName);
            listBox1.Items.Add("Nazwa domeny: " + wlasnosciIP.DomainName);
           
            int licznik = 0;
            foreach (NetworkInterface kartySieciowe in NetworkInterface.GetAllNetworkInterfaces())
            {


                listBox1.Items.Add("Karta #" + ++licznik + ": " + kartySieciowe.Id);
                listBox1.Items.Add("  Adres MAC: " + kartySieciowe.GetPhysicalAddress().ToString());
                listBox1.Items.Add("  Nazwa: " + kartySieciowe.Name);
                listBox1.Items.Add("  Opis: " + kartySieciowe.Description);
                listBox1.Items.Add("  Status: " + kartySieciowe.OperationalStatus);
                listBox1.Items.Add("  Szybkość: " + (kartySieciowe.Speed) / (double)1000000 + " Mb/s");
                listBox1.Items.Add("  Adresy bram sieciowych:");
                foreach (GatewayIPAddressInformation adresBramy in kartySieciowe.GetIPProperties().GatewayAddresses)
                    listBox1.Items.Add("    " + adresBramy.Address.ToString());
                listBox1.Items.Add("  Serwery DNS:"); foreach (IPAddress adresIP in kartySieciowe.GetIPProperties().DnsAddresses)
                    listBox1.Items.Add("    " + adresIP.ToString());
                listBox1.Items.Add("  Serwery DHCP:");
                foreach (IPAddress adresIP in kartySieciowe.GetIPProperties().DhcpServerAddresses)
                    listBox1.Items.Add("    " + adresIP.ToString());
                listBox1.Items.Add("  Serwery WINS:");
                foreach (IPAddress adresIP in kartySieciowe.GetIPProperties().WinsServersAddresses)
                    listBox1.Items.Add("    " + adresIP.ToString());
               
            }


            listBox1.Items.Add("  Aktualne połączenia TCP/IP typu klient:");
            foreach (TcpConnectionInformation polaczenieTCP in IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections())
            {
                listBox1.Items.Add("    Zdalny adres: " + polaczenieTCP.RemoteEndPoint.Address.ToString() + ":" + polaczenieTCP.RemoteEndPoint.Port);
                listBox1.Items.Add("    Status: " + polaczenieTCP.State.ToString());
            }
            listBox1.Items.Add("  Aktualne połączenia TCP/IP typu serwer:");
            foreach (IPEndPoint polaoczenieTCP in IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners())
                listBox1.Items.Add("    Zdalny adres: " + polaoczenieTCP.Address.ToString() + ":" + polaoczenieTCP.Port);
            listBox1.Items.Add("  Aktualne połączenia UDP:");
            foreach (IPEndPoint polaczenieUDP in IPGlobalProperties.GetIPGlobalProperties().GetActiveUdpListeners())
                listBox1.Items.Add("    Zdalny adres" + polaczenieUDP.Address.ToString() + ":" + polaczenieUDP.Port);



        }

        private void KompletnaInformacjaNaTematPolaczen_Load(object sender, EventArgs e)
        {

        }
    }
}
