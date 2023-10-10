using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tObstacleScript : MonoBehaviour {

	public static bool tObstacle = false;

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			tObstacle = true;
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			tObstacle = false;
		} 

	}
}
