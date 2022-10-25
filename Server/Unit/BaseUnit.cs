using SFML.System;
using SFML.Graphics;

namespace CSRTS.Server.Unit
{
	internal abstract class BaseUnit
	{
		public Guid Id { get; } = Guid.NewGuid(); // To be used for syncing with clients
		public float Speed { get; protected init; }
		public Vector2f Position { get; protected set; } = new();
		public int Health { get; set; }
		public Queue<Order> Orders { get; set; } = new();
		public FireStance Stance { get; set; }
		public BaseUnit? Target { get; set; }
		protected Vector2f _targetLastSeen { get; set; }
		protected float _viewRange;

		public void Update() {
			// Stuff goes here
		}
	}
}
