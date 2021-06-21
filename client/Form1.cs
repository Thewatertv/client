using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace client
{
    public partial class Form__chat : Form
    {


        static private Socket Client;
        private IPAddress ip = null;
        private int port = 0;
        private Thread th;

       public Form__chat()
        {
            InitializeComponent();

            richTextBox_entering_message.Enabled = false;
            button_send_messages.Enabled = false;


            try {
                var sr = new StreamReader("D:\\месенджер на c++\\se\\seData_info.txt");
                string buffer = sr.ReadToEnd();
                sr.Close();
                string[] connect_info = buffer.Split(':');
                ip = IPAddress.Parse(connect_info[0]);
                port = int.Parse(connect_info[1]);

                label_server_info.ForeColor = Color.Green;
                label_server_info.Text = "Настройки: \n IP servera: " + connect_info[0] + "\n Port: " + connect_info[1];
            }

            catch(Exception ex)
            {
                label_server_info.ForeColor = Color.Red;
                label_server_info.Text = "Настройки не найдены";
                Form_settings form = new Form_settings();
                form.Show();
                
                    }

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_settings form = new Form_settings();
            form.Show();





        }

        void SendMessage( string message)
        {
            if (message !="" && message != " ")
            {
                byte[] buffer = new byte[1024];
                buffer = Encoding.UTF8.GetBytes(message);
                Client.Send(buffer);
            }
        }

        void RecvMessage ()
        {
            byte[] buffer = new byte[1024];
            for (int i = 0; i <buffer.Length; i++)
            {
                buffer[i] = 0;

            }
            
            for (; ; )
            {

                

              

                try
                {
                    Client.Receive(buffer);
                    string message = Encoding.UTF8.GetString(buffer);
                   
                    int count = message.IndexOf(";;;5");
                    if(count==-1)
                    {
                        continue;

                    }

                    string Cleat_message = "";

                    for (int i= 0; i<count;i++)
                    {
                        Cleat_message += message[i];

                    }

                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = 0;

                    }

                    Invoke((MethodInvoker)delegate ()

                    {
                        richTextBox_chat_output.AppendText(Cleat_message);
                    }

                    );

                }

                catch
                {

                }

            }


        }

        private void button_will_connect_Click(object sender, EventArgs e)
        {

            richTextBox_entering_message.Enabled = true;
            button_send_messages.Enabled = true;
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (ip != null)
            {
                Client.Connect(ip, port);
                th = new Thread(delegate () { RecvMessage(); });
                th.Start();
            }

        }

        private void button_send_messages_Click(object sender, EventArgs e)
        {
            SendMessage("\n" + textBox_nick.Text + ": " + richTextBox_entering_message.Text + ";;;5");
            richTextBox_entering_message.Clear();
        }

            

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (th!=null)
                th.Abort();
           
            Application.Exit();
        }
    }
}
