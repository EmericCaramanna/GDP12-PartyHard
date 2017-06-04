using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5f;
	public bool playingMiniGame = false;
	Rigidbody2D rigibody;

	public Vector2 diretion;

	void Start()
	{
		rigibody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate()
	{
		ManageInput ();
	}

	void ManageInput()
	{
		if (!playingMiniGame) {
			if (Input.GetButton ("Fire1")) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				diretion = new Vector2(ray.origin.x - transform.position.x, ray.origin.y - transform.position.y);
				diretion.Normalize ();
//				transform.Translate (diretion * speed);
				if (rigibody) {
					if (ray.origin != transform.position) {
						rigibody.velocity = diretion * speed;
					} else
						rigibody.velocity = Vector2.zero;
				}
			}
			if (Input.GetButtonUp("Fire1")) {
				if (rigibody) {
					rigibody.velocity = Vector2.zero;
				}
			}
		}
	}

	void OnCollisionEnter2D()
	{
		
	}
}
