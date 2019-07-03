using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTitle : MonoBehaviour {

	GameObject bgm;
	AudioSource click;

	void Start(){
		bgm = GameObject.Find ("bgmMR");
	}

	public void OnStartButtonClicked () 
	{
		click = GetComponent<AudioSource> ();
		click.Play();

		Invoke ("scenecha", 1.0f);
	}

	void scenecha(){
		SceneManager.LoadScene ("Title");

		Destroy (bgm);
	}
}