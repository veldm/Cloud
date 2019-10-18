using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_DLL
{
    enum Command 
    { Save, Load };

    public class Server
    {        
        public Socket socket = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
        public Byte[] ms_buf/* = new Byte[1599999999]*/;
        public MemoryStream ms/* = new MemoryStream(ms_buf)*/;
        public BinaryReader br /*= new BinaryReader(ms)*/;

        public void Connect(int Port)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, Port));
            socket.Listen(7);
            Recieve();
        }

        private void Recieve()
        {
            Socket cs = socket.Accept();
            ms_buf = new Byte[1599999999];
            ms = new MemoryStream(ms_buf);
            br = new BinaryReader(ms);
            while (true)
            {
                // Здесь должна быть менюшка
                cs.Receive(ms_buf);
                Command C = (Command)br.ReadInt32();
                switch (C)
                {
                    case Command.Save:
                        Save();
                        break;
                    case Command.Load:
                        Load();
                        break;
                }                
            }
        }

        private void Save()
        {
            String Name = br.ReadString();
            int Length = (int)br.ReadInt64();
            Byte[] buf = br.ReadBytes(Length);
            FileStream FS = new FileStream($"DataTest\\{Name}", FileMode.Create);
            FS.Write(buf, 0, Length);
        }

        private void Load()
        {
            throw new NotImplementedException();
        }
    }
}
