namespace Projek_polaczenia
{
    partial class Projekt
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnPolaczenieTcpKlient = new System.Windows.Forms.Button();
            this.WyslijPing = new System.Windows.Forms.Button();
            this.SkanerLokalnychPortow = new System.Windows.Forms.Button();
            this.btnSkanerPortow = new System.Windows.Forms.Button();
            this.btnSprawdzIp = new System.Windows.Forms.Button();
            this.btnTraceRout = new System.Windows.Forms.Button();
            this.btnKompletnaInformacjaNaTematPolaczen = new System.Windows.Forms.Button();
            this.btnAsynchronicznyServerTcp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NetDetect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(21, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Polaczenie TCP Server";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPolaczenieTcpKlient
            // 
            this.btnPolaczenieTcpKlient.BackColor = System.Drawing.Color.LightBlue;
            this.btnPolaczenieTcpKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPolaczenieTcpKlient.Location = new System.Drawing.Point(21, 111);
            this.btnPolaczenieTcpKlient.Name = "btnPolaczenieTcpKlient";
            this.btnPolaczenieTcpKlient.Size = new System.Drawing.Size(200, 50);
            this.btnPolaczenieTcpKlient.TabIndex = 1;
            this.btnPolaczenieTcpKlient.Text = "Polaczenie TCP Klient";
            this.btnPolaczenieTcpKlient.UseVisualStyleBackColor = false;
            this.btnPolaczenieTcpKlient.Click += new System.EventHandler(this.btnPolaczenieTcpKlient_Click);
            // 
            // WyslijPing
            // 
            this.WyslijPing.BackColor = System.Drawing.Color.LightBlue;
            this.WyslijPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyslijPing.Location = new System.Drawing.Point(227, 55);
            this.WyslijPing.Name = "WyslijPing";
            this.WyslijPing.Size = new System.Drawing.Size(200, 50);
            this.WyslijPing.TabIndex = 2;
            this.WyslijPing.Text = "Pingowanie";
            this.WyslijPing.UseVisualStyleBackColor = false;
            this.WyslijPing.Click += new System.EventHandler(this.WyslijPing_Click);
            // 
            // SkanerLokalnychPortow
            // 
            this.SkanerLokalnychPortow.BackColor = System.Drawing.Color.LightBlue;
            this.SkanerLokalnychPortow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SkanerLokalnychPortow.Location = new System.Drawing.Point(227, 111);
            this.SkanerLokalnychPortow.Name = "SkanerLokalnychPortow";
            this.SkanerLokalnychPortow.Size = new System.Drawing.Size(200, 50);
            this.SkanerLokalnychPortow.TabIndex = 3;
            this.SkanerLokalnychPortow.Text = "Skanowanie lokalnych portow";
            this.SkanerLokalnychPortow.UseVisualStyleBackColor = false;
            this.SkanerLokalnychPortow.Click += new System.EventHandler(this.SkanerLokalnychPortow_Click);
            // 
            // btnSkanerPortow
            // 
            this.btnSkanerPortow.BackColor = System.Drawing.Color.LightBlue;
            this.btnSkanerPortow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkanerPortow.Location = new System.Drawing.Point(227, 167);
            this.btnSkanerPortow.Name = "btnSkanerPortow";
            this.btnSkanerPortow.Size = new System.Drawing.Size(200, 50);
            this.btnSkanerPortow.TabIndex = 4;
            this.btnSkanerPortow.Text = "Skanowanie portów";
            this.btnSkanerPortow.UseVisualStyleBackColor = false;
            this.btnSkanerPortow.Click += new System.EventHandler(this.btnSkanerPortow_Click);
            // 
            // btnSprawdzIp
            // 
            this.btnSprawdzIp.BackColor = System.Drawing.Color.LightBlue;
            this.btnSprawdzIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSprawdzIp.Location = new System.Drawing.Point(433, 55);
            this.btnSprawdzIp.Name = "btnSprawdzIp";
            this.btnSprawdzIp.Size = new System.Drawing.Size(200, 106);
            this.btnSprawdzIp.TabIndex = 5;
            this.btnSprawdzIp.Text = "Pokaz IP";
            this.btnSprawdzIp.UseVisualStyleBackColor = false;
            this.btnSprawdzIp.Click += new System.EventHandler(this.btnSprawdzIp_Click);
            // 
            // btnTraceRout
            // 
            this.btnTraceRout.BackColor = System.Drawing.Color.LightBlue;
            this.btnTraceRout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTraceRout.Location = new System.Drawing.Point(227, 223);
            this.btnTraceRout.Name = "btnTraceRout";
            this.btnTraceRout.Size = new System.Drawing.Size(200, 50);
            this.btnTraceRout.TabIndex = 6;
            this.btnTraceRout.Text = "TraceRout";
            this.btnTraceRout.UseVisualStyleBackColor = false;
            this.btnTraceRout.Click += new System.EventHandler(this.btnTraceRout_Click);
            // 
            // btnKompletnaInformacjaNaTematPolaczen
            // 
            this.btnKompletnaInformacjaNaTematPolaczen.BackColor = System.Drawing.Color.LightBlue;
            this.btnKompletnaInformacjaNaTematPolaczen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKompletnaInformacjaNaTematPolaczen.Location = new System.Drawing.Point(433, 167);
            this.btnKompletnaInformacjaNaTematPolaczen.Name = "btnKompletnaInformacjaNaTematPolaczen";
            this.btnKompletnaInformacjaNaTematPolaczen.Size = new System.Drawing.Size(200, 106);
            this.btnKompletnaInformacjaNaTematPolaczen.TabIndex = 7;
            this.btnKompletnaInformacjaNaTematPolaczen.Text = "Informacje o połączeniach";
            this.btnKompletnaInformacjaNaTematPolaczen.UseVisualStyleBackColor = false;
            this.btnKompletnaInformacjaNaTematPolaczen.Click += new System.EventHandler(this.btnKompletnaInformacjaNaTematPolaczen_Click);
            // 
            // btnAsynchronicznyServerTcp
            // 
            this.btnAsynchronicznyServerTcp.BackColor = System.Drawing.Color.LightBlue;
            this.btnAsynchronicznyServerTcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAsynchronicznyServerTcp.Location = new System.Drawing.Point(21, 167);
            this.btnAsynchronicznyServerTcp.Name = "btnAsynchronicznyServerTcp";
            this.btnAsynchronicznyServerTcp.Size = new System.Drawing.Size(200, 50);
            this.btnAsynchronicznyServerTcp.TabIndex = 8;
            this.btnAsynchronicznyServerTcp.Text = "Asynchroniczny serwer TCP";
            this.btnAsynchronicznyServerTcp.UseVisualStyleBackColor = false;
            this.btnAsynchronicznyServerTcp.Click += new System.EventHandler(this.btnAsynchronicznyServerTcp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wybierz co chcesz zrobić:";
            // 
            // NetDetect
            // 
            this.NetDetect.BackColor = System.Drawing.Color.LightBlue;
            this.NetDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NetDetect.Location = new System.Drawing.Point(21, 223);
            this.NetDetect.Name = "NetDetect";
            this.NetDetect.Size = new System.Drawing.Size(200, 50);
            this.NetDetect.TabIndex = 10;
            this.NetDetect.Text = "NetDetect";
            this.NetDetect.UseVisualStyleBackColor = false;
            this.NetDetect.Click += new System.EventHandler(this.button2_Click);
            // 
            // Projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(754, 310);
            this.Controls.Add(this.NetDetect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsynchronicznyServerTcp);
            this.Controls.Add(this.btnKompletnaInformacjaNaTematPolaczen);
            this.Controls.Add(this.btnTraceRout);
            this.Controls.Add(this.btnSprawdzIp);
            this.Controls.Add(this.btnSkanerPortow);
            this.Controls.Add(this.SkanerLokalnychPortow);
            this.Controls.Add(this.WyslijPing);
            this.Controls.Add(this.btnPolaczenieTcpKlient);
            this.Controls.Add(this.button1);
            this.Name = "Projekt";
            this.Text = "Projekt";
            this.Load += new System.EventHandler(this.Projekt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPolaczenieTcpKlient;
        private System.Windows.Forms.Button WyslijPing;
        private System.Windows.Forms.Button SkanerLokalnychPortow;
        private System.Windows.Forms.Button btnSkanerPortow;
        private System.Windows.Forms.Button btnSprawdzIp;
        private System.Windows.Forms.Button btnTraceRout;
        private System.Windows.Forms.Button btnKompletnaInformacjaNaTematPolaczen;
        private System.Windows.Forms.Button btnAsynchronicznyServerTcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NetDetect;
    }
}

