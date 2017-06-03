﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjBehaviour : MonoBehaviour {

    public GameObject _playerReference;
    public ResourceManager _ResourceManager;

    public enum Role
    {
        videur,
        barman,
        dealer,
        dj,
        policier
    }

    public Role     _id;
    AudioSource     _audioSource;
    BoxCollider2D   _boxCollider2D;
    SpriteRenderer  _sprite;

    // Function of Special Pnj
    void    Videur()
    {
        _playerReference.transform.position = new Vector3(2, 2, 0);
    }

    void    Barman()
    {
        _ResourceManager.AddAlcohol(20);
        _ResourceManager.AddMoney(-10);

    }

    void    Dealer()
    {

    }

    void    Dj()
    {

    }

    void    Police()
    {

    }

    // Use this for initialization
    void Start () {
        if (_audioSource = GetComponent<AudioSource>())
        {
           //
        }
        if (_boxCollider2D = GetComponent<BoxCollider2D>())
        {
            //
        }
        if (_sprite = GetComponent<SpriteRenderer>())
        {
            //
        }
    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseDown()
    {
        _audioSource.Play();
        if (_id == Role.videur)
            Videur();
        if (_id == Role.barman)
            Barman();
        if (_id == Role.dealer)
            Dealer();
        if (_id == Role.dj)
            Dj();
        if (_id == Role.policier)
            Police();
    }
}
