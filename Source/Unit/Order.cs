using SFML.System;

namespace CSRTS.Source.Unit {
	enum FireStance {
		/// <summary> Run away from enemies </summary>
		Flee,
		/// <summary> Do not attack enemies </summary>
		Hold,
		/// <summary> Attack enemies that attacked first </summary>
		Return,
		/// <summary> Attack any spotted enemies </summary>
		AtWill
	}

	// This is esntially an enum, except:
	// a) it can be inherited from, so units can add their own order types
	// b) each order can contain data, such as the spot to move to
	abstract record Order {
		public record Move(Vector2f To) : Order;
		public record Attack(Unit Target) : Order;
	}
}