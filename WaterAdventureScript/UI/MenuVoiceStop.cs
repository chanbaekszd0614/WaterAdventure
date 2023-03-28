using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVoiceStop : MonoBehaviour
{
    public GameObject music;
    public void StopMusic()
    {
        AudioSource musics = music.GetComponent<AudioSource>();
        musics.mute = true;
    }
}
