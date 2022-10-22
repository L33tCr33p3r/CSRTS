namespace CSRTS.Source {
	internal class Server {
		private Level _level;
		private

		public Server(Level level)
		{
			_level = level;
		}
		public void Run()
		{
			while (true)
			{
				_level.Update()
			}
		}
	}
}
