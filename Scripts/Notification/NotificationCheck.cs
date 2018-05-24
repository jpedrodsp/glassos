using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationCheck : MonoBehaviour {

	public GameObject closeButton;
	public int childs;
	public Animator noNotText;
	public bool isCleaned = false;

	void Start ()
	{
		childs = transform.childCount;

		if (childs == 0) {
			noNotText.Play ("NNN Fade-in");
			isCleaned = true;
			closeButton.SetActive (false);
		} 

		else if (childs >= 0 && isCleaned == true)
		{
			noNotText.Play ("NNN Fade-out");
			closeButton.SetActive (true);
		}
	}

	void Update ()
	{
		childs = transform.childCount;

		if (childs == 0) {
			noNotText.Play ("NNN Fade-in");
			isCleaned = true;
			closeButton.SetActive (false);
		} 

		else if (childs >= 0 && isCleaned == true)
		{
			noNotText.Play ("NNN Fade-out");
			closeButton.SetActive (true);
		}
	}

	public void CountNotifications ()
	{
		childs = transform.childCount;

		if (childs == 0) {
			noNotText.Play ("NNN Fade-in");
			isCleaned = true;
		} 

		else if (childs >= 0 && isCleaned == true)
		{
			noNotText.Play ("NNN Fade-out");
		}
	}
}
