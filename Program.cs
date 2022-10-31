namespace CSRTS
{
    static class Program
	{
        static void Main()
        {
			Thread ServerThread = new(new ThreadStart(ServerStart));
			ServerThread.Start();
			Thread ClientThread = new(new ThreadStart(ClientStart));
			ClientThread.Start();
        }
		static void ServerStart()
		{
			var Server = new Server();
			Server.Run();
		}
		static void ClientStart()
		{
			var client = new Client();
			client.Run();
		}
	}
}
