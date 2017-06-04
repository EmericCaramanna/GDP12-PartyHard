using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osu : MonoBehaviour {

    public enum idNote
    {
        UP,
        DOWN,
        RIGHT,
        LEFT
    }

    public idNote _id;
    Dance _refDance;
    bool _isActive;

    public void setActivate(bool value)
    {
        _isActive = value;
    }
	// Use this for initialization
	void Start () {
        _refDance = GetComponentInParent<Dance>();
        _isActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (_isActive)
        {
            _refDance.addScore(1);
            _isActive = false; 
        }
    }
}
