using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkingGame : MonoBehaviour {

	int drinkingScore;
	float drinkingTimeLeft;
	bool drinkingPlaying;

	public ResourceManager resourceManager;
	public PlayerMovement player;
	public GameObject gameVisual;
	public GameObject frameBoard;

	void OnEnable()
	{
		drinkingTimeLeft = 5f;
	}

	void Update()
	{
		DrinkLogic ();
	}

	void DrinkLogic()
	{
		drinkingTimeLeft -= Time.deltaTime;

		if (drinkingTimeLeft > 0) {
			if (Input.GetMouseButtonDown (0)) {
				RaycastHit2D hit = new RaycastHit2D ();
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				hit = Physics2D.Raycast (ray.origin, ray.direction);
				if (hit.transform != null && hit.transform.CompareTag ("MiniGame")) {
					drinkingScore += 1;
					gameVisual.GetComponent<Animator> ().SetInteger ("Trigger", 0);
				}
			}
		} else {
			if (drinkingScore > 10) {
				resourceManager.AddMoney (50);
				resourceManager.AddAlcohol (20);
			}
			drinkingTimeLeft = 5f;
			drinkingScore = 0;
			player.playingMiniGame = false;
			GetComponentInParent<MiniGamesManager>().takeOffSquare();
			frameBoard.SetActive (false);
			gameVisual.SetActive (false);
			gameObject.SetActive (false);
		}
	}
}
