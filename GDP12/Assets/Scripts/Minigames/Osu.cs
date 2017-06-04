using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osu : MonoBehaviour {

    public enum idNote
    {
        UP,
        DOWN,
        RIGHT,
        LEFT,
        SELECT
    }

    public idNote _id;
    Dance _refDance;
    bool _isActive;

    public AudioSource son;

    public void setPos(Vector3 nPos)
    {
        transform.position = nPos;
    }

    public void setActivate(bool value)
    {
        if (_id != idNote.SELECT) 
            _isActive = value;
    }
	// Use this for initialization
	void Start () {
        _refDance = GetComponentInParent<Dance>();
        _isActive = false;
        son = GetComponent<AudioSource>();
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
