using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationPopupDestroy : MonoBehaviour {


	void Update () 
	{
		GameObject[] gos = GameObject.FindGameObjectsWithTag("Notification Popup");
		foreach(GameObject go in gos)
			Destroy(go);
	}
}
