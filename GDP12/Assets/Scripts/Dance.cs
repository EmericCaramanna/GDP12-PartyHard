using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour {

    int _scorePlayer;
    float _timeLeft;
    float _timerNextNote;
    bool _checkSound;
    public AudioClip _sucess;
    public AudioClip _fail;
    int _idNote;
    Osu[] _note;

    public GameObject _frameBoard;
    public PlayerMovement _refPlayer;
    public ResourceManager _refResourceManager;

    public int     getScore()
    {
        return _scorePlayer;
    }

    public void    addScore(int value)
    {
        _scorePlayer += value;
        _checkSound = true;
        _timerNextNote = 0;
        _idNote = 0;
        _note[_idNote].son.PlayOneShot(_sucess);
        Debug.Log("Score = " + _scorePlayer);
    }

    void OnEnable ()
    {
        _timeLeft = 10.0f;
        _scorePlayer = 0;
        _timerNextNote = 1.0f;
        _note = GetComponentsInChildren<Osu>();
        _checkSound = false;
    }

	// Use this for initialization
	void Start () {
        _scorePlayer = 0;
        _timerNextNote = 1.0f;
        _note = GetComponentsInChildren<Osu>();
        _checkSound = false;
    }
	
	// Update is called once per frame
	void Update () {
        _timerNextNote -= Time.deltaTime;
        _timeLeft -= Time.deltaTime;
        if (_timerNextNote <= 0)
        {
            if (!_checkSound)
                _note[_idNote].son.PlayOneShot(_fail);
            foreach (Osu tmp in _note)
                tmp.setActivate(false);
            _note[_idNote = (int)Random.Range(0f, 4.0f)].setActivate(true);
            _note[4].setPos(_note[_idNote].transform.position);
            _timerNextNote = 1.0f;
            _checkSound = false;
        }
        if (_timeLeft <= 0)
        {
            _refResourceManager.AddMoney(_scorePlayer);
            _refResourceManager.AddHealth(-20);
            GetComponentInParent<MiniGamesManager>().takeOffSquare();
            _refPlayer.playingMiniGame = false;
            gameObject.SetActive(false);
            _frameBoard.SetActive(false);
        }
	}
}
