/*
 * Original author Kyle Misner
 * GitHub: https://github.com/ismakefire
 * 
 * An integer version of Unity's Vector2 class.
 */

namespace Cartesian {
	[System.Serializable]
	public struct IntVector2 {
		
		public int x;
		public int y;

		/// <summary>
		/// Shorthand for writing new IntVector2(0, 0).
		/// </summary>
		public static readonly IntVector2 zero = new IntVector2(0, 0);

		/// <summary>
		/// Constructs a new vector with given x, y components.
		/// </summary>
		public IntVector2 (int x, int y) {
			this.x = x;
			this.y = y;
		}

		public static IntVector2 operator +(IntVector2 left, IntVector2 right) {
			left.x += right.x;
			left.y += right.y;
			return left;
		}

		/// <summary>
		/// Returns a nicely formatted string for this vector.
		/// </summary>
		public override string ToString()
		{
			return string.Format("({0}, {1})", x, y);
		}
	}
}