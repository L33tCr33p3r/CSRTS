using System.Net.Sockets;
using System.Net;

namespace CSRTS.Server
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
				try
				{
					IPAddress localIp = IPAddress.Parse("127.0.0.1");
					Console.WriteLine(localIp.ToString());
					_connectionListener = new(localIp, i);
					break;
				}
				catch
				{
					
				}
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
				_level.Update();
			}
		}
	}
}
