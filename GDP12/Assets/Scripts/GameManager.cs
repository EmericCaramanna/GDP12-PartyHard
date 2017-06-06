using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public GameObject UI;
	public GameObject endCanvas;
	public ResourceManager resourceManager;

	public Text endText;
	public Text endMessage;

	float timeLeft;

	void OnEnable()
	{
		timeLeft = 300f;
	}

	void Update()
	{
		/*
		if (resourceManager.isPlaying) {
			timeLeft -= Time.deltaTime;
			if (timeLeft <= 0f) {
				player.SetActive(false);
				UI.SetActive (false);
				endCanvas.SetActive (true);
				resourceManager.isPlaying = false;
				endText.text = "congratulation !";
				endMessage.text = "you did it ;)";
				gameObject.SetActive (false);
			}
			if (resourceManager.currentPercentAlcohol == 0 ||
			    resourceManager.currentPercentAlcohol > 95 ||
			    resourceManager.currentPercentHealth == 0) {
				player.SetActive(false);
				UI.SetActive (false);
				endCanvas.SetActive (true);
				resourceManager.isPlaying = false;
				endText.text = "You failed !";
				gameObject.SetActive (false);
				if (resourceManager.currentPercentAlcohol == 0) {
					endMessage.text = "You were too sober !";
				} else if (resourceManager.currentPercentAlcohol > 95) {
					endMessage.text = "you were wasted !";
				} else if (resourceManager.currentPercentHealth == 0) {
					endMessage.text = "you were too tired";
				}
			}
		}*/
	}

}
