using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayWater : MonoBehaviour
{
    public void Playwater()
    {
       // Debug.Log("okkkkkkkk");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
