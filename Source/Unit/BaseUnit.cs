using SFML.System;
using CSRTS.Source.Control;

namespace CSRTS.Source.Unit
{
	internal abstract class BaseUnit
	{
		public float Speed { get; protected init; }
		public Vector2f Position { get; protected set; } = new();
		public int Health { get; set; }
		public Queue<Order> Orders { get; set; } = new Queue<Order>();
		public Stance Stance { get; }

		public void Update()
		{
			// Stuff goes here
		}
	}
}
