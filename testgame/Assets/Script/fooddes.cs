using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fooddes : MonoBehaviour {

	void OnCollisionEnter (Collision other){
		if (other.gameObject.tag == "Animal") {
			Destroy (gameObject);
		} else if (other.gameObject.name == "Stage"){
			Destroy (gameObject);
		}
	}
}