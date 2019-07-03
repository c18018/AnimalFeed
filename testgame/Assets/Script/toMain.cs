using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMain : MonoBehaviour {

	AudioSource click;
	
	public void OnStartButtonClicked () 
	{

		Invoke("scenecha", 0.1f);
	}

	void scenecha(){
		SceneManager.LoadScene ("Main");
	}


	public void operaButton()
	{
		Invoke ("opare", 1.0f);
	}

	void opare(){
		SceneManager.LoadScene ("opera");
	}
}