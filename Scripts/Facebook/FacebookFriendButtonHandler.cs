using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class FacebookFriendButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("ANIMATORS")]
    public Animator objectAnimator;

    private bool isOpen = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (isOpen == false)
        {
            objectAnimator.Play("FBF Expand");
            isOpen = true;
        }
        else if (isOpen == true)
        {
            objectAnimator.Play("FBF Minimize");
            isOpen = false;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        objectAnimator.Play("FBF Minimize");
        isOpen = false;
    }

    public void TriggerExit()
    {
        objectAnimator.Play("FBF Minimize");
        isOpen = false;
    }
}