using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameDisplay : MonoBehaviour {

	[SerializeField]
	GameObject[] miniGamesVisual;

	void OnEnable()
	{
		for (int i = 0; i < miniGamesVisual.Length; i++) {
			miniGamesVisual [i].SetActive (false);
		}
	}
}
