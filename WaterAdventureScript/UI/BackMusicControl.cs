using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackMusicControl : MonoBehaviour
{
    public Slider slider;
    public AudioSource backMusic;

    public void ControlMusic()
    {
        backMusic.volume = slider.value;
    }
}
