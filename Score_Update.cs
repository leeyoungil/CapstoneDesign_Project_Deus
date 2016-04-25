using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score_Update : MonoBehaviour {
	Text scoreLabel;
	// Use this for initialization
	void Start () {
		scoreLabel = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		scoreLabel.text = Managerment.score.ToString ();

	}
}
