using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCodeScript : MonoBehaviour
{
	public GameObject[] buttons;
	public string code;
	public string playersCode;
	public void addToPlayerCode(int num)
	{
		playersCode += num.ToString();
	}
	void Update()
	{
		foreach(GameObject a in buttons)
		{
			if (a.GetComponent<Button> ().wasButtonPressed ()) 
			{
				addToPlayerCode (a.GetComponent<Button> ().returnNumValue ());

				a.GetComponent<Button> ().finishButotnPress ();
			}
		}
		if (playersCode.Equals (code)) {
			Debug.Log ("SuccessCode ");

		} 
		else if (playersCode.Length >= code.Length) 
		{
			playersCode = "";
			Debug.Log ("Fail");
		}

		
	}


	

}
