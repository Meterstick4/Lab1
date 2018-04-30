using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class WorldController : MonoBehaviour 
{
	public Object[] objects;
	public Object[] audios;
	void Start () 
	{
		DontDestroyOnLoad (GameObject.FindGameObjectWithTag ("Player"));
		DontDestroyOnLoad (GameObject.FindGameObjectWithTag ("Audio"));

		audios = GameObject.FindGameObjectsWithTag ("Audio");
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
			audios = GameObject.FindGameObjectsWithTag ("Audio");
			if(audios.Length > 1)
			{
				Destroy (audios [1]);
			}
		}
		else if(SceneManager.GetActiveScene().buildIndex == 1)
		{
			audios = GameObject.FindGameObjectsWithTag ("Audio");
			objects = GameObject.FindGameObjectsWithTag("Player");
			if(objects.Length > 1)
			{
				Destroy (objects [1]);
			}
			if(audios.Length > 1)
			{
				Destroy (audios [1]);
			}
		}



	}
}
