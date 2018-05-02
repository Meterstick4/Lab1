using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour 
{
	public GameObject spikes;
	private Animator spikeAnim;
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("JLKJKL");
		spikeAnim = spikes.GetComponent<Animator> ();
		spikeAnim.SetBool ("crush", true);
	}
	void OnTriggerExit(Collider other)
	{
		spikeAnim.SetBool ("crush", false);
	}
}
