using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StringEqualityTest {

	private string testName;
	private string controlValue;
	private List<string> testValues;

	public StringEqualityTest(string testName, string controlValue, List<string> testValues) {
		this.testName = testName;
		this.controlValue = controlValue;
		this.testValues = testValues;
	}

	public bool Run () {
		bool hasPassedEveryTest = true;

		for (int index = 0; index < testValues.Count; index++) {
			string valueToTest = testValues[index];

			if (controlValue != valueToTest) {
				Debug.LogError ("Test '"+testName+"' failed at index "+index+".\ncontrolValue = "+controlValue+"\nvalueToTest = "+valueToTest+"");
				hasPassedEveryTest = false;
			}
		}

		if (hasPassedEveryTest) {
			Debug.Log ("Test '"+testName+"' has passed "+testValues.Count+" value tests.");
		}

		return hasPassedEveryTest;
	}
}
