using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Cartesian;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		new StringEqualityTest(
//			"Zero as a string.",
//			"(0, 0)",
//			new List<string> {
//				Cartesian.IntVector2.zero.ToString(),
//				Popular.IntVector2.zero.ToString(),
//			}
//		).Run();

		ChessBoardTest(); // 1/8
		RandomNumberTest(50); // 66%
		RandomNumberTest(500); // 6%
		RandomNumberTest(65000); // 1%

//		foreach (IntVector2 vector in vectors) {
//			Debug.Log ("Vector "+vector.ToString()+" has hash code "+vector.GetHashCode());
//		}

//		Debug.Log ("IntVector2.zero.GetHashCode() = "+IntVector2.zero.GetHashCode());
//		Debug.Log ("IntVector2.one.GetHashCode() = "+IntVector2.one.GetHashCode());
	}

	private void ChessBoardTest () {
		HashSet<IntVector2> vectors = new HashSet<IntVector2>();
		HashSet<int> hashCodes = new HashSet<int>();

		for (int i = 0; i < 8; i++) {
			for (int j = 0; j < 8; j++) {
				IntVector2 vector = new IntVector2(i, j);
				vectors.Add( vector );
				hashCodes.Add( vector.GetHashCode() );
			}
		}

		Debug.Log ("Chess Test: "+hashCodes.Count+" / "+vectors.Count);
	}

	private void RandomNumberTest (int radius) {
		HashSet<IntVector2> vectors = new HashSet<IntVector2>();
		HashSet<int> hashCodes = new HashSet<int>();

		for (int i = 0; i < 10000; i++) {
			IntVector2 vector = new IntVector2(Random.Range(-radius, radius), Random.Range(-radius, radius));
			vectors.Add( vector );
			hashCodes.Add( vector.GetHashCode() );
		}

		Debug.Log ("Random "+radius+" Test: "+((float)hashCodes.Count / (float)vectors.Count)+" / "+((float)vectors.Count / 10000f));
	}

	// Update is called once per frame
	void Update () {
	
	}
}
