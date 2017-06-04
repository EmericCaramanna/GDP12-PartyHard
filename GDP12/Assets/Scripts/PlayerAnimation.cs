using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	Animator animator;
	PlayerMovement playerMovement;
	Vector3 scale;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerMovement = GetComponent<PlayerMovement> ();
		scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerMovement.diretion.x >= 0.5) {
			scale.x = 2;
			transform.localScale = scale;
			animator.SetInteger ("State", 2);
		}
		if (playerMovement.diretion.x <= -0.5) {
			scale.x = -2;
			transform.localScale = scale;
			animator.SetInteger ("State", 2);
		}
		if (playerMovement.diretion.y >= 0.5) {
			animator.SetInteger ("State", 0);
		}
		if (playerMovement.diretion.y <= -0.5) {
			animator.SetInteger ("State", 1);
		}
	}
}
