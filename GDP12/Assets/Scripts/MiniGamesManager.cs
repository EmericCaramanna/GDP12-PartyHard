using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour {

    public enum GameName
    {
        Dance,
        Drink,
        //Fight,
        //Cop,
        Shifumi,
        BeerPong
    }

    public PlayerMovement player;

    public GameObject dance;
	public GameObject drink;
	//public GameObject fight;
	//public GameObject cop;
	public GameObject shifumi;
	public GameObject beerPong;
    
    SpriteRenderer _square;

    public float[] _timeCodeMinigame = { 150.0f, 225.0f };
    int[] _idMiniGame = new int[2];
    float _clock;
    float _timerGame1;
    float _timerGame2;

    void    Start()
    {
        _idMiniGame[0] = (int)Random.Range(0, 4.0f);
        while (_idMiniGame[0] == (_idMiniGame[1] = (int)Random.Range(0, 4.0f)));
        _square = GetComponent<SpriteRenderer>();
        _square.enabled = false;
        _timerGame1 = -1.0f;
        _timerGame2 = -1.0f;
    }

    public void takeOffSquare()
    {
        _square.enabled = false;
    }

    void    Update()
    {
        _clock += Time.deltaTime;
		if (Input.GetKey ("t")) {
			dance.SetActive (true);
			player.playingMiniGame = true;
		}
		if (Input.GetKey ("y")) {
			shifumi.SetActive (true);
			player.playingMiniGame = true;
		}
		if (Input.GetKey ("b")) {
			beerPong.SetActive (true);
			player.playingMiniGame = true;
		}
		if (Input.GetKey ("g")) {
			drink.SetActive (true);
			player.playingMiniGame = true;
		}
		if (_timerGame1 <= _clock && _timerGame1 != -1)
        {
            LaunchGame((GameName)_idMiniGame[0]);
            _timerGame1 = -1;
        }
        if (_timerGame2 <= _clock && _timerGame2 != -1)
        {
            LaunchGame((GameName)_idMiniGame[1]);
            _timerGame2 = -1;
        }
    }

    public void LaunchGame(GameName gameName)
	{
        _square.enabled = true;
        switch (gameName) {
		case GameName.Dance : 
			{
                dance.SetActive(true);
                player.playingMiniGame = true;
				break;
			}
		case GameName.Drink :
			{
                 drink.SetActive(true);
                 player.playingMiniGame = true;
                    break;
			}
		/*case GameName.Fight :
			{
                 fight.SetActive(true);
                    player.playingMiniGame = true;
                    break;
			}
		case GameName.Cop :
			{
                cop.SetActive(true);
                    player.playingMiniGame = true;
                    break;
			}*/
		case GameName.Shifumi :
			{
                shifumi.SetActive(true);
                    player.playingMiniGame = true;
                    break;
			}
		case GameName.BeerPong :
			{
                beerPong.SetActive(true);
                    player.playingMiniGame = true;
                    break;
			}
		}
	}
}
