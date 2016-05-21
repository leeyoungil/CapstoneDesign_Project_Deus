using UnityEngine;
using System.Collections;


public class Create : MonoBehaviour {
	public GameObject a;
	public GameObject b;
	Vector3 pos;
	public int Number;
	private IEnumerator coroutine;
	public bool c = false;



	void Start(){
		Number = 0;
		coroutine = create (0.1f);
		StartCoroutine (coroutine);

	}


	void Update(){
		if (Number >5) {

			StopCoroutine(coroutine);
			c = true;

		}


	}

	IEnumerator create(float w)
	{
		while (true) {
			yield return new WaitForSeconds (w);
			pos = new Vector3 (Random.Range (-7.5f, 7.5f), Random.Range (-5.0f, 5.0f), 0);

			GameObject ob = (GameObject) Instantiate (a, pos, Quaternion.Euler (0, 0, 18));
			ob.name = "B" +Number.ToString();
			StartCoroutine (coroutine);
			Number++;
		}
	}
}
