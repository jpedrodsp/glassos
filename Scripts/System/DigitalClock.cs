using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalClock : MonoBehaviour {

	[Header("TEXTS")]
	public Text timeText;
	public Text dateText;
	public Text amPmText;

	[Header("LOCK SCREEN")]
	public Text hourText;
	public Text minuteText;
//	public Text dateLockText;

	[Header("SETTINGS")]
	public bool amPmFormat = true;
	public bool shortTime = true;
	public bool phoneTime = false;
	public bool lockScreenTime = false;
	public bool seperateAmPm = false;
	public bool isLockScreen = false;

	void Update () 
	{
		if (isLockScreen == true) 
		{
			hourText.text = System.DateTime.Now.ToString ("hh");
			minuteText.text = System.DateTime.Now.ToString ("mm");
			amPmText.text = System.DateTime.Now.ToString ("tt");
			//	dateLockText.text = System.DateTime.Now.ToString ("dddd, MMMM d");
		}
			
		if (seperateAmPm == true) 
		{
			amPmText.text = System.DateTime.Now.ToString ("tt");
		}

		if (amPmFormat == true && shortTime == true) 
		{
			timeText.text = System.DateTime.Now.ToString ("h:mm tt");
			dateText.text = System.DateTime.Now.ToString ("M.d.yyyy");
		}

		else if (amPmFormat == true && shortTime == false) 
		{
			timeText.text = System.DateTime.Now.ToString ("hh:mm tt");
			dateText.text = System.DateTime.Now.ToString ("d MMMM, yyyy, dddd");
		}

		else if (amPmFormat == false && phoneTime == true) 
		{
			timeText.text = System.DateTime.Now.ToString ("hh:mm");
			dateText.text = System.DateTime.Now.ToString ("d MMMM, dddd");
		}

		else if (amPmFormat == true && phoneTime == true) 
		{
			timeText.text = System.DateTime.Now.ToString ("hh:mm tt");
			dateText.text = System.DateTime.Now.ToString ("d MMMM, dddd");
		}

		else if (amPmFormat == false && lockScreenTime == true) 
		{
			timeText.text = System.DateTime.Now.ToString ("hh:mm");
			dateText.text = System.DateTime.Now.ToString ("dddd, MMMM d");
		}

		else if (amPmFormat == true && lockScreenTime == true) 
		{
			timeText.text = System.DateTime.Now.ToString ("hh:mm tt");
			dateText.text = System.DateTime.Now.ToString ("dddd, MMMM d");
		}

		else if (amPmFormat == false && shortTime == true) 
		{
			timeText.text = System.DateTime.Now.ToString ("H:mm");
			dateText.text = System.DateTime.Now.ToString ("M.d.yyyy");
		}

		else if (amPmFormat == false && shortTime == false) 
		{
			timeText.text = System.DateTime.Now.ToString ("H:mm");
			dateText.text = System.DateTime.Now.ToString ("d MMMM, yyyy, dddd");
		}
	}
}
