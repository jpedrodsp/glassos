using UnityEngine;
using UnityEngine.EventSystems;

public class VideoSeekAnim : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	[Header("ANIMATORS")]
	public Animator seekBarAnimator;


	public void OnPointerEnter(PointerEventData ped) 
	{
		seekBarAnimator.Play("Seek Enter");
	}

	public void OnPointerExit(PointerEventData ped) 
	{
		seekBarAnimator.Play("Seek Exit");
	}
}
