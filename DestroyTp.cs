using UnityEngine;
using System.Collections;

public class DestroyTp : MonoBehaviour {
	public ParticleSystem effect;
	public GameObject[] target;
	private bool check;
	private bool managerCheck;
	private GameObject a;
	// Use this for initialization
	void Start () {
		check = false;
		target = GameObject.FindGameObjectsWithTag ("target");

	}

	// Update is called once per frames
	void Update () {


		if (target [0] == null && target [1] == null && target [2] == null && target [3] == null) {
			if(check == false){
				Instantiate(effect,this.transform.position, this.transform.rotation);
				check = true;
				Score_Manager.score += 30;
				StartCoroutine(good (3.0f));

			}
		}

	}
	IEnumerator good(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		GameObject.Find ("Main Camera").GetComponent<Managerment> ().DestroyCheck = true;

		Destroy(this.gameObject);

	}
}
