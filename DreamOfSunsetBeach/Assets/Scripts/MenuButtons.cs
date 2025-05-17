using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using System.Linq;
using System;

public class MenuButtons : MonoBehaviour
{
    private GameObject menuScreen;
    private GameObject optionScreen;
    private void Awake()
    {
        menuScreen = GameObject.Find("MainScreen");
        optionScreen = GameObject.Find("OptionScreen");

        optionScreen.SetActive(false);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadButton()
    {

    }

    public void OptionsButton()
    {
        menuScreen.SetActive(false);
        optionScreen.SetActive(true);
    }

    public void CreditButton()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void EnButton()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];

    }

    public void DeButton()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
    }

    public void SoundButton()
    {

    }

    public void BackButton()
    {
        menuScreen.SetActive(true);
        optionScreen.SetActive(false);
    }
}
