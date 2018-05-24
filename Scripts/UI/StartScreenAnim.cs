using System.Collections;
using UnityEngine;

public class StartScreenAnim : MonoBehaviour {

	[Header("ANIMATOR")]
	public Animator startScreen;
	private bool isOn;

	[Header("ANIM NAMES")]
	public string fadeIn;
	public string fadeOut;

	void Start () 
	{
		startScreen.Play (fadeOut);
		isOn = false;
	}

	public void animateScreen () 
	{
		if (isOn == false) 
		{
			startScreen.Play (fadeIn);
			isOn = true;
		} 
		else 
		{
			startScreen.Play (fadeOut);
			isOn = false;
		}
	}

	public void animateNotificationScreen () 
	{
		if (isOn == true) 
		{
			startScreen.Play (fadeOut);
			isOn = false;
		} 
	}
}
