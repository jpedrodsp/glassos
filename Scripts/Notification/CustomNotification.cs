using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomNotification : MonoBehaviour {

	[Header("MAIN SCRIPT")]
	public CreateNotification createNotification;

	[Header("VARIABLES")]
	public Sprite newAppIcon;
	public Sprite newPopupIcon;
	public string newAppTitle;
	public string newDescTitle;
	public string newDescription;

	[Header("MUSIC NOTIFICATION")]
	public bool isMusicNtf = false;
	public Image songCover;
	public Image notificationCover;
	public Text songTitle;
	public Text artistTitle;
	public Text ntfSongTitle;
	public Text ntfArtistTitle;

	[Header("PROGRESS NOTIFICATION")]
	public ProgressBar pbScript;
	[Range(0, 100)] public float pbCurrentPercent;
	[Range(0, 100)] public int pbSpeed;

	[Header("POPUP NOTIFICATION")]
	[Range(0, 255)] public int colorR;
	[Range(0, 255)] public int colorG;
	[Range(0, 255)] public int colorB;

	public void SetTitles () 
	{
		createNotification.appIcon = newAppIcon;
		createNotification.appTitle = newAppTitle;
		createNotification.descTitle = newDescTitle;
		createNotification.description = newDescription;
	}

	public void SetPopupNotification () 
	{
		createNotification.headerColor.r = colorR;
		createNotification.headerColor.g = colorG;
		createNotification.headerColor.b = colorB;
		createNotification.headerObject.GetComponent<Image>().color = new Color32((byte)colorR, (byte)colorG, (byte)colorB, 150);
		createNotification.headerObjS.GetComponent<Image>().color = new Color32((byte)colorR, (byte)colorG, (byte)colorB, 150);

		createNotification.appIcon = newAppIcon;
		createNotification.popupIcon = newPopupIcon;
		createNotification.appTitle = newAppTitle;
		createNotification.descTitle = newDescTitle;
		createNotification.description = newDescription;
	}

	public void SetProgressNotification () 
	{
		createNotification.headerObjPB.GetComponent<Image>().color = new Color32((byte)colorR, (byte)colorG, (byte)colorB, 150);

		pbScript.currentPercent = pbCurrentPercent;
		pbScript.speed = pbSpeed;
		createNotification.appIcon = newAppIcon;
		createNotification.appTitle = newAppTitle;
		createNotification.descTitle = newDescTitle;
		createNotification.description = newDescription;
	}
		
	void Update () 
	{
		if (isMusicNtf == true) 
		{
			notificationCover.sprite = songCover.sprite;
			ntfSongTitle.text = songTitle.text;
			ntfArtistTitle.text = artistTitle.text;

			if (ntfSongTitle.text == "Not playing") 
			{
				ntfSongTitle.text = "Glass Music";
			}
			ntfSongTitle.text = ntfSongTitle.text.ToUpper();
		}
		createNotification.appIcon = newAppIcon;
		createNotification.appTitle = newAppTitle;
	}
}
