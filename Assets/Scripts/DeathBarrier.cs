using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrier : MonoBehaviour 
{
	public GameObject player;

	void  OnTriggerEnter(Collider collision)
	{

		if (collision.gameObject.CompareTag("Player"))
		{
			Destroy (player);

		}
	}
}
