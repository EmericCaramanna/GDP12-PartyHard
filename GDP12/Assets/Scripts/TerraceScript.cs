using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerraceScript : MonoBehaviour {

	public ResourceManager manager;

	void OnTriggerEnter2D()
	{
		manager.isRegen = true;
	}

	void OnTriggerExit2D()
	{
		manager.isRegen = false;
	}
}
