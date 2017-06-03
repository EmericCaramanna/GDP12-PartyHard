﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeerPong : MonoBehaviour {

	public Slider strength;
	public Image fill;
	public float variationRate;
	float previousVariation;
	public float sliderSpeed;
	int sign;
	RaycastHit2D hit;
	int numberOfThrowLeft;
	public ResourceManager resourceManager;

	void OnEnable()
	{
		previousVariation = 0f;
		sign = 1;
		numberOfThrowLeft = 2;
		previousVariation = 0f;
		hit = new RaycastHit2D ();
		strength.gameObject.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		if (numberOfThrowLeft > 0) {
			if (Time.time > variationRate + previousVariation) {
				previousVariation = Time.time;
				strength.value += sign * sliderSpeed / 100;
				if (strength.value >= 1 || strength.value <= 0)
					sign *= -1;
			}
			if (Input.GetMouseButtonDown (0)) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				hit = Physics2D.Raycast (ray.origin, ray.direction);
				if (hit.transform != null && hit.transform.CompareTag ("Player")) {
					if (strength.value > 0.5f && strength.value < 0.8f) {
						resourceManager.AddAlcohol (10);
						resourceManager.AddMoney (20);
					} else {
						resourceManager.AddAlcohol (40);
						resourceManager.SubMoney (20);
					}
					numberOfThrowLeft--;
					strength.value = 0f;
				}
			}
			if (strength.value > 0.5f && strength.value < 0.8f) {
				fill.color = Color.green;
			} else
				fill.color = Color.red;
		} else {
			strength.gameObject.SetActive(false);
			gameObject.SetActive(false);
		}
	}
}