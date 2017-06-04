using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloakroom : MonoBehaviour {

    float _timeToSteal;
    bool _playerHere;
    public PlayerMovement _refPlayer;
    public ResourceManager _refResourceManger;

	// Use this for initialization
	void Start () {
        _playerHere = false;
        _timeToSteal = 2.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (_playerHere)
            _timeToSteal -= Time.deltaTime;
        if (_timeToSteal <= 0 && _playerHere)
            _refPlayer.transform.position = new Vector3(-4, 0, 0);
    }

    void OnTriggerEnter2D()
    {
        _refPlayer.playingMiniGame = true;
        _refPlayer.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        _playerHere = true;
    }

    void OnTriggerExit2D()
    {
        _refPlayer.playingMiniGame = false;
        _playerHere = false;
        Debug.Log("raear");
    }

    void OnMouseDown()
    {
        if (_playerHere)
            _refResourceManger.AddMoney(2);
    }
}
