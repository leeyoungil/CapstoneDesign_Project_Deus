using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Managerment : MonoBehaviour {


	public GameObject[] tempGO = new GameObject[5];
	public static int score;
	public static int finalScore;


	//public bool DestroyCheck =true; //파괴 체크
	public  bool DestroyCheck = true;
	int i=0,j=0,b,jung=0;
	int N=0;
	int[] val = new int[5]; //배열 값에 정수 섞기

	IEnumerator gameover(float waitTime) {
		yield return new WaitForSeconds (waitTime);
		score = 0;
		Application.LoadLevel("share2");
	}

	// Use this for initializatio
	void Start () {
		score = 0;
		Debug.Log (DestroyCheck);
		shuffle ();
		//StartCoroutine(ObjectRandomGenerator());

	}

	// Update is called once per frame
	void Update () {
		if(DestroyCheck){
			ObjectRandomGenerator ();
		}
		if (GameObject.Find ("Slider").GetComponent<TimeControl> ().s.value == 0) {
			LastScore.score = score;

			StartCoroutine(gameover(3.0f));
		}
	}
	//IEnumerator ObjectRandomGenerator() {
		void ObjectRandomGenerator() {
		//while(true) {
			if(N==tempGO.Length){
				N=0;
			}
			Instantiate(tempGO[val[N]]);
			//yield return new WaitForSeconds(1f);
				N++;
		DestroyCheck = false;
		}




	void shuffle(){
		for (i=0; i<=3; i++) {

			b = Random.Range (0, 5);

			for (j=0; j<=i; j++) { //값이 들어간 배열값들과 현재 랜덤값들을 비교
				if (val [j].Equals (b)) { //중복된 값이 있으면
					i = i - 1;  //값을 넣지 않고 현제 배열로 다시한번 값을 찾기위해
					jung = 1;  //중복되었다는 것을 알려줌

				}
			}

			if (jung != 1) {  //중복되지 않았을때
				val [i] = b;  //배열값에 랜덤값을 넘겨줌
			} else {
				jung = 0;   //중복되엇을시 배열에 값을 넣지 않고 중복변수에 0을줌
			}
		}
		for(i=0;i<val.Length;i++){
			Debug.Log(val[i]);

		}

	}




}
