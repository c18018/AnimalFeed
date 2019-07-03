using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  random : MonoBehaviour {

	public GameObject carrot;
	public GameObject fruit;
	public GameObject meet;
	public float insTime;
	public float a;
	Vector3 pos;

	public int carrotnum;
	public int fruitnum;

	void Start(){
		pos = transform.position;
		pos.y = a;

		ins();
	}
	
	void Update () {
		if(Input.GetKeyDown("space")){
			Invoke("ins", insTime);
		}
	}

	void ins(){
			Instantiate(
				Ramfood(),
				pos,
				Quaternion.identity
				);
		}

	GameObject Ramfood(){

		GameObject prefab = null;

		int i = 0;

		i = Random.Range(1, 11);

		if(i <= carrotnum){
			prefab = carrot;
		}else if(i <= fruitnum){
			prefab = fruit;
		}else{
			prefab = meet;
		}

		return prefab;
	}
}
