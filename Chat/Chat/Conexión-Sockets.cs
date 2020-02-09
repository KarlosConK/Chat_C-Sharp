using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Chat
{
    class Conexion_Sockets
    {
        Socket ServerSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        IPEndPoint Direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"),8000);
        public void Conectar()
        {
            ServerSocket.Bind(Direccion);
            ServerSocket.Listen(2);
            Socket Escucha = ServerSocket.Accept();

            byte[] buffer = new byte[1024];
            int a = Escucha.Receive(buffer,0,buffer.Length,0);
        }
        
    }
}
//https://www.youtube.com/watch?v=x-mPC3KINrE