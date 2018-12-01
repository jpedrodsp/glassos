using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookPopupHandler : MonoBehaviour {

	[Header("VARIABLES")]
	public Animator panelAnimator;

	private bool notificationOpen;
	private bool messagesOpen;
	private bool friendsOpen;

	void Start () 
	{

	}
		
	public void ClickNotification ()
	{
		if (notificationOpen == false && messagesOpen == false && friendsOpen == false) 
		{
			panelAnimator.Play ("FPN Fade-in");
			notificationOpen = true;
			messagesOpen = false;
			friendsOpen = false;
		} 

		else if (messagesOpen == true) 
		{
			panelAnimator.Play ("FPM to FPN");
			notificationOpen = true;
			messagesOpen = false;
			friendsOpen = false;
		} 

		else if (friendsOpen == true) 
		{
			panelAnimator.Play ("FPF to FPN");
			notificationOpen = true;
			messagesOpen = false;
			friendsOpen = false;
		}

		else if (notificationOpen == true)
		{
			panelAnimator.Play ("FPN Fade-out");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = false;
		}
	}

	public void ClickMessages () 
	{
		if (notificationOpen == false && messagesOpen == false && friendsOpen == false) 
		{
			panelAnimator.Play ("FPM Fade-in");
			notificationOpen = false;
			messagesOpen = true;
			friendsOpen = false;
		}

		else if (notificationOpen == true)
		{
			panelAnimator.Play ("FPN to FPM");
			notificationOpen = false;
			messagesOpen = true;
			friendsOpen = false;
		}

		else if (friendsOpen == true)
		{
			panelAnimator.Play ("FPF to FPM");
			notificationOpen = false;
			messagesOpen = true;
			friendsOpen = false;
		}

		else if (messagesOpen == true)
		{
			panelAnimator.Play ("FPM Fade-out");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = false;
		}
	}

	public void ClickFriends () 
	{
		if (notificationOpen == false && messagesOpen == false && friendsOpen == false) 
		{
			panelAnimator.Play ("FPF Fade-in");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = true;
		}

		else if (notificationOpen == true)
		{
			panelAnimator.Play ("FPN to FPF");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = true;
		}

		else if (messagesOpen == true)
		{
			panelAnimator.Play ("FPM to FPF");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = true;
		}

		else if (friendsOpen == true)
		{
			panelAnimator.Play ("FPF Fade-out");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = false;
		}
	}

	public void ClickAnother () 
	{
		if (notificationOpen == true)
		{
			panelAnimator.Play ("FPN Fade-out");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = false;
		}

		else if (messagesOpen == true)
		{
			panelAnimator.Play ("FPM Fade-out");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = false;
		}

		else if (friendsOpen == true)
		{
			panelAnimator.Play ("FPF Fade-out");
			notificationOpen = false;
			messagesOpen = false;
			friendsOpen = false;
		}
	}
}