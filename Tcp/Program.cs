using System;
using System.Net.Sockets;
using System.Net;

namespace Tcp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

          
            TcpHelper.StartServer(9000);
            TcpHelper.Listen(); // Start listening
        }
    }
}
