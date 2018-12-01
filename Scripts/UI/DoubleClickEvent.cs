using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DoubleClickEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public UnityEvent DoubleClickEvents;

    bool active;
    bool oneClick = false;
    bool timerRunning;
    float timerForDoubleClick;
    float delay = 0.25f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        active = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        active = false;
    }

    void Update()
    {
        if(active == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!oneClick)
                {
                    oneClick = true;
                    timerForDoubleClick = Time.time;
                }

                else
                {
                    oneClick = false;
                    DoubleClickEvents.Invoke();
                }
            }

            if (oneClick)
            {
                if ((Time.time - timerForDoubleClick) > delay)
                {
                    oneClick = false;
                }
            }
        }    
    }
}