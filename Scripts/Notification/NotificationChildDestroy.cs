using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationChildDestroy : MonoBehaviour {


	void Update () 
	{
		GameObject[] gos = GameObject.FindGameObjectsWithTag("Notification");
		foreach(GameObject go in gos)
			Destroy(go);
	}
}
