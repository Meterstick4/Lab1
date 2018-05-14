using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraa : MonoBehaviour 
{
	public GameObject player;
	public bool LeftRightZ = true;
	public float ViewDistance;
	public float EyeScanZ;
	void Awake()
	{
		ViewDistance = 20f;
		EyeScanZ = transform.position.z;
	}
	// Update is called once per frame
	void Update () 
	{
		if(LeftRightZ)
		{
			if(EyeScanZ < 60)
			{
				EyeScanZ += 10 * Time.deltaTime;
			}
			else
			{
				LeftRightZ = false;
			}
		}
		else
		{
			if (EyeScanZ > -60)
			{
				EyeScanZ -= 10 * Time.deltaTime;
			}
			else
			{
				LeftRightZ = true;
			}
		}
		GameObject.FindGameObjectWithTag ("camba").transform.localEulerAngles = new Vector3(0,EyeScanZ);
		GameObject.FindGameObjectWithTag ("camba").transform.Rotate (new Vector3 (45, 0, 0));


		RaycastHit hit;
		Debug.DrawRay(GameObject.FindGameObjectWithTag ("camba").transform.position, GameObject.FindGameObjectWithTag ("camba").transform.forward * ViewDistance);

		if (Physics.Raycast(GameObject.FindGameObjectWithTag ("camba").transform.position, GameObject.FindGameObjectWithTag ("camba").transform.forward * ViewDistance, out hit, ViewDistance))
		{
			
			if(hit.transform.gameObject.tag == "Player")
			{
				Debug.Log(gameObject.name + " CAN see Player");
			}

		}

			

	}
}
