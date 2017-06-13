using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	Animator animator;
	Vector3 scale;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		scale = transform.localScale;
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
