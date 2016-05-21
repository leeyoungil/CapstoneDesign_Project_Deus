using UnityEngine;
using System.Collections;

public class BodeyManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("U_CharacterBack").transform.FindChild("U_Char").gameObject.SetActive(true);

	}

	// Update is called once per frame
	void Update () {

	}
}
