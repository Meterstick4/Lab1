using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class WorldController : MonoBehaviour 
{
	public Object[] objects;
	void Start () 
	{
		DontDestroyOnLoad (GameObject.Find ("GameObject"));

		objects = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(SceneManager.GetActiveScene().buildIndex == 0)
		{
			objects = GameObject.FindGameObjectsWithTag("Player");
			if(objects.Length > 1)
			{
				Destroy (objects [1]);
			}

		}
		else if(SceneManager.GetActiveScene().buildIndex == 1)
		{
			objects = GameObject.FindGameObjectsWithTag("Player");
			if(objects.Length > 1)
			{
				Destroy (objects [1]);
			}
		}



	}
}
