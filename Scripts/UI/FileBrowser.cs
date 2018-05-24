using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileBrowser : MonoBehaviour {

	[Header("ANIMATORS")]
	public Animator thisPCAnimator;
	public Animator thisPCListAnimator;
	public Animator cloudAnimator;
	public Animator cloudListAnimator;
	private bool tpIsOpen = true;
	private bool cloudIsOpen = false;

	[Header("OBJECTS")]
	public Button backButton;
	public Button nextButton;

	[Header("HISTORY PANEL")]
	public GameObject rootHistory;
	public GameObject userHistory;
	public GameObject userSeperator;
	public GameObject photosHistory;
	public GameObject photosSeperator;
	public GameObject songsHistory;
	public GameObject songsSeperator;
	public GameObject videosHistory;
	public GameObject videosSeperator;
	public GameObject downloadHistory;
	public GameObject downloadSeperator;

	[Header("SETTINGS")]
	public FolderPanels currentPanel;
	public FolderPanels prevPanel;

	public enum FolderPanels
	{
		ROOT,
		USER,
		MUSIC,
		PHOTO,
		VIDEO,
		DOWNLOAD
	}


	// OLD FH METHOD
	//public void CreateFolderHistory (GameObject notificationSample) 
	//{
	//	GameObject sprtr = Instantiate (folderHistorySeperator, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
	//	sprtr.transform.SetParent (folderHistoryParent, false);
	//
	//	GameObject go = Instantiate (notificationSample, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
	//	go.transform.SetParent(folderHistoryParent, false);
	//}

	void Update ()
	{
		if (currentPanel == FolderPanels.ROOT) {
			backButton.interactable = false;
		} else {
			backButton.interactable = true;
		}
	}

	public void thisPcOpenClose ()
	{
		if (tpIsOpen == true) 
		{
			thisPCAnimator.Play ("FB This PC Open");
			thisPCListAnimator.Play ("This PC List Closing");
			tpIsOpen = false;
		} 

		else 
		{
			thisPCAnimator.Play ("FB This PC Close");
			thisPCListAnimator.Play ("This PC List Opening");
			tpIsOpen = true;
		}
	}

	public void cloudPcOpenClose ()
	{
		if (cloudIsOpen == true) 
		{
			cloudAnimator.Play ("FB This PC Open");
			cloudListAnimator.Play ("This PC List Closing");
			cloudIsOpen = false;
		} 

		else 
		{
			cloudAnimator.Play ("FB This PC Close");
			cloudListAnimator.Play ("This PC List Opening");
			cloudIsOpen = true;
		}
	}

	public void ClickBack () 
	{
		if (currentPanel == FolderPanels.USER) 
		{
			ClickRoot ();
		}

		else if (currentPanel == FolderPanels.MUSIC) 
		{
			ClickRoot ();
		}

		else if (currentPanel == FolderPanels.PHOTO) 
		{
			ClickRoot ();
		}

		else if (currentPanel == FolderPanels.VIDEO) 
		{
			ClickRoot ();
		}

		else if (currentPanel == FolderPanels.DOWNLOAD) 
		{
			ClickRoot ();
		}
	}

	public void ClickRoot () 
	{
		userHistory.SetActive (false);
		userSeperator.SetActive (false);
		photosHistory.SetActive (false);
		photosSeperator.SetActive (false);
		songsHistory.SetActive (false);
		songsSeperator.SetActive (false);
		videosHistory.SetActive (false);
		videosSeperator.SetActive (false);
		downloadHistory.SetActive (false);
		downloadSeperator.SetActive (false);

		currentPanel = FolderPanels.ROOT;
	}

	public void ClickUser () 
	{
		userHistory.SetActive (true);
		userSeperator.SetActive (true);
		photosHistory.SetActive (false);
		photosSeperator.SetActive (false);
		songsHistory.SetActive (false);
		songsSeperator.SetActive (false);
		videosHistory.SetActive (false);
		videosSeperator.SetActive (false);
		downloadHistory.SetActive (false);
		downloadSeperator.SetActive (false);

		currentPanel = FolderPanels.USER;
	}

	public void ClickMusic () 
	{
		userHistory.SetActive (false);
		userSeperator.SetActive (false);
		photosHistory.SetActive (false);
		photosSeperator.SetActive (false);
		songsHistory.SetActive (true);
		songsSeperator.SetActive (true);
		videosHistory.SetActive (false);
		videosSeperator.SetActive (false);
		downloadHistory.SetActive (false);
		downloadSeperator.SetActive (false);

		currentPanel = FolderPanels.MUSIC;
	}

	public void ClickPhoto () 
	{
		userHistory.SetActive (false);
		userSeperator.SetActive (false);
		photosHistory.SetActive (true);
		photosSeperator.SetActive (true);
		songsHistory.SetActive (false);
		songsSeperator.SetActive (false);
		videosHistory.SetActive (false);
		videosSeperator.SetActive (false);
		downloadHistory.SetActive (false);
		downloadSeperator.SetActive (false);

		currentPanel = FolderPanels.PHOTO;
	}

	public void ClickVideo () 
	{

		userHistory.SetActive (false);
		userSeperator.SetActive (false);
		photosHistory.SetActive (false);
		photosSeperator.SetActive (false);
		songsHistory.SetActive (false);
		songsSeperator.SetActive (false);
		videosHistory.SetActive (true);
		videosSeperator.SetActive (true);
		downloadHistory.SetActive (false);
		downloadSeperator.SetActive (false);

		currentPanel = FolderPanels.VIDEO;
	}

	public void ClickDownload () 
	{
		userHistory.SetActive (false);
		userSeperator.SetActive (false);
		photosHistory.SetActive (false);
		photosSeperator.SetActive (false);
		songsHistory.SetActive (false);
		songsSeperator.SetActive (false);
		videosHistory.SetActive (false);
		videosSeperator.SetActive (false);
		downloadHistory.SetActive (true);
		downloadSeperator.SetActive (true);

		currentPanel = FolderPanels.DOWNLOAD;
	}
}