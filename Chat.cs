using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.Net.Sockets;

namespace SEGP
{
    public partial class Chat : DevExpress.XtraEditors.XtraUserControl
    {
        Socket sck;
        EndPoint eplocal, epremote;

        public Chat()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            IPYourtxt.Text = GetIP();
        }

        private String GetIP()
        {
            IPHostEntry Host;
            Host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in Host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            
            }

            return "127.0.0.1";
        }


        private void Call(IAsyncResult result)
        {
            try
            {
                int s = sck.EndReceiveFrom(result, ref epremote);
                if (s > 0)
                {
                    byte[] data = new byte[2000];
                    data = (byte[])result.AsyncState;
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    String recievedmessage = encoding.GetString(data);
                    BodyChat.Items.Add("Client: " + recievedmessage);
                }
                byte[] bufferbyte = new byte[2000];
                sck.BeginReceiveFrom(bufferbyte, 0, bufferbyte.Length, SocketFlags.None, ref epremote, new AsyncCallback(Call), bufferbyte);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something is Wrong"+e.ToString());
            }


        }

        private void ConnectChatbtn_Click(object sender, EventArgs e)
        {
            try
            {
                eplocal = new IPEndPoint(IPAddress.Parse(GetIP()),Convert.ToInt32(Portyourtxt.Text));
                sck.Bind(eplocal);

                epremote = new IPEndPoint(IPAddress.Parse(IPfrindtxt.Text), Convert.ToInt32(portfrindtxt.Text));
                sck.Connect(epremote);

                byte[] bufferbyte = new byte[2000];
                sck.BeginReceiveFrom(bufferbyte,0,bufferbyte.Length,SocketFlags.None,ref epremote,new AsyncCallback(Call),bufferbyte);

                ConnectChatbtn.Text = "Connected";
                ConnectChatbtn.Enabled = false;
                SendChatsmsbtn.Enabled = true;
                sms.Focus();
            }
            catch(Exception a)
            {
                MessageBox.Show("Something is Wrong" + a.ToString());
                
            }
        }

        private void SendChatsmsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] message = new byte[2000];
                message = enc.GetBytes(sms.Text);

                sck.Send(message);
                BodyChat.Items.Add("Me: "+sms.Text);
                sms.Clear();
            }
            catch (Exception a)
            {
                MessageBox.Show("Something is Wrong "+a.ToString());
            }
        }





    }
}
