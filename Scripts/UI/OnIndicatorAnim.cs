using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnIndicatorAnim : MonoBehaviour {

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

	#region Common codes
	public void SetGalleryRedirectFalse ()
	{
		galleryRedirectFromFiles = false;
	}

	public void SetGalleryRedirectTrue ()
	{
		galleryRedirectFromFiles = true;
	}

	public void setNone ()
	{
		currentApp = CurrentApp.NONE;
	}

	public void PCButton ()
	{
		if (currentApp == CurrentApp.GALLERY) 
		{
			pcAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			pcAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			pcAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			pcAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			pcAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			pcAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			pcAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			pcAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			pcAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			pcAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			pcPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			pcAnimator.Play ("TB Indicator On");

			pcPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.PC;
	}

	public void Gallery ()
	{
		// REDIRECT FROM FILE BROWSER
		if (galleryRedirectFromFiles == true) 
		{
			galleryAnimator.Play ("TB Indicator On");

			galleryPanel.Play ("App Fade-in");
		}

		else
		{
			galleryAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}
		// REDIRECT FROM FILE BROWSER

		if (currentApp == CurrentApp.YOUTUBE) 
		{
			galleryAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			galleryAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			galleryAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			galleryAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			galleryAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			galleryAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			galleryAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			galleryAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			galleryAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			galleryPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			galleryAnimator.Play ("TB Indicator On");

			galleryPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.GALLERY;
	}

	public void YTButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			youtubeAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			youtubePanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}


		else if (currentApp == CurrentApp.NONE) 
		{
			youtubeAnimator.Play ("TB Indicator On");

			youtubePanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.YOUTUBE;
	}

	public void FBButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			facebookAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			facebookAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			facebookAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			facebookAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			facebookAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			facebookAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			facebookAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			facebookAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			facebookAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			facebookAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			facebookPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			facebookAnimator.Play ("TB Indicator On");

			facebookPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.FACEBOOK;
	}

	public void DumpButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			dumpAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			dumpAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			dumpAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			dumpAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			dumpAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			dumpAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			dumpAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			dumpAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			dumpAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			dumpAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			dumpPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			dumpAnimator.Play ("TB Indicator On");

			dumpPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.DUMP;
	}

	public void MediaPlayerButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			mediaPlayerPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			mediaPlayerAnimator.Play ("TB Indicator On");

			mediaPlayerPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.MEDIA_PLAYER;
	}

	public void WebBrowserButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			webBrowserAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			webBrowserPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			webBrowserAnimator.Play ("TB Indicator On");

			webBrowserPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.WEB_BROWSER;
	}

	public void EmailButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			emailAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			emailAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			emailAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			emailAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			emailAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			emailAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			emailAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			emailAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			emailAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			emailAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			emailPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			emailAnimator.Play ("TB Indicator On");

			emailPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.EMAIL;
	}

	public void StoreButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			storeAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			storeAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			storeAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			storeAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			storeAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			storeAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			storeAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			storeAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			storeAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			storeAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			storePanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			storeAnimator.Play ("TB Indicator On");

			storePanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.STORE;
	}

	public void NotepadButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			notepadAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			notepadAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			notepadAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			notepadAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			notepadAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			notepadAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			notepadAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			notepadAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			notepadAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.SETTINGS) 
		{
			notepadAnimator.Play ("TB Indicator On");
			settingsAnimator.Play ("TB Indicator Off");

			notepadPanel.Play ("App Fade-in");
			settingsPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			notepadAnimator.Play ("TB Indicator On");

			notepadPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.NOTEPAD;
	}

	public void SettingsButton ()
	{
		galleryRedirectFromFiles = false;

		if (currentApp == CurrentApp.GALLERY) 
		{
			settingsAnimator.Play ("TB Indicator On");
			galleryAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			galleryPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.PC) 
		{
			settingsAnimator.Play ("TB Indicator On");
			pcAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			pcPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.YOUTUBE) 
		{
			settingsAnimator.Play ("TB Indicator On");
			youtubeAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			youtubePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.FACEBOOK) 
		{
			settingsAnimator.Play ("TB Indicator On");
			facebookAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			facebookPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.DUMP) 
		{
			settingsAnimator.Play ("TB Indicator On");
			dumpAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			dumpPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.MEDIA_PLAYER) 
		{
			settingsAnimator.Play ("TB Indicator On");
			mediaPlayerAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			mediaPlayerPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.WEB_BROWSER) 
		{
			settingsAnimator.Play ("TB Indicator On");
			webBrowserAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			webBrowserPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.EMAIL) 
		{
			settingsAnimator.Play ("TB Indicator On");
			emailAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			emailPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.STORE) 
		{
			settingsAnimator.Play ("TB Indicator On");
			storeAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			storePanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NOTEPAD) 
		{
			settingsAnimator.Play ("TB Indicator On");
			notepadAnimator.Play ("TB Indicator Off");

			settingsPanel.Play ("App Fade-in");
			notepadPanel.Play ("App Fade-out");
		}

		else if (currentApp == CurrentApp.NONE) 
		{
			settingsAnimator.Play ("TB Indicator On");

			settingsPanel.Play ("App Fade-in");
		}
		currentApp = CurrentApp.SETTINGS;
	}
	#endregion
}