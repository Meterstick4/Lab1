using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAndKey : MonoBehaviour 
{
	public GameObject key;
	public GameObject door;
	
	// Update is called once per frame
	void Update () 
	{
		if (key==null) {
			door.GetComponent<BoxCollider> ().isTrigger = true;
		}
	}
}
