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

namespace Server
{
    public partial class frmServer : Form
    {

        #region VARIABILI
        TcpListener listener; //utiulizzo di questo oggetto che permette di attivare un listenere TCP da usare in una comunicazione asincrona
        TcpClient client;
        Dictionary<string, TcpClient> clientList = new Dictionary<string, TcpClient>();
        CancellationTokenSource cancellation = new CancellationTokenSource(); //importante siccome è un oggetto che usa un token modificabile
        List<string> chat = new List<string>();
        #endregion


        public frmServer()
        {
            InitializeComponent();
        }



        private void frmServer_Load(object sender, EventArgs e)
        {
            clsAddress.findIP();
            cmbServer.DataSource = clsAddress.ipList;

            btnAttiva.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnAttiva_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            ip = clsAddress.ipList[cmbServer.SelectedIndex];

            listener = new TcpListener(ip, Convert.ToInt32(nupServerPort.Value));
            cancellation = new CancellationTokenSource(); //va a cancellare il token quando si va a restartare il server
            avviaServerAsync();
            btnAttiva.Enabled = false;
            btnStop.Enabled = true;
        }

        private async void avviaServerAsync()
        {
            listener.Start();
            aggiornaGrafica("Attivazione del server alle: " + listener.LocalEndpoint);
            aggiornaGrafica("Aspetto collegamento dei client: ");
            try
            {
                int cnt = 0;
                while (true)
                {
                    cnt++;
                    client = await Task.Run(() => listener.AcceptTcpClientAsync(), cancellation.Token);
                    //funzione di run che permette di startare in maniera asincrona (await e async) il listenere
                    // parametri passati tramite un arrow functions  () =>

                    //Lettura del nome (client) inserito precedentemente nel form login
                    byte[] name = new byte[50];
                    NetworkStream stre = client.GetStream(); //ottiene tutti i dati nello stream
                    stre.Read(name, 0, name.Length);
                    String username = Encoding.ASCII.GetString(name); // conversione obbligatoria a stringa
                    username = username.Substring(0, username.IndexOf("$")); //("$") ==> terminatore

                    //aggiungo ad un dictionary che gestisce la lista di client
                    clientList.Add(username, client);
                    lstClientAttivi.Items.Add(username);
                    aggiornaGrafica("Connessione con l'utente: " + username + " - " + client.Client.RemoteEndPoint);
                    broadcastTraClient(username + " Accede al gruppo ", username, false);

                    await Task.Delay(1000).ContinueWith(task => invioListaUtenti()); //funzioen completata con ritardo di 1 secondo
                    //dove invio la lista dei client

                    Thread clientThread = new Thread(ServerReceive);
                    object[] objVect = new object[2];
                    objVect[0] = client;
                    objVect[1] = username;
                    clientThread.Start(objVect);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
                listener.Stop();
            }
        }

        private void ServerReceive(object vect)
        {
            TcpClient client = (TcpClient)(vect as object[])[0];
            string username = (string)(vect as object[])[1];

            byte[] data = new byte[1000];
            string text = "";
            //bool cicla = false;
            while (true)
            {
                try
                {
                    NetworkStream stream = client.GetStream(); //ottengo lo stream di chi si connette
                    stream.Read(data, 0, data.Length); //leggo i dati
                    List<string> parts = (List<string>)ByteArrayToObject(data);

                    switch (parts[0])
                    {
                        case "chat":
                            this.Invoke((MethodInvoker)delegate // To Write the Received data
                            {
                                txtLogServer.Text += username + ": " + parts[1] + Environment.NewLine;
                            });
                            broadcastTraClient(parts[1], username, true);
                            break;

                        case "pChat":
                            privateChat(parts);
                            break;
                    }

                    parts.Clear();
                }
                catch (Exception r)
                {
                    aggiornaGrafica("Disconnessione del client: " + username);
                    broadcastTraClient("Ci ha abbandonato: " + username + "$", username, false);
                    clientList.Remove(username);

                    this.Invoke((MethodInvoker)delegate
                    {
                        lstClientAttivi.Items.Remove(username); //rimuoviamo anche dalla listbox dei client attivi
                    });
                    invioListaUtenti();
                    break;
                }
            }
        }
    

        private void privateChat(List<string> text)
        {
            try
            {
                //chat privata tra il server e il client
                byte[] byData = ObjectToByteArray(text);
                TcpClient socketClient = null;
                socketClient = (TcpClient)clientList.FirstOrDefault(x => x.Key == text[1]).Value; //funzione che trova nel dictioanry il nome del client a cui scrivere
                NetworkStream stm = socketClient.GetStream();
                stm.Write(byData, 0, byData.Length);
                stm.Flush();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }
        }

        private Object ByteArrayToObject(byte[] data)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(data, 0, data.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

        private void invioListaUtenti()
        {
            try
            {
                byte[] userList = new byte[1024];
                string[] clist = lstClientAttivi.Items.OfType<string>().ToArray(); //crea un vettore dei client attivi
                List<string> users = new List<string>();

                users.Add("userList");
                foreach (String name in clist)
                {
                    users.Add(name);
                }
                
                userList = ObjectToByteArray(users);

                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    broadcastStream.Write(userList, 0, userList.Length);
                    broadcastStream.Flush();
                    users.Clear();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }
        }

        private void broadcastTraClient(string msg, string username, bool flag)
        {
            try
            {
                //catch per qualsiasi errore di broadcast interno
                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    NetworkStream broadcastStream = broadcastSocket.GetStream();
                    byte[] broadcastBytes = null;

                    if (flag)
                    {
                        chat.Add("chat");
                        chat.Add(username + " scrive: " + msg);
                        broadcastBytes = ObjectToByteArray(chat);
                    }
                    else
                    {
                        chat.Add("chat");
                        chat.Add(msg);
                        broadcastBytes = ObjectToByteArray(chat);
                    }
                    broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                    broadcastStream.Flush();
                    chat.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: "+ex.Message);
            }
        }

        private byte[] ObjectToByteArray(object chat)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, chat);
                return ms.ToArray();
            }
        }

