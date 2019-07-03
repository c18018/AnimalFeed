using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour {

	public float seconds;
	private float oldSeconds;
	private Text timerText;
	GameObject ScoreGUI;

	void Start () {
		oldSeconds = 0;
		timerText = GetComponentInChildren<Text>();
		ScoreGUI = GameObject.Find("ScoreGUI");
	}
	
	void Update () {
		if (seconds <= 0){
			ScoreGUI.GetComponent<Score>().Savescore();
			Debug.Log("OK");
			scene();
		}

		seconds -= Time.deltaTime;

		if((int)seconds != (int)oldSeconds){
			if((int)seconds > 9){
				timerText.text = ((int)seconds).ToString("00");
			}else{
				timerText.text = ((int)seconds).ToString("0");

			}
		}

		oldSeconds = seconds;

	}
		void scene(){
		SceneManager.LoadScene ("Result");

	}
}