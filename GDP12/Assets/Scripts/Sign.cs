using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour {

    public enum IdSymbol
    {
        pierre,
        feuille,
        ciseaux
    }

    public IdSymbol _id;

    Shifumi _game;

	// Use this for initialization
	void Start () {
        _game = GetComponentInParent<Shifumi>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void    OnMouseDown()
    {
        _game._signPlayer = (int)_id;
    }
}
