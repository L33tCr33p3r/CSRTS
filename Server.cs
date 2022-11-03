using System.Net.Sockets;
using System.Net;
using CSRTS.Common;
using System.Text;
using System.Threading;

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
				Console.WriteLine("Success!");
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
				Console.WriteLine("Accepted connection from " + client.RemoteEndPoint);
				SendData(client, CommandType.Print, Encoding.UTF8.GetBytes("hi!"));
				// while (client.Connected)
				// {
				// 	// client.Send(Encoding.ASCII.GetBytes(Console.ReadLine()));
					
				// }
			}
		}

		public static void SendData(Socket client, CommandType command, byte[] msg)
		{
			// create message buffer
			var message = new byte[3 + msg.Length];

			// create header
			message[0] = (byte)command;
			(message[1], message[2]) = ((byte)(msg.Length & 0xff), (byte)(msg.Length >> 8)); // (lower, upper)
			// the order has to be reversed to be correctly read by godot

			// append data
			msg.CopyTo(message, 3);

			// send to client
			client.Send(message);
		}

		public enum CommandType
		{
			Print,
		}
	}
}
