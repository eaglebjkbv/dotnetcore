using System;
using System.Net;
using System.Net.Sockets;

namespace TCPSocketServer
{
    class Program
    {
        public static TcpListener server=null;

        static void Main(string[] args)
        {
           try
           {
                Int32 port=1234;
                IPAddress localAddress=IPAddress.Parse("127.0.0.1");
                server=new TcpListener(localAddress,port);
                server.Start();
                Byte[] bytes = new Byte[256];
                String data = null;

                while(true)
                {
                    System.Console.WriteLine("Bağlantı Bekleniyor.");
                    TcpClient client=server.AcceptTcpClient();
                    System.Console.WriteLine("Bağlandı");
                    data=null;
                    NetworkStream stream=client.GetStream();
                    int i;
                    while((i = stream.Read(bytes, 0, bytes.Length))!=0) 
                    {   
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Geldi: {0}", data);
                    
                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Gitti: {0}", data);            
                    }
                    client.Close();
                }

           }
           catch (SocketException e)
           {
               System.Console.WriteLine($"Hata :{e} ");
           } finally{
               server.Stop();
           }
            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
    }
}
