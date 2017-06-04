using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	Animator animator;
	PlayerMovement playerMovement;
	Vector3 scale;
	public bool drink = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerMovement = GetComponent<PlayerMovement> ();
		scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerMovement.diretion.x >= 0.5) {

		}
		if (playerMovement.diretion.x <= -0.5) {

		}
		if (playerMovement.diretion.y >= 0.5) {

		}
		if (playerMovement.diretion.y <= -0.5) {
		}
		if (drink) {
			drink = false;
		}
		if (playerMovement.idle) {
		}
	}

	public void AnimRight()
	{
		scale.x = 2;
		transform.localScale = scale;
		animator.SetInteger ("State", 2);
	}

	public void AnimLeft()
	{
		scale.x = -2;
		transform.localScale = scale;
		animator.SetInteger ("State", 2);
	}

	public void AnimTop()
	{
		animator.SetInteger ("State", 0);
	}

	public void AnimDown()
	{
		animator.SetInteger ("State", 1);
	}

	public void AnimDrink()
	{
		animator.SetInteger ("State", 4);
	}

	public void AnimIdle()
	{
		animator.SetInteger("State", 3);
	}
}
