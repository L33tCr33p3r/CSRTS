namespace CSRTS.Server
{
    internal class Server
    {
        private Level _level;
        private List<Level> _players;

        public Server(Level level)
        {
            _level = level;
        }
        public void Run()
        {
            while (true)
            {
                _level.Update();
            }
        }
    }
}
