using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public  Toggle toggelMusic;
    public AudioSource audio;

    public void ToggleMusicThing()
    {
        //Toggle toggle = toggelMusic.GetComponent<Toggle>();
        //AudioSource audios = audio.GetComponent<AudioSource>();
        //Debug.Log("music");
        if (toggelMusic.isOn == true)
        {
            audio.mute =false;
        }
        else if (toggelMusic.isOn == false)
        {
            audio.mute=true;
        }
    }

}
