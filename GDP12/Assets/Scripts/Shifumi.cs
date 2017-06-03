using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifumi : MonoBehaviour {

    enum Symboru
    {
        pierre,
        feuille,
        ciseaux
    }

    enum resultGame
    {
        win,
        lose,
        again
    }

    bool play;
    public int _signPlayer;
    resultGame ah;
    
    void OnEnable ()
    {
        play = false;
        _signPlayer = -1;
    }

	// Use this for initialization
	void Start () {
        play = false;
        _signPlayer = -1;
	}
	
	// Update is called once per frame
	void Update () {
        if (!play && _signPlayer != -1)
        {
            play = true;
            int signIA = (int)Random.Range(0f, 2.0f);
            if (_signPlayer == (int)Symboru.pierre)
            {
                if (signIA == (int)Symboru.pierre)
                    ah = resultGame.again;
                else if (signIA == (int)Symboru.feuille)
                    ah = resultGame.lose;
                else
                    ah = resultGame.win;
            }
            else if (_signPlayer == (int)Symboru.feuille)
            {
                if (signIA == (int)Symboru.pierre)
                    ah = resultGame.win;
                else if (signIA == (int)Symboru.feuille)
                    ah = resultGame.again;
                else
                    ah = resultGame.lose;
            }
            else if (_signPlayer == (int)Symboru.ciseaux)
            {
                if (signIA == (int)Symboru.pierre)
                    ah = resultGame.lose;
                else if (signIA == (int)Symboru.feuille)
                    ah = resultGame.win;
                else
                    ah = resultGame.again;
            }
            if (ah == resultGame.again)
            {
                _signPlayer = -1;
                play = false;
                Debug.Log("again");
            }
            else if (ah == resultGame.win)
                Debug.Log("win");
            else if (ah == resultGame.lose)
                Debug.Log("lose");
        }
       
    }
}
