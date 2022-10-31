using SFML.System;
using SFML.Graphics;

namespace CSRTS.Common.Unit
{
	internal abstract class BaseUnit
	{
		public Guid Id { get; } = Guid.NewGuid(); // To be used for syncing with clients
		public float Speed { get; protected init; }
		public Vector2f Position { get; protected set; } = new();
		public float Height { get; protected set; }
		public float Direction { 
			get {
				return this.Direction;
			} 
			protected set {
				value = value % 360;
				if (value < 0) value += 360;
				this.Direction = value;
			}
		}
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
