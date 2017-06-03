using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjBehaviour : MonoBehaviour {

    public GameObject playerReference;

    public enum Role
    {
        randomGens,
        videur,
        barman
    }

    public Role     _id;
    AudioSource     _audioSource;
    BoxCollider2D   _boxCollider2D;
    SpriteRenderer  _sprite;

    Vector2         _posMouse;
    // Function of Special Pnj
    void    Videur()
    {

    }

    void    Barman()
    {

    }

    // Use this for initialization
	void Start () {

        _id = Role.randomGens;
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
    }
}
