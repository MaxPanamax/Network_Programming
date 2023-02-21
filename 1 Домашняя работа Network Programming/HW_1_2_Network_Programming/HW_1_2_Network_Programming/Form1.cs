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

namespace HW_1_2_Network_Programming
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
            Socket socket=new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.IP);
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");//localhost
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress,1024);
            socket.Bind(iPEndPoint);
            socket.Listen(10);
            try
            {
                while(true)
                {
                    Socket newSocket1 = socket.Accept();
                    textBox1.Text = (newSocket1.RemoteEndPoint.ToString());
                    newSocket1.Send(Encoding.ASCII.GetBytes(DateTime.Now.ToString()));
                    newSocket1.Shutdown(SocketShutdown.Both);
                    newSocket1.Close();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
