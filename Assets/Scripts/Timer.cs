using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour 
{
	//Maximum time to complet the level in seconds
	public float maxTime = 60f;

	// Force the private variable Countdown to be seen in the 
	//in the Unity Editor

	[SerializeField]
	private float countDown = 0;


	// Use this for initialization
	void Start () 
	{
		countDown = maxTime;
	}
	
	// Update is called once per frame
	void Update () 
	{
		countDown -= Time.deltaTime;

		//restart the level if time runs out
		if(countDown <= 0)
		{
			//reset coin count
			Coin.CoinCount = 0;
			SceneManager.LoadScene ("Scene01");
		}
	}
}
