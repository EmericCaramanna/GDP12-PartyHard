using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	public float timeLeft = 300f;
	bool isPaused = false;

	void Update () {
		if (!isPaused) {
			timeLeft -= Time.deltaTime;

			if (timeLeft < 0) {
				Debug.Log ("Time over");
			}
		}
	}

	public void Pause() {
		isPaused = true;
	}

	public void Play() {
		isPaused = false;
	}
}
