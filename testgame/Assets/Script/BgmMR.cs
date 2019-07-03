using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmMR : MonoBehaviour {

	public bool DontDestroyEnabled = true;
	AudioSource bgmMR;

	void Start () {
		bgmMR = GetComponent<AudioSource> ();
		bgmMR.Play ();

		if (DontDestroyEnabled) {
			DontDestroyOnLoad (this);
		}
	}
}