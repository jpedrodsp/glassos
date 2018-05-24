using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FacebookManager : MonoBehaviour {

	[Header("ANIMATORS")]
	public Animator welcomePanelAnimator;

	[Header("OBJECTS")]
	public Text usernameText;
	public Text firstnameText;
	public Text lastnameText;
	public Text emailText;
	public Text emailTextAgain;
	public Text passwordText;
	public Text securityQuestionText;
	public Text securityQuestionHintText;

	[Header("ACCOUNT INFO")]
	public string username;
	public string firstname;
	public string lastname;
	public string email;
	public string password;
	public string securityQuestion;
	public string securityQuestionHint;

	[Header("SETTINGS")]
	public bool isLoggedIn = false;

	void Start () 
	{

	}

	void Update () 
	{
		
	}

	public void StartAnimHandler ()
	{
		if (isLoggedIn == false)
		{
			welcomePanelAnimator.Play ("Facebook Login Fade-in");
		}

		else 
		{
			welcomePanelAnimator.Play ("Facebook Loading Fade-in");
		}
	}
}
