using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
	public GameObject key;
	void OnTriggerEnter(Collider other)
	{
		Destroy (key);

	}
}
