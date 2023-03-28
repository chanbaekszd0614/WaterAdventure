using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeDrop1 : MonoBehaviour
{
    public void TreeDropPlay()
    {
        AudioSource audio = this.GetComponent<AudioSource>();
        audio.Play();
    }
}
