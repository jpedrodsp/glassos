using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayObjectAnim : MonoBehaviour {

    private Animator animator;
    public string animName;

	void Start ()
    {
        animator = this.GetComponent<Animator>();
        animator.Play(animName);
    }
}
