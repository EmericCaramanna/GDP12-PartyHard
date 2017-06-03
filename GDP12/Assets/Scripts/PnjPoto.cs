using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjPoto : MonoBehaviour {

    public TimeManager _timerManager;

    public float _timeToDie;

	// Use this for initialization
	void Start () {
        _timeToDie = Random.Range(10.0f, _timerManager.timeLeft);
    }
	
	// Update is called once per frame
	void Update () {
        if (_timeToDie <= _timerManager.timeLeft)
            Destroy(gameObject);
	}
}
