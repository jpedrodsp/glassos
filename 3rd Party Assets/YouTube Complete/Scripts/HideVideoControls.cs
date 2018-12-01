using System.Collections;
using UnityEngine;

public class HideVideoControls : MonoBehaviour {

	[Header("ANIMATORS")]
	public Animator panelAnimator;
	private string fadeIn = "Control Panel Fade In";
	private string fadeOut = "Control Panel Fade Out";

	public void OnEnter () 
	{
		panelAnimator.Play (fadeIn);
	}

	public void OnExit () 
	{
		panelAnimator.Play (fadeOut);
	}
}
