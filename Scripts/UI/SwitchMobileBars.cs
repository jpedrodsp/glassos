using UnityEngine;

public class SwitchMobileBars : MonoBehaviour {

    [Header("NAVIGATION BAR")]
    public GameObject whiteNavBar;
    public GameObject darkNavBar;

    [Header("INDICATOR BAR")]
    public GameObject whiteIndicatorBar;
    public GameObject darkIndicatorBar;

    void Start ()
    {
        whiteNavBar.SetActive(true);
        darkNavBar.SetActive(false);

        whiteIndicatorBar.SetActive(true);
        darkIndicatorBar.SetActive(false);
    }

    public void SwitchToWhite()
    {
        whiteNavBar.SetActive(true);
        darkNavBar.SetActive(false);

        whiteIndicatorBar.SetActive(true);
        darkIndicatorBar.SetActive(false);
    }

    public void SwitchToDark()
    {
        whiteNavBar.SetActive(false);
        darkNavBar.SetActive(true);

        whiteIndicatorBar.SetActive(false);
        darkIndicatorBar.SetActive(true);
    }
}
