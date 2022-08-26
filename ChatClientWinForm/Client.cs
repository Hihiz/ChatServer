using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClientWinForm
{
    public partial class Client : Form
    {
        // подключение 
        private bool connected = false;
        // клиент
        private Thread client = null;

        private struct MyClient
        {
            public string userName;
            public string key;
            public TcpClient client;
            NetworkStream stream;
            public byte[] buffer;
            public StringBuilder data;
            public EventWaitHandle handle;
        }

        private MyClient obj;
        private Task send = null;
        private bool exit = false;

        public Client()
        {
            InitializeComponent();
        }

        // подключение
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                obj.client.Close();
            }
            else if (client == null || !client.IsAlive)
            {
                string address = AddrTextBox.Text.Trim();
                string number = PortTextBox.Text.Trim();
                string userName = UserNameTextBox.Text.Trim();
                bool error = false;
                IPAddress ip = null;

                if (address.Length < 1)
                {
                    error = true;
                    Log(SystemMsg("Address is required"));
                }
                else
                {
                    try
                    {
                        ip = Dns.Resolve(address).AddressList[0];
                    }
                    catch
                    {
                        error = true;
                        Log(SystemMsg("Address is not valid"));
                    }
                }

                int port = -1;
                if (number.Length < 1)
                {
                    error = true;
                    Log(SystemMsg("Port number is required"));
                }
                else if (!int.TryParse(number, out port))
                {
                    error = true;
                    Log(SystemMsg("Port number is not valid"));
                }
                else if (port < 0 || port > 65535)
                {
                    error = true;
                    Log(SystemMsg("Port number is out of range"));
                }
                if (userName.Length < 1)
                {
                    error = true;
                    Log(SystemMsg("Username is required"));
                }
                if (!error)
                {
                    // ключ шифрования 
                    client = new Thread(() => Connection(ip, port, userName, KeyTextBox.Text))
                    {
                        IsBackground = true
                    };

                    client.Start();
                }
            }

        }

        private void Connection(IPAddress ip, int port, string userName, string text)
        {
            throw new NotImplementedException();
        }

        private string ErrorMsg(string msg)
        {
            return string.Format("ERROR: {0}", msg);
        }

        private string SystemMsg(string msg)
        {
            return string.Format("SYSTEM: {0}", msg);
        }


        private void Log(string msg = "") // очистить лог если нету сообщения
        {
            if (!exit)
            {
                LogTextBox.Invoke((MethodInvoker)delegate
                {
                    if (msg.Length > 0)
                    {
                        LogTextBox.AppendText(string.Format("[ {0} ] {1}{2}", DateTime.Now.ToString("HH:mm"), msg, Environment.NewLine));
                    }
                    else
                    {
                        LogTextBox.Clear();
                    }
                });
            }
        }
    }
}
