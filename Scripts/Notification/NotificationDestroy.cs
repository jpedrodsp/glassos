using System.Collections;
using UnityEngine;

public class NotificationDestroy : MonoBehaviour {

	public GameObject notificationObject;

	void Start () 
	{
		Destroy (notificationObject);
	}
}
