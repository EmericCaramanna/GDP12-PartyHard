using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancePnj : MonoBehaviour {

    public GameObject _board;
    public GameObject _danceVisual;
    public MiniGamesManager miniGame;

    void OnMouseDown()
    {
        _board.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, _board.transform.position.z);
        _board.SetActive(true);
        _danceVisual.SetActive(true);
        miniGame.LaunchGame(MiniGamesManager.GameName.Dance);
    }
}
