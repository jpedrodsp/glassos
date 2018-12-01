using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserPassword : MonoBehaviour {

	[Header("ANIMATOR")]
	public Animator lockScreen;
	public Animator wrongPassword;

	[Header("OBJECTS")]
	public UserData userDataScript;
	public GameObject wrongPasswordInfo;

	[Header("VARIABLES")]
	public Text passwordLine;

	public void checkPassword () 
	{
		if (passwordLine.text == userDataScript.password)
		{
            lockScreen.Play ("Lock Screen Close");
		} 

		else
		{
			wrongPasswordInfo.SetActive (true);
			wrongPassword.Play ("Wrong Password 2");
			wrongPassword.Play ("Wrong Password");
		}
	}
}
