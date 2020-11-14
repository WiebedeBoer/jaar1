using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace Samplesocket
{
    [Activity(Label = "Sockettest")]
    public class Sockettest : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        public void Test()
        {
            Socket s;


        }

        // Copying Socket functions from powerpoint

        public Socket Open(string ipadress,int portnr)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(ipadress);
            IPEndPoint endpoint = new IPEndPoint(ip, portnr);
            socket.Connect(endpoint);
            return socket;
        }

        public void Write(Socket socket, string text)
        {
            socket.Send(Encoding.ASCII.GetBytes(text));
        }
        public string Read(Socket socket)
        {
            byte[] bytes = new byte[4096];
            int bytesRec = socket.Receive(bytes);
            string text = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            return text;

        }
        public void Close(Socket socket)
        {
            socket.Close();
        }
        public string Ask(string ipadress,int portnr,string message)
        {
            Socket s = Open(ipadress, portnr);
            Write(s, message);
            string reply = Read(s);
            Close(s);
            return reply;
        }
        
    }
   
  
}