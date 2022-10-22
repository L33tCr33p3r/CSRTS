using SFML.System;
using SFML.Graphics;

namespace CSRTS.Source.Unit {
    internal abstract class Unit {
		public float Speed { get; protected init; }
        public Vector2f Position { get; protected set; } = new();
    }
}
