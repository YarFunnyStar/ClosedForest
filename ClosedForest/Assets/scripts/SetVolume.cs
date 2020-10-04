using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string Sound = "Sound";
    private int firstPlayInt;
    public Slider soundSlider;
    private float soundFloat;
    public AudioSource Audio;
    void Start()
    {
        /*firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        if (firstPlayInt == 0)
        {
            soundFloat = 0.25f;
            soundSlider.value = soundFloat;
            PlayerPrefs.SetFloat(Sound, soundFloat);
            PlayerPrefs.SetFloat(FirstPlay, -1);
        }
        else
        {
           soundFloat = PlayerPrefs.GetFloat(Sound);
            soundSlider.value = soundFloat;
        }*/
        soundFloat = PlayerPrefs.GetFloat(Sound);
        soundSlider.value = soundFloat;
    }
    public void SaveSettings()
    {
        PlayerPrefs.SetFloat(Sound, soundSlider.value);
    }
    private void OnApplicationFocus(bool focus)
    {
        if(!focus)
        {
            
            SaveSettings();
            Debug.Log("Сохранена громкость" + PlayerPrefs.GetFloat(Sound));
            PlayerPrefs.Save();

        }
    }
    public void UpdateSound()
    {
        Audio.volume = soundSlider.value;
    }
}
