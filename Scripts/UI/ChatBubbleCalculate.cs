using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatBubbleCalculate : MonoBehaviour
{
    [Header("RESOURCES")]
    public Text mainText;
    public LayoutElement layoutElement;

    [Header("SETTINGS")]
    public int maxTextChar = 25;
    public int preferredTextWidth = 225;

    void Start()
    {
        if(mainText.text.Length >= maxTextChar)
        {
            layoutElement.preferredWidth = preferredTextWidth;
        }
    }
}
