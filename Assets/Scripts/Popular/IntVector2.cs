/*
 * Original author Kyle Misner
 * GitHub: https://github.com/ismakefire
 * 
 * An integer version of Unity's Vector2 class, based on common useage in GitHub. Probably due to this tutorial: http://catlikecoding.com/unity/tutorials/maze/
 */

namespace Popular {
	[System.Serializable]
	public struct IntVector2 {

		public int x;
		public int z;

		/// <summary>
		/// Shorthand for writing new IntVector2(0, 0).
		/// </summary>
		public static readonly IntVector2 zero = new IntVector2(0, 0);

		/// <summary>
		/// Shorthand for writing new IntVector2(1, 1).
		/// </summary>
		public static readonly IntVector2 one = new IntVector2(1, 1);

		/// <summary>
		/// Constructs a new vector with given x, z components.
		/// </summary>
		public IntVector2 (int x, int z) {
			this.x = x;
			this.z = z;
		}

		public static IntVector2 operator +(IntVector2 a, IntVector2 b) {
			a.x += b.x;
			a.z += b.z;
			return a;
		}

		public static IntVector2 operator -(IntVector2 a, IntVector2 b) {
			a.x -= b.x;
			a.z -= b.z;
			return a;
		}

		public static IntVector2 operator -(IntVector2 value) {
			value.x = -value.x;
			value.z = -value.z;
			return value;
		}

		public static IntVector2 operator *(IntVector2 a, int scale) {
			a.x *= scale;
			a.z *= scale;
			return a;
		}

		public static IntVector2 operator *(int scale, IntVector2 b) {

			// This assumes the communitative property, a * b = b * a.
			b.x *= scale;
			b.z *= scale;
			return b;
		}

		public static IntVector2 operator /(IntVector2 a, int scale) {
			a.x /= scale;
			a.z /= scale;
			return a;
		}

		public static IntVector2 operator %(IntVector2 a, int scale) {
			a.x %= scale;
			a.z %= scale;
			return a;
		}

		public static bool operator ==(IntVector2 a, IntVector2 b) {
			return (a.x == b.x && a.z == b.z);
		}

		public static bool operator !=(IntVector2 a, IntVector2 b) {
			return (a.x != b.x || a.z != b.z);
		}

		/// <summary>
		/// Returns a nicely formatted string for this vector.
		/// </summary>
		public override string ToString()
		{
			return string.Format("({0}, {1})", x, z);
		}
	}
}