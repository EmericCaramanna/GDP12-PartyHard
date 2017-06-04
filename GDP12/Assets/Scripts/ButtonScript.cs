using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public Canvas menuCanvas;
	public Canvas UI;
	public GameObject player;
	public ResourceManager resourceManager;
	public GameObject endCanvas;

	public void PlayClicked()
	{
		menuCanvas.gameObject.SetActive (false);
		UI.gameObject.SetActive(true);
		player.SetActive (true);
		resourceManager.isPlaying = true;
	}

	public void ExitClick()
	{
		Application.Quit ();
	}

	public void PlayAgain()
	{
		player.transform.position = new Vector2 (-2, -14);
		resourceManager.currentMoney = 400;
		resourceManager.currentPercentAlcohol = 50;
		resourceManager.currentPercentHealth = 100;
		endCanvas.SetActive(false);
		PlayClicked ();
	}
}
