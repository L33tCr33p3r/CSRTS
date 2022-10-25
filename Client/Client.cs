using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace CSRTS.Client
{
	internal class Client
	{
		private static Socket ConnectSocket(string server, int port)
		{
			Socket s = null;
			IPHostEntry hostEntry = null;

			// Get host related information.
			hostEntry = Dns.GetHostEntry(server);

			// Loop through the AddressList to obtain the supported AddressFamily. This is to avoid
			// an exception that occurs when the host IP Address is not compatible with the address family
			// (typical in the IPv6 case).
			foreach (IPAddress address in hostEntry.AddressList)
			{
				IPEndPoint ipe = new IPEndPoint(address, port);
				Socket tempSocket =
					new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

				tempSocket.Connect(ipe);

				if (tempSocket.Connected)
				{
					s = tempSocket;
					break;
				}
				else
				{
					continue;
				}
			}
			return s;
		}

		// This method requests the home page content for the specified server.
		private static void SocketSendReceive(string server, int port)
		{

			// Create a socket connection with the specified server and port.
			using (Socket s = ConnectSocket(server, port))
			{
				// Send request to the server.
				s.Send(Encoding.ASCII.GetBytes("Hi!!!"), 5, 0);
			}

		}

		public static void Main(string[] args)
		{
			string host;
			int port = 4503;

			//if (args.Length == 0)
			//	// If no server name is passed as argument to this program,
			//	// use the current host name as the default.
			//	host = Dns.GetHostName();
			//else
			//	host = args[0];

			host = "10.17.68.54";

			SocketSendReceive(host, port);
		}
	}
}
