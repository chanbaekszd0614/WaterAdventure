using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDown : MonoBehaviour
{
    public void AppleDpwnPlay()
    {
        AudioSource audio = this.GetComponent<AudioSource>();
        audio.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Animator anims = this.GetComponent<Animator>();
        PlayerControler pl = other.GetComponent<PlayerControler>();
        if (pl != null)
        {
            anims.SetTrigger("down");
        }
    }
}
