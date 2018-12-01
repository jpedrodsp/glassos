using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour {

	private bool isEverythingDone;

	[Header("USER INFO")]
	public bool debugMode = false;
	public bool wipeDataAtStart = false;
	public GameObject userData;
	public GameObject accountCreate;
	public AccountCreate accountCreateScript;
	[Range(0, 1)] public int isRegistered;
	[Range(0, 4)] public int profilePhoto;
	public string firstname;
	public string lastname;
	public string password;
	public string securityQuestion;
	public string securityQuestionHint;

	[Header("SYSTEM SCREENS")]
	public GameObject welcomeScreen;
	public GameObject bootScreen;
	public GameObject lockScreen;
	public GameObject userScreen;
	public GameObject blankBG;

	[Header("SETTINGS OBJECTS")]
	public Text settingsNameText;
	public Text settingsLastNameText;
	public Text settingsFirstName;
	public Text settingsLastName;
	public Text settingsPassword;
	public Text settingsSecQuestion;
	public Text settingsSecQuestionHint;
	public Image settingsProfilePhoto;

	[Header("SYSTEM OBJECTS")]
	public Text startScreenName;
	public Text lockScreenName;
	public Image startScreenPhoto;
	public Image lockScreenPhoto;

	void Update () 
	{
		if (wipeDataAtStart == true) 
		{
			PlayerPrefs.DeleteAll ();
			wipeDataAtStart = false;
		}

		isRegistered = PlayerPrefs.GetInt ("IsRegistered");

		if (isRegistered == 1 && debugMode == false) 
		{
			Debug.Log ("User registered already");
			accountCreate.SetActive (false);
			firstname = PlayerPrefs.GetString ("FirstName");
			lastname = PlayerPrefs.GetString ("LastName");
			password = PlayerPrefs.GetString ("Password");
			securityQuestion = PlayerPrefs.GetString ("SecurityQuestion");
			securityQuestionHint = PlayerPrefs.GetString ("SecurityQuestionHint");
			profilePhoto = PlayerPrefs.GetInt ("ProfilePhoto");

			if (profilePhoto == 1) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp1;
				startScreenPhoto.sprite = accountCreateScript.pp1;
				lockScreenPhoto.sprite = accountCreateScript.pp1;
			}

			else if (profilePhoto == 2) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp2;
				startScreenPhoto.sprite = accountCreateScript.pp2;
				lockScreenPhoto.sprite = accountCreateScript.pp2;
			}

			else if (profilePhoto == 3) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp3;
				startScreenPhoto.sprite = accountCreateScript.pp3;
				lockScreenPhoto.sprite = accountCreateScript.pp3;
			}

			else if (profilePhoto == 4) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp4;
				startScreenPhoto.sprite = accountCreateScript.pp4;
				lockScreenPhoto.sprite = accountCreateScript.pp4;
			}

			startScreenName.text = firstname + " " + lastname;
			lockScreenName.text = firstname + " " + lastname;

			settingsNameText.text = firstname;
			settingsLastNameText.text = lastname;

			welcomeScreen.SetActive (false);
			bootScreen.SetActive (true);
			lockScreen.SetActive (true);
			userScreen.SetActive (true);
			blankBG.SetActive (false);
			isEverythingDone = true;
		} 

		else 
		{
			welcomeScreen.SetActive (true);
		//	blankBG.SetActive (true);

			profilePhoto = PlayerPrefs.GetInt ("ProfilePhoto");
			if (profilePhoto == 1) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp1;
				startScreenPhoto.sprite = accountCreateScript.pp1;
				lockScreenPhoto.sprite = accountCreateScript.pp1;
			}

			else if (profilePhoto == 2) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp2;
				startScreenPhoto.sprite = accountCreateScript.pp2;
				lockScreenPhoto.sprite = accountCreateScript.pp2;
			}

			else if (profilePhoto == 3) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp3;
				startScreenPhoto.sprite = accountCreateScript.pp3;
				lockScreenPhoto.sprite = accountCreateScript.pp3;
			}

			else if (profilePhoto == 4) 
			{
				settingsProfilePhoto.sprite = accountCreateScript.pp4;
				startScreenPhoto.sprite = accountCreateScript.pp4;
				lockScreenPhoto.sprite = accountCreateScript.pp4;
			}
		}

		if (isEverythingDone == true) 
		{
			userData.SetActive (false);
			isEverythingDone = false;
		}
	}

	public void UpdateAccount () 
	{
		PlayerPrefs.SetString ("FirstName", settingsFirstName.text);
		PlayerPrefs.SetString ("LastName", settingsLastName.text);
		PlayerPrefs.SetString ("Password", settingsPassword.text);
		PlayerPrefs.SetString ("SecurityQuestion", settingsSecQuestion.text);
		PlayerPrefs.SetString ("SecurityQuestionHint", settingsSecQuestionHint.text);
		isEverythingDone = true;
	}
}