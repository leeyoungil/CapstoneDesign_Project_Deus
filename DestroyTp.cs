using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyTp : MonoBehaviour {
	public ParticleSystem effect;
	public GameObject[] target;
	private bool check;
	private bool managerCheck;
	private GameObject a;
	public GameObject Success;
	private bool Empty;
	//public List<GameObject> dis = new List<GameObject>();

	// Use this for initialization
	void Start () {
		Empty = false;
		check = false;
		target = GameObject.FindGameObjectsWithTag ("target");
		Success = GameObject.Find("SuccessText");
	}

	// Update is called once per frames
	void Update () {


				/*if (dis.Exists(target
					if(check == false){
						Instantiate(effect,this.transform.position, this.transform.rotation);
						check = true;

						Success.transform.FindChild("Success").gameObject.SetActive(true);
						Score_Manager.score += 30;
						StartCoroutine(good (3.0f));

					}



				*/

				if (check2(target)) {
					if(check == false){
						Instantiate(effect,this.transform.position, this.transform.rotation);
						check = true;

						Success.transform.FindChild("Success").gameObject.SetActive(true);
						Score_Manager.score += 30;
						StartCoroutine(good (3.0f));
					}
				}
			}

			IEnumerator good(float waitTime) {
				yield return new WaitForSeconds(waitTime);
				Success.transform.FindChild("Success").gameObject.SetActive(false);
				GameObject.Find ("Main Camera").GetComponent<Managerment> ().DestroyCheck = true;
				Destroy(this.gameObject);



			}

			bool check2(GameObject[] target)
			{
				for(int i= 0; i<target.Length; i++)
				{
					if(target[i] != null)
					{
						Empty = false;
						return Empty;
					}

				}
				Empty = true;
				return Empty;
			}
		}
