using UnityEngine;
using System.Collections;

public class Effect1 : MonoBehaviour {
	public ParticleSystem a;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "hand") {
			Destroy (gameObject);
			Managerment.score += 10;

			Instantiate(a,this.transform.position,this.transform.rotation);
		}
	}
}
