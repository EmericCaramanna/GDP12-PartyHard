using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjPoto : MonoBehaviour {

    public GameObject _timerManager;
        //(TimeManager)

    public float _timeToDie;

	// Use this for initialization
	void Start () {
        _timeToDie = Random.Range(10.0f, 300.0f);
    }
	
	// Update is called once per frame
	void Update () {
		//check the _timeToDie <= TIME destroy
	}
}
