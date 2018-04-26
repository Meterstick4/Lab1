using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour 
{
	public GameObject toDestroy;
	public GameObject promptText;
	public int valueBut;
	private bool buttonPressed;
	void Awake()
	{
		buttonPressed = false;
		promptText.SetActive (false);
	}



	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.CompareTag("PlayerArm"))
		{
			promptText.SetActive (true);

		}

	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag ("PlayerArm")) {
			if (Input.GetKeyDown ("e")) 
			{
				buttonPressed = true;
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		promptText.SetActive (false);
	}
	
	public int returnNumValue()
	{
		return valueBut;
	}
	public bool wasButtonPressed()
	{
		return buttonPressed;
	}

	public void finishButotnPress()
	{
		buttonPressed = false;
	}


}
