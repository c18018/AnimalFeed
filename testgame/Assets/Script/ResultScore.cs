using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {
	public Text ScoreLabel;
	int score;
	public Image comment;
	public Sprite comment1;
	public Sprite comment2;
	public Sprite comment3;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("scorekey");
		ScoreLabel.text = "スコア : " + PlayerPrefs.GetInt ("scorekey");
		//Debug.Log (score);
		commentDis();
	}

	void commentDis(){
		if (score < 100) {
			comment.sprite = comment1;
		} else if (score < 200) {
			comment.sprite = comment2;
		} else {
			comment.sprite = comment3;
		}
	}
}
