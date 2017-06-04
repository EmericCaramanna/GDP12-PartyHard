using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJBehaviour : MonoBehaviour {

	AudioSource audioSource;

	public AudioClip[] clips;
	int musicIndex;

	// Use this for initialization
	void Start () {
		musicIndex = 0;
		audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (clips [musicIndex]);
	}
	
	// Update is called once per frame
	void Update () {
		if (!audioSource.isPlaying) {
			musicIndex = 1;
			audioSource.loop = true;
			audioSource.PlayOneShot(clips[musicIndex]);
		}
	}
}
