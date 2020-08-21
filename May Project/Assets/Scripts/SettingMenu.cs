using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string SoundPref = "SoundPref";
    private int firstPlayInt;
    public Slider soundSlider;
    private float soundFloat;
    public AudioSource[] soundAudio;
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        if (firstPlayInt == 0)
        {
            soundFloat = .25f;
            soundSlider.value = soundFloat;
            PlayerPrefs.SetFloat(SoundPref, soundFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            soundFloat = PlayerPrefs.GetFloat(SoundPref);
            soundSlider.value = soundFloat;
        }

        resolutions = Screen.resolutions;
        
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height && resolutions[i].refreshRate == 60.0f)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

    }

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(SoundPref, soundSlider.value);
        Debug.Log("salvou");
    }

    void OnApplicationFocus (bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        for (int i = 0; i < soundAudio.Length; i++)
        {
            soundAudio[i].volume = soundSlider.value;
        }
        
    }
}
