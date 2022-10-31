using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace CSRTS
{
    internal class Client
    {
        private TcpClient _tcpClient = new("127.0.0.1", 4503);
        public void Run()
        {
			var stream = _tcpClient.GetStream();
			while (true)
			{
				if (stream.DataAvailable)
				{
					byte[] text = new byte[1024];
					int n = stream.Read(text, 0, _tcpClient.Available);
					//Console.WriteLine(_tcpClient.Available);
					Console.WriteLine(Encoding.ASCII.GetString(text));
				}
				else
				{
					//Console.WriteLine("no bytes available");
				}
			}
        }
    }
}
