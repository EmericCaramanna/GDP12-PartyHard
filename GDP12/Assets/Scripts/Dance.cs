using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour {

    int _scorePlayer;
    float _timerNextNote;
    Osu[] _note;

    public int     getScore()
    {
        return _scorePlayer;
    }

    public void    addScore(int value)
    {
        _scorePlayer += value;
        _timerNextNote = 0;
        Debug.Log("Score = " + _scorePlayer);
    }

	// Use this for initialization
	void Start () {
        _scorePlayer = 0;
        _timerNextNote = 1.0f;
        _note = GetComponentsInChildren<Osu>();
        _note[1].setActivate(true);
	}

    int debug = 0;
	
	// Update is called once per frame
	void Update () {
        _timerNextNote -= Time.deltaTime;
        if (_timerNextNote <= 0)
        {
            foreach (Osu tmp in _note)
                tmp.setActivate(false);
            _note[debug = (int)Random.Range(0f, 4.0f)].setActivate(true);
            Debug.Log("Note to fap" + debug);
            _timerNextNote = 1.0f;
        }
	}
}
