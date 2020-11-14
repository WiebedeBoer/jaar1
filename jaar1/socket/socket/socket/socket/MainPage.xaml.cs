using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Xamarin.Forms;

namespace socket
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.FindByName<Button>("connect").Clicked += connectToSocket;
            this.FindByName<Button>("force").Clicked += Force;
            this.FindByName<Button>("light").Clicked += LetThereBeLight;
		}

        private void LetThereBeLight(object sender, EventArgs e)
        {
            try
            {
                Socket s = open("192.168.1.3", 50007);

                write(s, "light");
                string reply = read(s);

                System.Diagnostics.Debug.Write(reply);

                close(s);
            }
            catch (Exception _e)
            {
                System.Diagnostics.Debug.WriteLine(_e.Message);
            }
        }

        private void Force(object sender, EventArgs e)
        {
            try
            {
                Socket s = open("192.168.1.3", 50007);

                write(s, "force");
                string reply = read(s);

                System.Diagnostics.Debug.Write(reply);

                close(s);
            }
            catch (Exception _e)
            {
                System.Diagnostics.Debug.WriteLine(_e.Message);
            }
        }

        private void connectToSocket(object sender, EventArgs e)
        {
            try
            {
                Socket s = open("192.168.1.3", 50007);

                write(s, "Hello world!");
                string reply = read(s);

                System.Diagnostics.Debug.Write(reply);

                close(s);
            }catch(Exception _e)
            {
                System.Diagnostics.Debug.WriteLine(_e.Message);
            }
            

        }

        public Socket open(string ip, int prtnr)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress _ip = IPAddress.Parse(ip);
            IPEndPoint endPoint = new IPEndPoint(_ip, prtnr);

            socket.Connect(endPoint);

            return socket;
        }

        public void write(Socket socket, string text)
        {
            socket.Send(Encoding.ASCII.GetBytes(text));
        }

        public string read(Socket socket)
        {
            byte[] bytes = new byte[4096];
            int byterec = socket.Receive(bytes);
            string text = Encoding.ASCII.GetString(bytes, 0, byterec);

            return text;
        }

        public void close(Socket socket)
        {
            socket.Close();
        }
    }
}
