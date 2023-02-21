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

namespace HW_1_Network_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress = IPAddress.Parse("94.100.180.201");//Адресс Mail.
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress,80);
            Socket socket=new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.IP);
            try
            {
                socket.Connect(iPEndPoint);
                if(socket.Connected) 
                {
                    String stGet = "GET\r\n\r\n";
                    socket.Send(Encoding.ASCII.GetBytes(stGet));
                    byte[] buffer =new byte[1024];
                    int l;
                    do
                    {
                        l=socket.Receive(buffer);
                        textBox1.Text += Encoding.ASCII.GetString(buffer, 0, l);
                    }
                    while(l>0);
                }
                else { MessageBox.Show("Error"); }
            }
            catch(SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
