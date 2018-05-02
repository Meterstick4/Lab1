using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablingLever : MonoBehaviour 
{
	public GameObject toDisables;

	

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag ("PlayerArm")) {
			if (Input.GetKeyDown ("e")) 
			{
				toDisables.GetComponent<BoxCollider> ().isTrigger = false;
			}
		}
	}
}
