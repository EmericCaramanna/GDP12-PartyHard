﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour {

    public enum GameName
    {
        Dance,
        Drink,
        Fight,
        Cop,
        Shifumi,
        BeerPong
    }

    public GameObject dance;
	public GameObject drink;
	public GameObject fight;
	public GameObject cop;
	public GameObject shifumi;
	public GameObject beerPong;
    
    SpriteRenderer _square;

    float[] _timeCodeMinigame = { 150.0f, 225.0f };
    int[] _idMiniGame = new int[2];

    void    Start()
    {
        _idMiniGame[0] = (int)Random.Range(0, 5.0f);
        while (_idMiniGame[0] == (_idMiniGame[1] = (int)Random.Range(0, 5.0f)));
        _square = GetComponent<SpriteRenderer>();
        _square.enabled = false;
    }


    public void LaunchGame(GameName gameName)
	{
        _square.enabled = true;
        switch (gameName) {
		case GameName.Dance : 
			{
                dance.SetActive(true);
				break;
			}
		case GameName.Drink :
			{
                 drink.SetActive(true);
                 break;
			}
		case GameName.Fight :
			{
                 fight.SetActive(true);
                 break;
			}
		case GameName.Cop :
			{
                cop.SetActive(true);
                break;
			}
		case GameName.Shifumi :
			{
                shifumi.SetActive(true);
                break;
			}
		case GameName.BeerPong :
			{
                beerPong.SetActive(true);
                break;
			}
		}
	}
}