using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonPressed ()
    {
        SoundManager.playSound();
    }
}
