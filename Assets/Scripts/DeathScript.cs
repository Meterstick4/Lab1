using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
	public GameObject player;
	public int playerHealth;
	// Use this for initialization
	void Start () 
	{
		playerHealth = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (playerHealth <= 0) 
		{
			Debug.Log ("Hello");
			Destroy (player);
		}
	}

	public void lowerHealth()
	{
		playerHealth--;
	}
}
