using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsLoad : MonoBehaviour
{
    private static readonly string Sound = "Sound";
    private float soundFloat;
    public AudioSource Audio;
    void Awake()
    {
        Debug.Log("Загружена громкость" + PlayerPrefs.GetFloat(Sound));
        soundFloat = PlayerPrefs.GetFloat(Sound);
        Audio.volume = soundFloat;
    }
}
