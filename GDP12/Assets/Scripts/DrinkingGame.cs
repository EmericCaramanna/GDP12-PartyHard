using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkingGame : MonoBehaviour {

	int drinkingScore;
	float drinkingTimeLeft;
	bool drinkingPlaying;

	public ResourceManager resourceManager;

	void OnEnable()
	{
		drinkingTimeLeft = 10f;
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
				if (hit.transform != null && hit.transform.CompareTag ("Player")) {
					drinkingScore += 1;
				}
			}
		} else {
			if (drinkingScore > 30) {
				resourceManager.AddMoney (50);
				resourceManager.AddAlcohol (20);
				gameObject.SetActive (false);
			}
		}
	}
}
