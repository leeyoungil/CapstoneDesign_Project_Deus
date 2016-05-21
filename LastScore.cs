using UnityEngine;
using System.Collections;

public class LastScore : MonoBehaviour {
	public static int score;

	// Use this for initialization
	void Start () {
		Debug.Log (score);

	}

	int getScore() {
		return score;
	}

	// Update is called once per frame
	void Update () {

	}
}
