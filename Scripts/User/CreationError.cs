using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreationError : MonoBehaviour {

	[Header("OBJECTS")]
	public Button welcomeButton;
	public Button passwordButton;
	public Button allrightButton;
	public Text firstnameText;
	public Text lastnameText;
	public Text passwordText;
	public Text securityQuestionText;
	public Text securityQuestionHintText;

	[Header("ERROR PANEL")]
	public Animator errorAnimator;
	public string fadeInAnimName;
	public Text errorTitleText;
	public Text errorDescriptionText;
	public string errorTitle;
	public string errorDescription;

	void Update () 
	{
		if (firstnameText.text.Length <= 1 && lastnameText.text.Length <= 2) 
		{
			welcomeButton.interactable = false;
		} 

		else if (firstnameText.text.Length >= 2 && lastnameText.text.Length >= 3) 
		{
			welcomeButton.interactable = true;
		}

		if (passwordText.text.Length <= 4 && securityQuestionText.text.Length <= 1 && securityQuestionHintText.text.Length <= 1) 
		{
			passwordButton.interactable = false;
		}

		if (passwordText.text.Length >= 4 && securityQuestionText.text.Length >= 2 && securityQuestionHintText.text.Length >= 2) 
		{
			passwordButton.interactable = true;
		}
	}

	public void ShowError () 
	{
		if (firstnameText.text.Length <= 2 && lastnameText.text.Length <= 2) 
		{
			errorTitle = "Oops!";
			errorDescription = "You have to type at least 4 characters.";
			errorTitleText.text = errorTitle;
			errorDescriptionText.text = errorDescription;
			errorAnimator.Play (fadeInAnimName);
		}

		else if (passwordText.text.Length <= 4 && securityQuestionText.text.Length <= 4 && securityQuestionHintText.text.Length <= 4) 
		{
			errorTitle = "Oops!";
			errorDescription = "You have to type at least 4 characters.";
			errorTitleText.text = errorTitle;
			errorDescriptionText.text = errorDescription;
			errorAnimator.Play (fadeInAnimName);
		}
	}
}
