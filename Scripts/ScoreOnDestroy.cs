using System.Collections;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour 
{

	public int scoreValue = 1;

	void OnDestroy()
	{
		GameController.score += scoreValue;
	}


}
