using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {

	public float winkFrequency;
	float lastWink = 0f;

	SpriteRenderer spriteRenderer;
	public Sprite[] sprites;
	int lightIndex;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		lightIndex = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > winkFrequency + lastWink) {
			lastWink = Time.time;
			spriteRenderer.sprite = sprites [lightIndex];
			lightIndex = (lightIndex + 1 == 3) ? 0 : lightIndex + 1;
		}
		
	}
}