        private void aggiornaGrafica(string msg)
        {
            BeginInvoke((MethodInvoker)delegate () {
                txtLogServer.Text += ">>>: " + msg + Environment.NewLine;
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                listener.Stop();
                aggiornaGrafica("Server disattivato");
                foreach (var Item in clientList)
                {
                    TcpClient broadcastSocket;
                    broadcastSocket = (TcpClient)Item.Value;
                    broadcastSocket.Close();
                }
                btnAttiva.Enabled = true;
                btnStop.Enabled = false;
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }
        }

        private void btnInviaMess_Click(object sender, EventArgs e)
        {
            if (lstClientAttivi.SelectedIndex != -1)
            {
                String clientName = lstClientAttivi.GetItemText(lstClientAttivi.SelectedItem);

                chat.Clear();
                chat.Add("chat");
                chat.Add("Admin : " + txtMessaggio.Text);

                byte[] byData = ObjectToByteArray(chat);
                TcpClient clientSocket = null;
                clientSocket = (TcpClient)clientList.FirstOrDefault(x => x.Key == clientName).Value; //trova il nome del client nel dict

                NetworkStream stm = clientSocket.GetStream();
                stm.Write(byData, 0, byData.Length);
                stm.Flush();
                chat.Clear();
            }
        }

        private void btnDisattivaClient_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient workerSocket = null;

                String clientName = lstClientAttivi.GetItemText(lstClientAttivi.SelectedItem);
                workerSocket = (TcpClient)clientList.FirstOrDefault(x => x.Key == clientName).Value; //trova il nome del client nel dict
                workerSocket.Close();

            }
            catch (SocketException ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }
        }
    }
}
