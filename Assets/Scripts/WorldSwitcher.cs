using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WorldSwitcher : MonoBehaviour 
{
	public static GameObject player;
	public int toSwtich;
	public Vector3 orgLocat;
	public Vector3 tempLocat;
	public Vector3 toSwitchLocOneTime;
	private int switchTimes;
	public bool miniMapOpen;
	public GameObject map;

	// Use this for initialization
	void Awake () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		switchTimes = 0;
		//orgLocat = player.transform.position;
		toSwitchLocOneTime = new Vector3 (-360, 4, 1281);
		tempLocat = new Vector3 (0, 2, 0);
		DontDestroyOnLoad (player);
		miniMapOpen = false;


	}

	
	// Update is called once per frame
	void Update () 
	{
		

		if(Input.GetKeyDown("o") && switchTimes % 2 == 0)
		{
			if(orgLocat != player.transform.position)
			{
				tempLocat = player.transform.position;
			}
			SceneManager.LoadScene (++toSwtich);
			switchTimes++;
			player.transform.position = orgLocat;
			orgLocat = tempLocat;
		}
		else if(Input.GetKeyDown("o"))
		{
			Debug.Log ("HJKLJ");
			if(orgLocat != player.transform.position)
			{
				tempLocat = player.transform.position;
			}
			SceneManager.LoadScene (--toSwtich);
			switchTimes++;
			player.transform.position = orgLocat;
			orgLocat = tempLocat;
		}

		if(Input.GetKeyDown("m"))
		{
			if(!miniMapOpen)
			{
				map.SetActive (true);
				miniMapOpen = true;
				return;
			}
			else
			{
				map.SetActive (false);
				miniMapOpen = false;
				return;
			}

		}


	}

}
