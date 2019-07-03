using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// スコアを表示する
	public Text scoreText;

	// スコア
	private int score;

	void Start ()
	{
		
	}

	void Update ()
	{
		scoreText.text = score.ToString ();
	}
	public void Savescore ()
	{
		PlayerPrefs.SetInt ("scorekey", score);
		Debug.Log ("OK");
		PlayerPrefs.Save ();
	}
		
	// ポイントの追加
	public void AddPoint (int point)
	{
		score = score + point;
	}

	// ハイスコアの保存

}