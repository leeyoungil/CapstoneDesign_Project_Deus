using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TimeControl : MonoBehaviour {

	public Slider s;
	public GameObject gameOver;

	// Use this for initialization
	void Start () {
		//   a = 1+Time.deltaTime;
		gameOver = GameObject.Find ("GameOver");

		gameOver.transform.FindChild("textGameOver").gameObject.SetActive(false);
		s = gameObject.GetComponent<Slider> ();
		s.value = 60;
		s.maxValue = 60;
		s.minValue = 0;
	}

	// Update is called once per frame
	void Update () {

		s.value -= 1 * Time.deltaTime;
		if (s.value == 0) {
			gameOver.transform.FindChild("textGameOver").gameObject.SetActive(true);

		}
	}
}
