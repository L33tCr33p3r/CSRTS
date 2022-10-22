using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace CSRTS.Source {
	static class Program {
		static void Main() {
			var server = new Server(new Level());
			server.Run();
		}
	}
}
