using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListContentSizeFix : MonoBehaviour {

    public Scrollbar scrollbar;

	void Start ()
    {
        scrollbar.value = 1;
	}
}
