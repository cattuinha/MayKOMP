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
