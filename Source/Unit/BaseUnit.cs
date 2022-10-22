using SFML.System;
using SFML.Graphics;

namespace CSRTS.Source.Unit
{
	internal abstract class BaseUnit
	{
		public float Speed { get; protected init; }
		public Vector2f Position { get; protected set; } = new();
	}
}
