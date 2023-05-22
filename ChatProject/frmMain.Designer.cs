namespace ChatProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPulisci = new System.Windows.Forms.Button();
            this.stato_connessione = new System.Windows.Forms.Panel();
            this.btnConnetti = new System.Windows.Forms.Button();
            this.btnInvia = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtMessageInviati = new System.Windows.Forms.TextBox();
            this.lstAmici = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudServerPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPulisci
            // 
            this.btnPulisci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPulisci.Location = new System.Drawing.Point(310, 322);
            this.btnPulisci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(72, 43);
            this.btnPulisci.TabIndex = 15;
            this.btnPulisci.Text = "PULISCI";
            this.btnPulisci.UseVisualStyleBackColor = false;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // stato_connessione
            // 
            this.stato_connessione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stato_connessione.Location = new System.Drawing.Point(178, 20);
            this.stato_connessione.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stato_connessione.Name = "stato_connessione";
            this.stato_connessione.Size = new System.Drawing.Size(12, 13);
            this.stato_connessione.TabIndex = 14;
            // 
            // btnConnetti
            // 
            this.btnConnetti.BackColor = System.Drawing.Color.Lime;
            this.btnConnetti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnetti.Location = new System.Drawing.Point(76, 297);
            this.btnConnetti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(148, 58);
            this.btnConnetti.TabIndex = 13;
            this.btnConnetti.Text = "CONNETTI CLIENT";
            this.btnConnetti.UseVisualStyleBackColor = false;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // btnInvia
            // 
            this.btnInvia.BackColor = System.Drawing.Color.Lime;
            this.btnInvia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInvia.Location = new System.Drawing.Point(236, 322);
            this.btnInvia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(70, 43);
            this.btnInvia.TabIndex = 10;
            this.btnInvia.Text = "INVIA";
            this.btnInvia.UseVisualStyleBackColor = false;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(14, 322);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(222, 44);
            this.txtMessage.TabIndex = 9;
            // 
            // txtMessageInviati
            // 
            this.txtMessageInviati.Location = new System.Drawing.Point(14, 46);
            this.txtMessageInviati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessageInviati.Multiline = true;
            this.txtMessageInviati.Name = "txtMessageInviati";
            this.txtMessageInviati.ReadOnly = true;
            this.txtMessageInviati.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageInviati.Size = new System.Drawing.Size(370, 264);
            this.txtMessageInviati.TabIndex = 8;
            this.txtMessageInviati.TextChanged += new System.EventHandler(this.txtMessageInviati_TextChanged);
            // 
            // lstAmici
            // 
            this.lstAmici.FormattingEnabled = true;
            this.lstAmici.Location = new System.Drawing.Point(76, 27);
            this.lstAmici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAmici.Name = "lstAmici";
            this.lstAmici.Size = new System.Drawing.Size(153, 160);
            this.lstAmici.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "STATO DELLA CONNESSIONE: ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPulisci);
            this.panel1.Controls.Add(this.txtMessageInviati);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.btnInvia);
            this.panel1.Location = new System.Drawing.Point(9, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 377);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "CHAT DI GRUPPO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstAmici);
            this.groupBox1.Controls.Add(this.btnConnetti);
            this.groupBox1.Location = new System.Drawing.Point(432, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(298, 377);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AMICI CONNESSI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudServerPort);
            this.groupBox2.Location = new System.Drawing.Point(184, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(101, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PORT";
            // 
            // nudServerPort
            // 
            this.nudServerPort.Location = new System.Drawing.Point(4, 21);
            this.nudServerPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudServerPort.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.nudServerPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudServerPort.Name = "nudServerPort";
            this.nudServerPort.Size = new System.Drawing.Size(90, 20);
            this.nudServerPort.TabIndex = 0;
            this.nudServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudServerPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtServerIP);
            this.groupBox3.Location = new System.Drawing.Point(15, 237);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(165, 55);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(6, 21);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(156, 20);
            this.txtServerIP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONNESSIONE AL SERVER";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stato_connessione);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Panel stato_connessione;
        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtMessageInviati;
        private System.Windows.Forms.ListBox lstAmici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudServerPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtServerIP;
    }
}