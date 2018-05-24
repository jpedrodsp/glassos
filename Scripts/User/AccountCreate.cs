using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountCreate : MonoBehaviour {

	[Header("INITALIZE OBJECTS")]
	public Text firstnameText;
	public Text lastnameText;
	public Text passwordText;
	public Text securityQuestionText;
	public Text securityQuestionHintText;

	[Header("SETTINGS OBJECTS")]
	public Text settingsNameText;
	public Text settingsLastNameText;
	public Text settingsFirstName;
	public Text settingsLastName;
	public Text settingsPassword;
	public Text settingsSecQuestion;
	public Text settingsSecQuestionHint;

	[Header("SYSTEM OBJECTS")]
	public Text startScreenName;
	public Text lockScreenName;

	[Header("ACCOUNT INFO")]
	public string firstname;
	public string lastname;
	public string password;
	public string securityQuestion;
	public string securityQuestionHint;

	[Header("PROFILE PICTURES")]
	public Image createPlaceholder;
	public GameObject createPlaceholderIcon;
	public Sprite pp1;
	public Sprite pp2;
	public Sprite pp3;
	public Sprite pp4;

	public void CreateAccount () 
	{
		firstname = firstnameText.text;
		lastname = lastnameText.text;
		password = passwordText.text;
		securityQuestion = securityQuestionText.text;
		securityQuestionHint = securityQuestionHintText.text;

		int registered = 1;
		PlayerPrefs.SetString ("FirstName", firstname);
		PlayerPrefs.SetString ("LastName", lastname);
		PlayerPrefs.SetString ("Password", password);
		PlayerPrefs.SetString ("SecurityQuestion", securityQuestion);
		PlayerPrefs.SetString ("SecurityQuestionHint", securityQuestionHint);
		PlayerPrefs.SetInt ("IsRegistered", registered);

	}

	public void SetProfilePhoto (int profilephoto)
	{
		PlayerPrefs.SetInt ("ProfilePhoto", profilephoto);

		if (profilephoto == 1) 
		{
			createPlaceholder.sprite = pp1;
			createPlaceholderIcon.SetActive (false);
		}

		else if (profilephoto == 2) 
		{
			createPlaceholder.sprite = pp2;
			createPlaceholderIcon.SetActive (false);
		}

		else if (profilephoto == 3) 
		{
			createPlaceholder.sprite = pp3;
			createPlaceholderIcon.SetActive (false);
		}

		else if (profilephoto == 4) 
		{
			createPlaceholder.sprite = pp4;
			createPlaceholderIcon.SetActive (false);
		}
	}

	public void UpdateAccount () 
	{
		firstname = settingsFirstName.text;
		lastname = settingsLastName.text;
		password = settingsPassword.text;
		securityQuestion = settingsSecQuestion.text;
		securityQuestionHint = settingsSecQuestionHint.text;
	}

	void Update () 
	{
		startScreenName.text = firstname + " " + lastname;
		lockScreenName.text = firstname + " " + lastname;

		settingsNameText.text = firstname;
		settingsLastNameText.text = lastname;
	}
}
