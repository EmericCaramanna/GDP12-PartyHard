using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesManager : MonoBehaviour {

	public GameObject dance;
	public GameObject drink;
	public GameObject fight;
	public GameObject cop;
	public GameObject shifumi;
	public GameObject beerPong;

	public void LaunchGame(MiniGames.GameName gameName)
	{
		switch (gameName) {
		case MiniGames.GameName.Dance : 
			{
				break;
			}
		case MiniGames.GameName.Drink :
			{
				break;
			}
		case MiniGames.GameName.Fight :
			{
				break;
			}
		case MiniGames.GameName.Cop :
			{
				break;
			}
		case MiniGames.GameName.Shifumi :
			{
				break;
			}
		case MiniGames.GameName.BeerPong :
			{
				break;
			}
		}
	}
}
