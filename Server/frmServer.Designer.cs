namespace Server
{
    partial class frmServer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.lstClientAttivi = new System.Windows.Forms.ListBox();
            this.txtLogServer = new System.Windows.Forms.TextBox();
            this.btnAttiva = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInviaMess = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gpPort = new System.Windows.Forms.GroupBox();
            this.nupServerPort = new System.Windows.Forms.NumericUpDown();
            this.gpIp = new System.Windows.Forms.GroupBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.btnDisattivaClient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gpPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupServerPort)).BeginInit();
            this.gpIp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER CHAT";
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Location = new System.Drawing.Point(10, 30);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(175, 62);
            this.txtMessaggio.TabIndex = 16;
            // 
            // lstClientAttivi
            // 
            this.lstClientAttivi.FormattingEnabled = true;
            this.lstClientAttivi.ItemHeight = 16;
            this.lstClientAttivi.Location = new System.Drawing.Point(10, 21);
            this.lstClientAttivi.Name = "lstClientAttivi";
            this.lstClientAttivi.Size = new System.Drawing.Size(318, 100);
            this.lstClientAttivi.TabIndex = 12;
            // 
            // txtLogServer
            // 
            this.txtLogServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogServer.Location = new System.Drawing.Point(17, 41);
            this.txtLogServer.Multiline = true;
            this.txtLogServer.Name = "txtLogServer";
            this.txtLogServer.ReadOnly = true;
            this.txtLogServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogServer.Size = new System.Drawing.Size(402, 541);
            this.txtLogServer.TabIndex = 11;
            // 
            // btnAttiva
            // 
            this.btnAttiva.BackColor = System.Drawing.Color.Lime;
            this.btnAttiva.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAttiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttiva.ForeColor = System.Drawing.Color.Black;
            this.btnAttiva.Location = new System.Drawing.Point(19, 29);
            this.btnAttiva.Name = "btnAttiva";
            this.btnAttiva.Size = new System.Drawing.Size(136, 66);
            this.btnAttiva.TabIndex = 10;
            this.btnAttiva.Text = "ATTIVA SERVER";
            this.btnAttiva.UseVisualStyleBackColor = false;
            this.btnAttiva.Click += new System.EventHandler(this.btnAttiva_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLogServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 605);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOG DEL SERVER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnAttiva);
            this.groupBox2.Location = new System.Drawing.Point(465, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 115);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONNESSIONE SERVER";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(183, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 66);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "DISATTIVA SERVER";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisattivaClient);
            this.groupBox3.Controls.Add(this.lstClientAttivi);
            this.groupBox3.Location = new System.Drawing.Point(465, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 219);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLIENT ATTIVI";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInviaMess);
            this.groupBox4.Controls.Add(this.txtMessaggio);
            this.groupBox4.Location = new System.Drawing.Point(465, 581);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 119);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "INVIA MESSAGGIO A CLIENT";
            // 
            // btnInviaMess
            // 
            this.btnInviaMess.BackColor = System.Drawing.SystemColors.Control;
            this.btnInviaMess.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInviaMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInviaMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInviaMess.ForeColor = System.Drawing.Color.Black;
            this.btnInviaMess.Location = new System.Drawing.Point(200, 30);
            this.btnInviaMess.Name = "btnInviaMess";
            this.btnInviaMess.Size = new System.Drawing.Size(128, 66);
            this.btnInviaMess.TabIndex = 17;
            this.btnInviaMess.Text = "INVIA";
            this.btnInviaMess.UseVisualStyleBackColor = false;
            this.btnInviaMess.Click += new System.EventHandler(this.btnInviaMess_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gpPort);
            this.groupBox5.Controls.Add(this.gpIp);
            this.groupBox5.Location = new System.Drawing.Point(465, 216);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 115);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IP E PORTA";
            // 
            // gpPort
            // 
            this.gpPort.Controls.Add(this.nupServerPort);
            this.gpPort.Location = new System.Drawing.Point(178, 17);
            this.gpPort.Margin = new System.Windows.Forms.Padding(2);
            this.gpPort.Name = "gpPort";
            this.gpPort.Padding = new System.Windows.Forms.Padding(2);
            this.gpPort.Size = new System.Drawing.Size(150, 81);
            this.gpPort.TabIndex = 8;
            this.gpPort.TabStop = false;
            this.gpPort.Text = "PORT";
            // 
            // nupServerPort
            // 
            this.nupServerPort.Location = new System.Drawing.Point(5, 30);
            this.nupServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.nupServerPort.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.nupServerPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nupServerPort.Name = "nupServerPort";
            this.nupServerPort.Size = new System.Drawing.Size(129, 22);
            this.nupServerPort.TabIndex = 0;
            this.nupServerPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // gpIp
            // 
            this.gpIp.Controls.Add(this.cmbServer);
            this.gpIp.Location = new System.Drawing.Point(5, 17);
            this.gpIp.Margin = new System.Windows.Forms.Padding(2);
            this.gpIp.Name = "gpIp";
            this.gpIp.Padding = new System.Windows.Forms.Padding(2);
            this.gpIp.Size = new System.Drawing.Size(150, 81);
            this.gpIp.TabIndex = 7;
            this.gpIp.TabStop = false;
            this.gpIp.Text = "IP";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(5, 30);
            this.cmbServer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(141, 24);
            this.cmbServer.TabIndex = 0;
            // 
            // btnDisattivaClient
            // 
            this.btnDisattivaClient.BackColor = System.Drawing.Color.Red;
            this.btnDisattivaClient.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDisattivaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisattivaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisattivaClient.ForeColor = System.Drawing.Color.Black;
            this.btnDisattivaClient.Location = new System.Drawing.Point(101, 137);
            this.btnDisattivaClient.Name = "btnDisattivaClient";
            this.btnDisattivaClient.Size = new System.Drawing.Size(145, 66);
            this.btnDisattivaClient.TabIndex = 13;
            this.btnDisattivaClient.Text = "DISATTIVA CLIENT";
            this.btnDisattivaClient.UseVisualStyleBackColor = false;
            this.btnDisattivaClient.Click += new System.EventHandler(this.btnDisattivaClient_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 725);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmServer";
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.gpPort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupServerPort)).EndInit();
            this.gpIp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.ListBox lstClientAttivi;
        private System.Windows.Forms.TextBox txtLogServer;
        private System.Windows.Forms.Button btnAttiva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInviaMess;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox gpPort;
        private System.Windows.Forms.NumericUpDown nupServerPort;
        private System.Windows.Forms.GroupBox gpIp;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Button btnDisattivaClient;
    }
}

