using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoriTaskBarManager : MonoBehaviour {

    [Header("ANIMATOR")]
    public Animator animator;

    [Header("SETTINGS")]
    public bool openAtStart = false;

    bool isOpen = false;

    void Start ()
    {
        if (openAtStart == false)
        {
            animator.Play("Cori TB Close");
            isOpen = false;
        }

        else
        {
            animator.Play("Cori TB Open");
            isOpen = true;
        }
    }

    public void Animate ()
    {
        if(isOpen == false)
        {
            animator.Play("Cori TB Open");
            isOpen = true;
        }

        else
        {
            animator.Play("Cori TB Close");
            isOpen = false;
        }
	}
}
