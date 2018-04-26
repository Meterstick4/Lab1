using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAfterComplete : MonoBehaviour 
{
	public int buttonsToPress;

	
	// Update is called once per frame
	void Update () 
	{
		if(buttonsToPress == 0)
		{
			Destroy (this.gameObject);
		}

	}
	public void setButton()
	{
		buttonsToPress = 0;
	}
}
