using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

	public Transform playerTransform;

	Vector3 position = new Vector3();
	
	// Update is called once per frame
	void Update () {
		position = playerTransform.position;
		position.z = transform.position.z;
		transform.position = position;
	}
}
