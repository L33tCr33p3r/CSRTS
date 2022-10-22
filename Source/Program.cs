namespace CSRTS.Source
{
    static class Program
    {
        static void Main()
        {
            var server = new Server(new Level());
            server.Run();
        }
    }
}
