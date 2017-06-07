using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerpongPNJ : MonoBehaviour {

	public GameObject board;
	public GameObject beerpongVisual;
	public MiniGamesManager miniGame;

	void OnMouseDown()
	{
		board.transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y, board.transform.position.z);
		board.SetActive(true);
		beerpongVisual.SetActive (true);
		miniGame.LaunchGame (MiniGamesManager.GameName.BeerPong);
	}
}
