using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmSe : MonoBehaviour {

	AudioSource	bgmSe;

	void Start () {
		bgmSe = GetComponent<AudioSource>();
		bgmSe.Play();
	}
}
