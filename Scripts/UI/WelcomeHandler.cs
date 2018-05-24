using System.Collections;
using UnityEngine;

public class WelcomeHandler : MonoBehaviour {

	public GameObject bootScreen;
	public GameObject lockScreen;
	public GameObject userScreen;
	public GameObject welcomeScreen;
	public GameObject blankImage;

	void Start () 
	{
		bootScreen.SetActive (true);
		lockScreen.SetActive (true);
		userScreen.SetActive (true);
		blankImage.SetActive (false);
		welcomeScreen.SetActive (false);
	}
}
