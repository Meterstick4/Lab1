using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	//Game Score
	public static int score;

	//Prefix
	public string scorePrefix = string.Empty;

	//Score text object 
	public Text scoreText = null;

	public static GameController thisInstance = null;

	void Awake()
	{
		thisInstance = this;
	}

	void Update () 
	{
		//Update the score
		if(scoreText != null)
		{
			scoreText.text = scorePrefix + score.ToString ();
		}
	}
}
