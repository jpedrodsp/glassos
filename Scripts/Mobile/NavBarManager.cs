using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavBarManager : MonoBehaviour {

    [Header("ANIMATORS")]
    public Animator coriAnimator;
    public Animator homeAnimator;
    public Animator appSwitchingAnimator;

    [Header("RESOURCES")]
    public Coffee.UIExtensions.UIEffectCapturedImage appSwitchingBlur;

    bool asaOpen = false;

    public void AppSwitchAnimate()
    {
        if(asaOpen == false)
        {
            appSwitchingBlur.Capture();
            appSwitchingAnimator.Play("App Switching In");
            asaOpen = true;
        }

        else
        {
            appSwitchingAnimator.Play("App Switching Out");
            asaOpen = false;
        }

  
    }

    public void AppSwitchOut()
    {
        appSwitchingAnimator.Play("App Switching Out");
        asaOpen = false;
    }

    public void HomeIn()
    {
        homeAnimator.Play("Home Screen In");
	}

    public void HomeOut()
    {
        homeAnimator.Play("Home Screen Out");
    }
}
