using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {

	public float winkFrequency;
	float lastWink = 0f;

	SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > winkFrequency + lastWink) {
			lastWink = Time.time;
			sprite.enabled = !sprite.enabled;
		}
		
	}
}
