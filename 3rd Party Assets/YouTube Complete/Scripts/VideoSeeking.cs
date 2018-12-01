using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class VideoSeeking : MonoBehaviour {

	public VideoManager videoManager;
	public Image positionBar;
	float videoPosition;
	bool hovering;

	void FixedUpdate () 
	{
		//widhtBar.preferredWidth
		if (!hovering) return;
		videoPosition = Input.mousePosition.x / Screen.width;
		positionBar.fillAmount = videoPosition;
	}

	public void seekEnter() {
		hovering = true;
	}

	public void seekExit() 
	{
		positionBar.fillAmount = 0;
		hovering = false;
	}

	public void seekClick() 
	{
		videoManager.Seek(videoPosition);
	}
}
