using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchUI : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject controlsPanel;
    public GameObject creditsPanel;

    public void ShowSettings()
    {
        settingsPanel.SetActive(true);
        controlsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    // Function to activate the Controls panel and deactivate others
    public void ShowControls()
    {
        settingsPanel.SetActive(false);
        controlsPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    // Function to activate the Credits panel and deactivate others
    public void ShowCredits()
    {
        settingsPanel.SetActive(false);
        controlsPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }
}
