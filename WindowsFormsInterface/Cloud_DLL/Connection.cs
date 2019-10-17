using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace Cloud_DLL
{
    public static class Connection
    {
        public static Socket socket = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
        static Byte[] ms_buf = new Byte[1599999999];
        public static MemoryStream ms = new MemoryStream(ms_buf);
        public static BinaryWriter bw = new BinaryWriter(ms);

        public static void Connect(String IP_Adress, int Port_Number)
        {
            socket.Connect(IP_Adress, Port_Number);
        }

        public static void SendFile(String Path)
        {
            FileStream FS = new FileStream(Path, FileMode.Open);
            FileInfo FI = new FileInfo(Path);
            Byte[] buf = new Byte[FI.Length];
            FS.Read(buf, 0, buf.Length);
            bw.Write(FI.Name);
            bw.Write((Int64)FI.Length);
            bw.Write(buf);
            socket.Send(ms_buf);
        }
    }
}
