using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateNotification : MonoBehaviour {

	[Header("OBJECTS")]
	public Transform notificationParent;
	public GameObject standartNotification;
	public GameObject popupNotification;
	public GameObject progressNotification;
	public GameObject musicNotification;

	[Header("NOTIFICATION OBJECTS")]
	public Text appTitleObj;
	public Text descTitleObj;
	public Text descriptionObj;
	public Image headerObjS;
	public Image appIconObject;
	public Image musicCoverObj;

	[Header("POPUP NOTIFICATION")]
	public Transform popupNotificationParent;
	public Color headerColor;
	public Image headerObject;
	public Image popupAppIconObject;
	public Image popupIconObject;
	public Text popupAppTitleObj;
	public Text popupDescTitleObj;
	public Text popupDescriptionObj;

	[Header("PB NTF OBJECTS")]
	public Text pbAppTitleObj;
	public Text pbDescTitleObj;
	public Image pbAppIconObject;
	public Image headerObjPB;

	[Header("VARIABLES")]
	public Sprite appIcon;
	public Sprite popupIcon;
	public Sprite musicCover;
	public string appTitle;
	public string descTitle;
	public string description;

	public void SendNotification () 
	{
		GameObject go = Instantiate (standartNotification, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		go.transform.parent = notificationParent;
	}

	public void PopupNotification () 
	{
		popupAppIconObject.sprite = appIcon;
		popupAppTitleObj.text = appTitle;
		popupDescTitleObj.text = descTitle;
		popupDescriptionObj.text = description;
		popupIconObject.sprite = popupIcon;

		GameObject go = Instantiate (popupNotification, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		go.transform.SetParent(popupNotificationParent, false);
	}

	public void ProgressNotification () 
	{
		pbAppIconObject.sprite = appIcon;
		pbAppTitleObj.text = appTitle;
		pbDescTitleObj.text = descTitle;

		GameObject go = Instantiate (progressNotification, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		go.transform.parent = notificationParent;
	}

	public void MusicNotification () 
	{
		GameObject go = Instantiate (musicNotification, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		go.transform.parent = notificationParent;
	}

	public void SetNotification () 
	{
		appIconObject.sprite = appIcon;
		appTitleObj.text = appTitle;
		descTitleObj.text = descTitle;
		descriptionObj.text = description;
	}
}
