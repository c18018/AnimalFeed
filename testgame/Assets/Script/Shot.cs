using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
	public GameObject yajirusi;

	public GameObject carrot;
	public GameObject fruit;
	public GameObject meet;

	AudioSource	ss;

	public float insTime;
	public float a;
	public int carrotnum;
	public int fruitnum;

	public float speed1;
	public float speed2;
	public float speed3;
	public float speed4;
	public float speed5;

	Vector3 pos;

	float objSpeed;

	public GameObject player;
	Animator swing;

	bool click = true;

	int i = 0;

	GameObject obj;
	//AudioSource shot;

	void Start () {
		swing = player.GetComponent<Animator> ();
		pos = transform.position;
		pos.y = a;
		ins();
	}


	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			if (click) {
				yajirusi.GetComponent<mater> ().enabled = false;
				click = false;
			} else {
				swing.SetTrigger ("swing");
				Invoke ("foodShot", 0f);
				Invoke ("ins", insTime);
				yajirusi.GetComponent<mater> ().enabled = true;
				ss = GetComponent<AudioSource> ();
				ss.Play();
				click = true;
			}
		}
	}


	void ins(){
		i = Random.Range (1, 11);

		obj = Instantiate(
			Ramfood(),
			pos,
			Quaternion.identity
		);
		//shot = GetComponent<AudioSource> ();
		//shot.Play();
	}


	void foodShot(){
		Rigidbody objRig = obj.GetComponent<Rigidbody> ();
		objRig.AddForce (new Vector3(0, 1.73f, 1) * os());
	}


	GameObject Ramfood(){
		GameObject prefab = null;

		if(i <= carrotnum){
			prefab = carrot;
		}else if(i <= fruitnum){
			prefab = fruit;
		}else{
			prefab = meet;
		}
		return prefab;
	}




	float os(){
		float x = yajirusi.transform.position.x;

		if(x <= 1049.55){
			objSpeed = speed1;
		}else if(x <= 1050.3){
			objSpeed = speed2;
		}else if(x <= 1051){
			objSpeed = speed3;
		}else if(x <= 1051.85){
			objSpeed = speed4;
		}else{
			objSpeed = speed5;
		}

		return objSpeed;
	}
}
