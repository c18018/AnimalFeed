using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearWolf : MonoBehaviour {

	public GameObject favoEffect;
	public GameObject otherEffect;
	public float desTime;
	//public float a;
	Vector3 pos;

	void Start(){
		pos = new Vector3 (1047.77f, 7.84f, 98.52f);
	}
	
	void OnCollisionEnter(Collision other){
		//pos = transform.position;
		//pos.y = a;

		if(other.gameObject.tag == "meet"){
			if (favoEffect != null) {
				GameObject effect = Instantiate (
					favoEffect,
					pos,
					Quaternion.identity
				);
				FindObjectOfType<Score> ().AddPoint (50);
				Destroy(effect, desTime);
			}

	} else if (other.gameObject.tag == "carrot") {
			otherEffe ();
		} else if (other.gameObject.tag == "fruit") {
			otherEffe ();
		}
	}

	void otherEffe(){
		if (otherEffect != null) {
			GameObject effect = Instantiate (
				otherEffect,
				pos,
				Quaternion.identity
			);
		
			Destroy(effect, desTime);

		}
	}
}