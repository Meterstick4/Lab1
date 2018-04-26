using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

	// The Static property pf this variable means the value
	// will be shared accross all instances of the coin class
	public static int CoinCount = 0;

	void Awake()
	{
		// Reset the coin count to zero each tme the scene is loaded
		Coin.CoinCount = 0;

	}

	void Start ()
	{
		//Object Created, increment coin count
		++Coin.CoinCount;
	}

	void OnTriggerEnter(Collider Col)
	{
		// IF the player is detected destroy this object
		if (Col.CompareTag("Player"))
		{
			Destroy (gameObject);
		}
			
	}

	void OnDestroy()
	{
		//object is destoryed, remove from the total coin count
		--Coin.CoinCount;

		// check remaining coins
		if(Coin.CoinCount <= 0)
		{
			// Game is won and all the coins are collected
			//Destroy the Timer and launch fireworks
			GameObject timer = GameObject.Find("LevelTimer");
			Destroy (timer);

			GameObject[] FireworkSystems = GameObject.FindGameObjectsWithTag ("Fireworks");
			foreach(GameObject GO in FireworkSystems)
			{
				GO.GetComponent<ParticleSystem> ().Play ();
			}
		}

	}
}
