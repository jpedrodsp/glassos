using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualKeyboard : MonoBehaviour {

    [Header("RESOURCES")]
    public Animator keyboardAnimator;
    public GameObject keyListNormal;
    public GameObject keyListCaps;
    public GameObject keyListCharacters;
    public GameObject keyListEmojis;
    public GameObject enterNormal;
    public GameObject enterCaps;
    public GameObject shiftOnImage;
    public GameObject shiftOnImageCaps;
    public GameObject shiftOffImage;
    public GameObject shiftOffImageCaps;

    [Header("SETTINGS")]
    public bool addBorder = true;
    public bool blurredBackground = false;

    private bool isOpen;
    private bool isSettingsOpen = false;
    bool isCapsOn = true;
    bool firstCapsPass = false;
    private InputField selectedInputField;
    private CustomInputField customInputField;

    void Start()
    {
        enterNormal.SetActive(true);
        enterCaps.SetActive(true);

        keyListNormal.SetActive(true);
        keyListCaps.SetActive(true);
        keyListCharacters.SetActive(true);
        keyListEmojis.SetActive(true);

        if (addBorder == false)
        {
            DisableBorder();
        }

        enterNormal.SetActive(false);
        enterCaps.SetActive(false);

        keyListNormal.SetActive(false);
        keyListCaps.SetActive(true);
        keyListCharacters.SetActive(false);
        keyListEmojis.SetActive(false);
    }

    void Update()
    {
        //    if (selectedInputField == null)
        //    {
        //        firstCapsPass = true;
        // }

        //    else
        //   {
        //    if (firstCapsPass == true && selectedInputField.text.Length == 1)
        //   {
        //   ShiftPress();
        //   firstCapsPass = false;
        //  }
        // }
    }

    public void DisableBorder ()
    {
        keyListNormal.SetActive(true);
        keyListCaps.SetActive(true);
        keyListCharacters.SetActive(true);
        keyListEmojis.SetActive(true);

        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Key Border");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().enabled = false;
        }

        SwitchToKeys();
    }

    public void EnableBorder()
    {
        keyListNormal.SetActive(true);
        keyListCaps.SetActive(true);
        keyListCharacters.SetActive(true);
        keyListEmojis.SetActive(true);

        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Key Border");

        foreach (GameObject go in gameObjectArray)
        {
            go.GetComponent<Image>().enabled = true;
        }

        SwitchToKeys();
    }

    public void AnimateKeyboard ()
    {
        if(isSettingsOpen == true)
        {
            AnimateSettings();
        }
        
        else
        {
            if (isOpen == true)
            {
                keyboardAnimator.Play("Keyboard Close");
                isOpen = false;
            }

            else
            {
                keyboardAnimator.Play("Keyboard Open");
                isOpen = true;
            }
        }
    }

    public void AnimateSettings ()
    {
        if (isSettingsOpen == true)
        {
            keyboardAnimator.Play("Keyboard Settings Out");
            isSettingsOpen = false;
        }

        else
        {
            keyboardAnimator.Play("Keyboard Settings In");
            isSettingsOpen = true;
        }
    }

    public void EnableMultiline(bool multilineEnabled)
    {
        if(multilineEnabled == true)
        {
            enterNormal.SetActive(true);
            enterCaps.SetActive(true);
        }

        else
        {
            enterNormal.SetActive(false);
            enterCaps.SetActive(false);
        }
    }

    public void SelectInputField (InputField textObject)
    {
        selectedInputField = textObject.GetComponent<InputField>();
    }

	public void KeyPress (string keyString)
    {
        selectedInputField.text = selectedInputField.text + keyString;
    }

    public void DeletePress ()
    {
        selectedInputField.text = selectedInputField.text.Remove(selectedInputField.text.Length - 1);
    }

    public void EnterPress ()
    {
        selectedInputField.text = selectedInputField.text +  "\n";
    }

    public void ShiftPress ()
    {
        if(isCapsOn == true)
        {
            keyListCaps.SetActive(false);
            keyListNormal.SetActive(true);
            isCapsOn = false;

            shiftOffImage.SetActive(true);
            shiftOffImageCaps.SetActive(true);
            shiftOnImage.SetActive(false);
            shiftOnImageCaps.SetActive(false);
        }

        else
        {
            keyListCaps.SetActive(true);
            keyListNormal.SetActive(false);
            isCapsOn = true;


            shiftOffImage.SetActive(false);
            shiftOffImageCaps.SetActive(false);
            shiftOnImage.SetActive(true);
            shiftOnImageCaps.SetActive(true);
        }
    }

    public void RemoveSelecteInputField()
    {
        customInputField = selectedInputField.GetComponent <CustomInputField>();
        customInputField.FieldTrigger();
        selectedInputField.DeactivateInputField();
        selectedInputField = null;
        firstCapsPass = true;
    }

    public void SwitchToKeys()
    {
        keyListNormal.SetActive(true);
        keyListCaps.SetActive(false);
        keyListCharacters.SetActive(false);
        keyListEmojis.SetActive(false);
    }

    public void SwitchToCharacters()
    {
        keyListNormal.SetActive(false);
        keyListCaps.SetActive(false);
        keyListCharacters.SetActive(true);
        keyListEmojis.SetActive(false);
    }

    public void SwitchToEmojis()
    {
        keyListNormal.SetActive(false);
        keyListCaps.SetActive(false);
        keyListCharacters.SetActive(false);
        keyListEmojis.SetActive(true);
    }
}
