using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameDisplay : MonoBehaviour {

	public MiniGamesManager.GameName name;
	[SerializeField]
	GameObject[] miniGamesVisual;

	void OnEnable()
	{
		for (int i = 0; i < miniGamesVisual.Length; i++) {
			miniGamesVisual [i].SetActive (false);
		}
//		miniGamesVisual [(int)name].SetActive (true);
	}
}
