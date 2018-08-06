using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnIndicatorAnim : MonoBehaviour
{

    [Header("APP PANELS")]
    public List<GameObject> panels = new List<GameObject>();

    [Header("TASK BAR BUTTONS")]
    public List<GameObject> buttons = new List<GameObject>();

    // [Header("PANEL ANIMS")]
    private string panelFadeIn = "App Fade-in";
    private string panelFadeOut = "App Fade-out";

    // [Header("BUTTON ANIMS")]
    private string buttonFadeIn = "TB Indicator On";
    private string buttonFadeOut = "TB Indicator Off";

    private GameObject currentPanel;
    private GameObject nextPanel;

    private GameObject currentButton;
    private GameObject nextButton;

    [Header("SETTINGS")]
    public int currentPanelIndex = 0;
    private int currentButtonlIndex = 0;

    private Animator currentPanelAnimator;
    private Animator nextPanelAnimator;

    private Animator currentButtonAnimator;
    private Animator nextButtonAnimator;

    void Start()
    {
        currentPanelAnimator = currentPanel.GetComponent<Animator>();
        nextPanelAnimator = nextPanel.GetComponent<Animator>();

        currentButtonAnimator = currentButton.GetComponent<Animator>();
        nextButtonAnimator = nextButton.GetComponent<Animator>();

        currentPanelAnimator.Play(panelFadeOut);
        currentButtonAnimator.Play(buttonFadeOut);

        nextPanelAnimator.Play(panelFadeOut);
        nextButtonAnimator.Play(buttonFadeOut);
    }

    public void PanelAnim(int newPanel)
    {
        if (newPanel != currentPanelIndex)
        {
            currentPanel = panels[currentPanelIndex];

            currentPanelIndex = newPanel;
            nextPanel = panels[currentPanelIndex];

            currentPanelAnimator = currentPanel.GetComponent<Animator>();
            nextPanelAnimator = nextPanel.GetComponent<Animator>();

            currentPanelAnimator.Play(panelFadeOut);
            nextPanelAnimator.Play(panelFadeIn);

            currentButton = buttons[currentButtonlIndex];

            currentButtonlIndex = newPanel;
            nextButton = buttons[currentButtonlIndex];

            currentButtonAnimator = currentButton.GetComponent<Animator>();
            nextButtonAnimator = nextButton.GetComponent<Animator>();

            currentButtonAnimator.Play(buttonFadeOut);
            nextButtonAnimator.Play(buttonFadeIn);
        }

        else
        {
            nextPanelAnimator.Play(panelFadeIn);
            nextButtonAnimator.Play(buttonFadeIn);
        }
    }

    public void RedirectPanelAnim(int newPanel)
    {
        currentPanel = panels[currentPanelIndex];
        currentPanelIndex = newPanel;

        nextPanel = panels[currentPanelIndex];
        nextPanelAnimator = nextPanel.GetComponent<Animator>();

        nextPanelAnimator.Play(panelFadeIn);
        nextButton = buttons[currentButtonlIndex];

        nextButtonAnimator = nextButton.GetComponent<Animator>();
        nextButtonAnimator.Play(buttonFadeIn);
    }
}