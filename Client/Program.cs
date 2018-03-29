using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public class tcpSend
    {
       
        private static void Main()
        {
            string HostName = "127.0.0.1";
            int prt = 4444;

            TcpClient tc = new TcpClient(HostName, prt);

            NetworkStream ns = tc.GetStream();

            FileStream fs = File.Open("C:\\users\\sunny\\exploit\\test.txt", FileMode.Open);

            int data = fs.ReadByte();

            while (data != -1)
            {
                ns.WriteByte((byte)data);
                data = fs.ReadByte();

            }
            fs.Close();
            ns.Close();
            tc.Close();
       
            
        
        }
    }
}