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
    public partial class Projekt : Form
    {
        public Projekt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PolaczenieTcpServer polaczenieTcpServer = new PolaczenieTcpServer();
            polaczenieTcpServer.Show();

        }

        private void btnPolaczenieTcpKlient_Click(object sender, EventArgs e)
        {
            PolaczenieTcpKlient polaczenieTcpKlient = new PolaczenieTcpKlient();
            polaczenieTcpKlient.Show();


        }

        private void WyslijPing_Click(object sender, EventArgs e)
        {
            WyslijPing wyslijPing = new WyslijPing();
            wyslijPing.Show();
        }

        private void SkanerLokalnychPortow_Click(object sender, EventArgs e)
        {
            SkanerLokalnychPortow skanerLokalnychPortow = new SkanerLokalnychPortow();
            skanerLokalnychPortow.Show();

        }

        private void btnSkanerPortow_Click(object sender, EventArgs e)
        {
            SkanerPortow skanerPortow = new SkanerPortow();
            skanerPortow.Show();

        }

        private void btnSprawdzIp_Click(object sender, EventArgs e)
        {
            PokarzIp pokarzIp = new PokarzIp();
            pokarzIp.Show();
           

        }

        private void btnTraceRout_Click(object sender, EventArgs e)
        {
            TraceRout traceRout = new TraceRout();
            traceRout.Show();
        }

        private void btnKompletnaInformacjaNaTematPolaczen_Click(object sender, EventArgs e)
        {
            KompletnaInformacjaNaTematPolaczen kompletnaInformacjaNaTematPolaczen = new KompletnaInformacjaNaTematPolaczen();
            kompletnaInformacjaNaTematPolaczen.Show();
        }

        private void btnAsynchronicznyServerTcp_Click(object sender, EventArgs e)
        {
            AsynchronicznyServerTcp asynchronicznyServerTcp = new AsynchronicznyServerTcp();
            asynchronicznyServerTcp.Show();
        }

        private void Projekt_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetDetect netDetect = new NetDetect();
            netDetect.Show();
        }
    }
}
