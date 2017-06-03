﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour {

	public float currentMoney;
	public float currentPercentAlcohol;
	public float currentPercentHealth;
	public Text moneyText;
	public Slider healthSlider;
	public Slider alcoholSlider;
	public float alcoholDecreaseRate;
	public float healthDecreaseRate;
	float previousAlcoholDecrease = 0f;
	float previousHealthDecrease = 0f;
	public float decreaseSpeed = 1;

	public void AddAlcohol(float value)
	{
		currentPercentAlcohol = (currentPercentAlcohol + value > 100) ? 100 : currentPercentAlcohol + value;
	}

	public void AddHealth(float value)
	{
		currentPercentHealth = (currentPercentHealth + value > 100) ? 100 : currentPercentHealth + value;
	}

	public void AddMoney(float value)
	{
		currentMoney += value;
	}

	public void SubAlcohol(float value)
	{
		currentPercentAlcohol = (currentPercentAlcohol - value < 0) ? 0 : currentPercentAlcohol - value;
	}

	public void SubHealth(float value)
	{
		currentPercentHealth = (currentPercentHealth - value < 0) ? 0 : currentPercentHealth - value;
	}

	public void SubMoney(float value)
	{
		currentMoney = (currentMoney - value < 0) ? 0 : currentMoney - value;
	}

	void Update()
	{
		moneyText.text = currentMoney + " $";
		if (Time.time > alcoholDecreaseRate + previousAlcoholDecrease) {
			previousAlcoholDecrease = Time.time;
			SubAlcohol (decreaseSpeed);
		}
		if (Time.time > healthDecreaseRate + previousHealthDecrease) {
			previousHealthDecrease = Time.time;
			SubHealth (decreaseSpeed);
		}
		healthSlider.value = currentPercentHealth / 100;
		alcoholSlider.value = currentPercentAlcohol / 100;
	}
}
