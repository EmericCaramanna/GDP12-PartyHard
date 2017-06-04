using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5f;
	public bool playingMiniGame = false;
	Rigidbody2D rigibody;
	public bool idle = true;
	public PlayerAnimation anim;
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
				if (rigibody) {
					if (ray.origin != transform.position) {
						rigibody.velocity = diretion * speed;
					} else
						rigibody.velocity = Vector2.zero;
					if (diretion.x >= 0.5) {
						anim.AnimRight ();
					}
					if (diretion.x <= -0.5) {
						anim.AnimLeft ();
					}
					if (diretion.y >= 0.5) {
						anim.AnimTop();
					}
					if (diretion.y <= -0.5) {
						anim.AnimDown ();
					}
				}
			}
			if (Input.GetButtonUp("Fire1")) {
				if (rigibody) {
					rigibody.velocity = Vector2.zero;
					diretion = Vector2.zero;
					anim.AnimIdle ();
				}
			}
		}
	}
}
