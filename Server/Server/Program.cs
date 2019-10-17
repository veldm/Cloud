using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
        static Byte[] ms_buf = new Byte[1599999999];
        static MemoryStream ms = new MemoryStream(ms_buf);
        static BinaryReader br = new BinaryReader(ms);

        static void Main(string[] args)
        {
            Console.WriteLine("Waiting for requests...");
            socket.Bind(new IPEndPoint(IPAddress.Any, 907));
            socket.Listen(7);
            Socket cs = socket.Accept();
            Console.WriteLine("New connection opend");
            while (true)
            {
                cs.Receive(ms_buf);
                String Name = br.ReadString();
                int Length = (int)br.ReadInt64();
                //Byte[] buf = new Byte[Length];
                //br.Read(buf, 0, buf.Length);
                Byte[] buf = br.ReadBytes(Length);
                FileStream FS = new FileStream($"C:\\Users\\Dmitry\\Desktop\\{Name}", FileMode.Create);
                FS.Write(buf, 0, Length);
                Console.WriteLine("Файл успешно сохранён");
            }
        }
    }
}
