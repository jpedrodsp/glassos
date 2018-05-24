using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSwitching : MonoBehaviour {

	[Header("PANEL ANIMATORS")]
	public Animator pcPanel;
	public Animator galleryPanel;
	public Animator youtubePanel;
	public Animator facebookPanel;
	public Animator dumpPanel;
	public Animator mediaPlayerPanel;
	public Animator webBrowserPanel;
	public Animator emailPanel;
	public Animator storePanel;
	public Animator notepadPanel;
	public Animator settingsPanel;

	[Header("BUTTON ANIMATORS")]
	public Animator pcAnimator;
	public Animator galleryAnimator;
	public Animator youtubeAnimator;
	public Animator facebookAnimator;
	public Animator dumpAnimator;
	public Animator mediaPlayerAnimator;
	public Animator webBrowserAnimator;
	public Animator emailAnimator;
	public Animator storeAnimator;
	public Animator notepadAnimator;
	public Animator settingsAnimator;

	[Header("PHONE EXCLUSIVE ANIMATORS")]
	public Animator startScreen;

	[Header("SETTINGS")]
	public CurrentApp currentApp;
	private bool galleryRedirectFromFiles = false;

	public enum CurrentApp
	{
		NONE,
		PC,
		GALLERY,
		YOUTUBE,
		FACEBOOK,
		DUMP,
		MEDIA_PLAYER,
		WEB_BROWSER,
		EMAIL,
		STORE,
		NOTEPAD,
		SETTINGS,
		PHONE_HOME
	}


	#region Phone Home Button
	public void PhoneHomeButton ()
	{
		if (currentApp == CurrentApp.GALLERY) 
		{
			galleryAnimator.Play ("TB Indicator Off");
			galleryPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			youtubeAnimator.Play ("TB Indicator Off");
			youtubePanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			facebookAnimator.Play ("TB Indicator Off");
			facebookPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			dumpAnimator.Play ("TB Indicator Off");
			dumpPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			mediaPlayerAnimator.Play ("TB Indicator Off");
			mediaPlayerPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			webBrowserAnimator.Play ("TB Indicator Off");
			webBrowserPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			emailAnimator.Play ("TB Indicator Off");
			emailPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			storeAnimator.Play ("TB Indicator Off");
			storePanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			notepadAnimator.Play ("TB Indicator Off");
			notepadPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			settingsAnimator.Play ("TB Indicator Off");
			settingsPanel.Play ("App Fade-out");

			startScreen.Play ("");
			startScreen.Play ("Home Screen In");
		}

		else if (currentApp == CurrentApp.NONE) 
		{

		}
		currentApp = CurrentApp.NONE;
	}
	#endregion

	#region App Buttons
	public void MediaPlayerNormal ()
	{
		if (currentApp == CurrentApp.NONE) 
		{
			startScreen.Play ("Home Screen Out");
			mediaPlayerAnimator.Play ("App Fade-in");
		}
		currentApp = CurrentApp.MEDIA_PLAYER;
	}
	#endregion
}
