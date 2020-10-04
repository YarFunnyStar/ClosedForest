using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip buttonSound;
    static AudioSource audiossrc;
    void Start()
    {
        buttonSound = Resources.Load<AudioClip>("ButtonSound");
        audiossrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void playSound()
    {
        audiossrc.PlayOneShot(buttonSound);
    }
}
