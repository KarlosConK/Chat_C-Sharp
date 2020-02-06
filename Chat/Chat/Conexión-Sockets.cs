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
    }
}
//https://www.youtube.com/watch?v=x-mPC3KINrE