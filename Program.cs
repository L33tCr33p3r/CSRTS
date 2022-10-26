using CSRTS.Server;

namespace CSRTS
{
    static class Program
	{
        static void Main()
        {
			Thread ServerThread = new(new ThreadStart(ServerStart));
			ServerThread.Start();
			Thread ClientThread = new(new ThreadStart(ClientStart));
        }

		static void ServerStart()
		{
			var Server = new Server.Server();
			Server.Run();
		}
		static void ClientStart()
		{
			var client = new Client.Client();
			client.Run();
		}
	}
}
