using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace CSRTS.Source {
    static class Program {
        static void Main() {
            var window = new RenderWindow(new VideoMode(800, 800), "CSRTS");
            window.Closed += new EventHandler(OnClose);
            Console.WriteLine("Hello, World!");
        }
        static void OnClose(object? sender, EventArgs e) {
            if (sender != null) {
                var window = (RenderWindow) sender;
                window.Close();
            }
        }
    }
}
