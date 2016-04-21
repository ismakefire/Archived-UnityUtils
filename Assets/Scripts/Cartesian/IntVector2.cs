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
	}
}