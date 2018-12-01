using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationCenterManager : MonoBehaviour
{
    [Header("RESOURCES")]
    public Coffee.UIExtensions.UIEffectCapturedImage blurObject;
    public Scrollbar centerScrollbar;
    public Image blankBG;
    public CanvasGroup cg;
    public Animator contentAnimator;

    bool bjCanOpen = false;
    bool cgVisible = false;

    void Start()
    {
        blurObject.Release();
        bjCanOpen = true;
    }

    void Update()
    {
        var tempColor = blankBG.color;

        if (centerScrollbar.value <= 0.1f)
        {
            if (cgVisible == true)
            {
                cg.alpha -= 0.1f;

                contentAnimator.Play("NTF Fade-out");

                if (cg.alpha == 0)
                {
                    cgVisible = false;

                    if (bjCanOpen == false)
                    {
                        blurObject.Release();
                        bjCanOpen = true;
                    }
                }
            }

            if (tempColor.a >= 0)
            {
                tempColor.a -= 0.04f;
            }
        }

        else if (centerScrollbar.value >= 0.1f)
        {
            if (cgVisible == false)
            {
                cg.alpha += 0.1f;

                contentAnimator.Play("NTF Fade-in");

                if (cg.alpha == 1)
                {
                    cgVisible = true;
                }
            }

            if (bjCanOpen == true)
            {
                blurObject.Capture();
                bjCanOpen = false;
            }

            if (tempColor.a <= 0.3f)
            {
                tempColor.a += 0.04f;
            }
        }
        blankBG.color = tempColor;

        // CONTENT ANIMATOR

        if (centerScrollbar.value >= 0.15f && centerScrollbar.value <= 0.25f)
        {
            contentAnimator.Play("Phase 1");
        }

        else if (centerScrollbar.value >= 0.25f && centerScrollbar.value <= 0.35f)
        {
            contentAnimator.Play("Phase 2");
        }

        else if (centerScrollbar.value >= 0.35f && centerScrollbar.value <= 0.45f)
        {
            contentAnimator.Play("Phase 3");
        }

        else if (centerScrollbar.value >= 0.45f && centerScrollbar.value <= 0.55f)
        {
            contentAnimator.Play("Phase 4");
        }
    }
}
