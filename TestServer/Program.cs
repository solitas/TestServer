using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TestServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void OpenSession(string ipAddr) {
            const int port = 50;
            TcpListener listener = TcpListener.Create(port);
            listener.Start();
            var client = listener.BeginAcceptTcpClient(AcceptAsyncCallback, listener);
        }

        private static async void AcceptAsyncCallback(IAsyncResult result)
        {
            var listener = result.AsyncState as TcpListener;
            await Task.Factory.StartNew(() => {

            }); 
        }

        static void HandleAsyncCallback(IAsyncResult ar)
        {

        }
    }
}
