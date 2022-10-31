using System.Net.Sockets;
using System.Net;
using CSRTS.Common;
using System.Text;

namespace CSRTS
{
	internal class Server
	{
		private Level _level = new();
		private List<Level> _players = new();
		private TcpListener _connectionListener;

		public Server()
		{
			for (int i = 4503; i <= 4533; i++)
			{
				IPAddress localIp = IPAddress.Parse("127.0.0.1");
				try
				{
					Console.WriteLine("Trying to open server on: " + localIp.ToString() + ":" + i.ToString());
					_connectionListener = new(localIp, i);
					break;
				}
				catch { }
			}
			if (_connectionListener == null)
			{
				throw new Exception();
			} 
		}
		public void Run()
		{
			_connectionListener.Start();
			while (true)
			{
				//_level.Update();
				var client = _connectionListener.AcceptSocket();
				client.Send(Encoding.ASCII.GetBytes("hi!"));
			}
		}
	}
}
