using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatProject
{
    public partial class frmMain : Form
    {

        #region VARIABILI

        public TcpClient clientSocket; //uso di una libreria interna per gestire il socket del client
        public NetworkStream serverStream = default(NetworkStream); //Ogetto stream molto utile per gestire i dati inviati in una comunicazione asincrona
        
        string dati = ""; 
        Thread ctThread; 
        String name = null;

        //List<string> chatList = new List<string>();
        List<string> chat = new List<string>();

        #endregion



        public frmMain()
        {
            InitializeComponent();
        }

        public void setName(String title)
        {
            this.Text = title;
            name = title;
        }


        /*********************************FUNCTIONS *******************************************/
        private void btnInvia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMessage.Text != "")
                {
                    chat.Add("chat");
                    chat.Add(txtMessage.Text); //inserisco il testo del messaggio da  inviare e mi segno nella lista che voglio usare la modalità chat

                    byte[] bufferTx = ObjectToByteArray(chat);
                    serverStream.Write(bufferTx, 0, bufferTx.Length);
                    serverStream.Flush(); //impo
                    txtMessage.Text = "";
                    chat.Clear(); //rimuovo tutti gli elementi dalla lista
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: ", ex.Message);
                btnConnetti.Enabled = true;
            }
        }


        private void btnConnetti_Click(object sender, EventArgs e)
        {
            clientSocket = new TcpClient();
            try
            {
                //nella try catch in caso di non connessione con il server
                IPAddress ip;
                ip = clsAddress.findIP(txtServerIP.Text.ToString());
                clientSocket.Connect(ip, Convert.ToInt32(nudServerPort.Value));
                dati = "Connessione al server";
                messaggio(); //aggiorna la interfaccia grafica

                serverStream = clientSocket.GetStream();

                byte[] bufferTx = Encoding.ASCII.GetBytes(name + "$"); //carattere terminatore
                serverStream.Write(bufferTx, 0, bufferTx.Length);
                serverStream.Flush();
                btnConnetti.Enabled = false;


                ctThread = new Thread(prendiMessaggio);
                ctThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
                MessageBox.Show("Server non connesso");
            }
        }

        private void prendiMessaggio()
        {
            try
            {
                //bool ciclo = false;
                while (true)
                {
                    serverStream = clientSocket.GetStream(); //ottiene i dati 
                    byte[] bufferRx = new byte[10025];
                    serverStream.Read(bufferRx, 0, bufferRx.Length);
                    List<string> parts; //lista di appoggio usata per la conversione inversa da byte a oggetto 

                    if (!ControllaConnessione(clientSocket))
                    {
                        MessageBox.Show("Client disconnesso");
                        ctThread.Abort();
                        clientSocket.Close();
                        btnConnetti.Enabled = true;
                    }

                    parts = (List<string>)ByteArrayToObject(bufferRx);
                    switch (parts[0])
                    {
                        case "userList":
                            getUsers(parts);
                            break;

                        case "chat":
                            dati = "" + parts[1];
                            messaggio();
                            break;
                    }

                    if (dati[0]=='\0')
                    {
                        //problema di connessione, quindi riconnettere
                        dati = "Riconettere";
                        messaggio();

                        this.Invoke((MethodInvoker)delegate // To Write the Received data
                        {
                            btnConnetti.Enabled = true;
                        });

                        ctThread.Abort();
                        clientSocket.Close();
                        break;
                    }
                    chat.Clear();
                }
            }
            catch (Exception e)
            {
                ctThread.Abort();
                clientSocket.Close();
                btnConnetti.Enabled = true;
                Console.WriteLine("Errore: " + e.Message);
            }
        }

        private void getUsers(List<string> parts)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lstAmici.Items.Clear();
                for (int i = 1; i < parts.Count; i++)
                {
                    lstAmici.Items.Add(parts[i]);
                }
            });
        }

        private bool ControllaConnessione(TcpClient cl)
        {
            //manda una richiesta ogni tot secondi per capire se il client è connesso
            bool flag = false;
            try
            {
                bool part1 = cl.Client.Poll(10, SelectMode.SelectRead);
                bool part2 = (cl.Available == 0);
                if (part1 && part2)
                {
                    stato_connessione.BackColor = Color.Red;
                    this.Invoke((MethodInvoker)delegate
                    {
                        btnConnetti.Enabled = true;
                    });
                    flag = false;
                }
                else
                {
                    stato_connessione.BackColor = Color.Green;
                    flag = true;
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Errore: " + er.Message);
            }
            return flag;
        }

        private Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }



        #region HELPED FUNCTIONS
        public byte[] ObjectToByteArray(object obj)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        private void messaggio()
        {
            BeginInvoke((MethodInvoker)delegate () {
                txtMessageInviati.Text = txtMessageInviati.Text + Environment.NewLine + " >> " + dati;
            });
        }

        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sicuro di uscire? ", "USCITA", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    ctThread.Abort();
                    clientSocket.Close(); //chiusura del socket
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Errore: " + ex.Message);
                }

                Application.ExitThread(); //chiusura thread e applicazione
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMessageInviati.Text = ""; //pulisce il textbox
        }

        private void txtMessageInviati_TextChanged(object sender, EventArgs e)
        {
            txtMessageInviati.SelectionStart = txtMessageInviati.Text.Length; //impostiamo il selection alla lunghezza massima
            txtMessageInviati.ScrollToCaret(); //funzione che in automatico permette lo scrool
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
