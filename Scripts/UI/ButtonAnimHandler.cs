using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimHandler : MonoBehaviour {

	[Header("BUTTON ANIMATOR")]
	public Animator buttonAnimatior;

	[Header("SETTINGS")]
	public string clickedAnimName;
	public string unclickedAnimName;
	public bool isClicked = false;

	public void PopupButton () 
	{
		if (isClicked == false) 
		{
			buttonAnimatior.Play (clickedAnimName);
			isClicked = true;
		} 

		else
		{
			buttonAnimatior.Play (unclickedAnimName);
			isClicked = false;
		}
	}

	public void Unclick () 
	{
		buttonAnimatior.Play (unclickedAnimName);
		isClicked = false;
	}
}
