using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSettings : MonoBehaviour
{

    
    private static readonly string SoundPref = "SoundPref";  
    private float soundFloat;
    public AudioSource[] soundAudio;

    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        soundFloat = PlayerPrefs.GetFloat(SoundPref);


        //soundAudio.volume = soundFloat;
         //OU
        for (int i = 0; i < soundAudio.Length; i++)
        {
            soundAudio[i].volume = soundFloat;
        }

        
    }

  
}
