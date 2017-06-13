using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour {

	[HideInInspector]
	public float currentMoney;
	[HideInInspector]
	public float currentPercentAlcohol;
	[HideInInspector]
	public float currentPercentHealth;

	public Text moneyText;
	public Slider healthSlider;
	public Slider alcoholSlider;

	public float alcoholDecreaseRate;
	public float healthDecreaseRate;
	public float healthRegenRate;

	float previousAlcoholDecrease = 0f;
	float previousHealthDecrease = 0f;

	public float decreaseSpeed = 1;
	public bool isPlaying;
	public bool isRegen = false;

	void Start()
	{
		currentMoney = 400;
		currentPercentAlcohol = 50;
		currentPercentHealth = 100;
	}

	void OnEnable()
	{
		currentMoney = 400;
		currentPercentAlcohol = 50;
		currentPercentHealth = 100;
	}

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
		if (isPlaying) {
			moneyText.text = currentMoney + " $";
			if (Time.time > alcoholDecreaseRate + previousAlcoholDecrease) {
				previousAlcoholDecrease = Time.time;
				SubAlcohol (decreaseSpeed);
			}
			if (!isRegen && Time.time > healthDecreaseRate + previousHealthDecrease) {
				previousHealthDecrease = Time.time;
				SubHealth (decreaseSpeed);
			}
			if (isRegen && Time.time > healthRegenRate + previousHealthDecrease) {
				previousHealthDecrease = Time.time;
				AddHealth (decreaseSpeed);
			}
			healthSlider.value = currentPercentHealth / 100;
			alcoholSlider.value = currentPercentAlcohol / 100;
		}
	}
}
