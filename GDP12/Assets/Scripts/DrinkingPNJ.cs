using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkingPNJ : MonoBehaviour {

	public GameObject frameBoard;
	public GameObject drinkingVisual;
	public MiniGamesManager miniGame;

	void OnMouseDown()
	{
		frameBoard.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, frameBoard.transform.position.z);
		frameBoard.SetActive (true);
		drinkingVisual.SetActive (true);
		miniGame.LaunchGame (MiniGamesManager.GameName.Drink);
	}
}
