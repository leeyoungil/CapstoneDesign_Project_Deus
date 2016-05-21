using UnityEngine;
using System.Collections;

public class GestureCusorCh : MonoBehaviour {

	private float time;
	private bool check = false;
    public GameObject side1Check1;
	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider col) {

		check = true;
		time = 0;

        side1Check1.SetActive(true);

	}
	void OnTriggerExit(Collider col){
		check = false;
		time = 0;

       side1Check1.SetActive(false);
	}



	// Update is called once per frame
	void Update () {
		if (check == true) {
			time += Time.deltaTime;
			if(time >= 2.0f){
            Destroy(GameObject.Find("share1"));
			Application.LoadLevel (2);
			}
		}
	}



}
