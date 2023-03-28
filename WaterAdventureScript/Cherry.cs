using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource cherryVoice = GetComponent<AudioSource>();
        PlayerControler pl = other.GetComponent<PlayerControler>();
        if (pl != null)
        {
            pl.AddHealth(5);
            cherryVoice.Play();
            Destroy(gameObject);
        }
    }

    public void ShowCherry()
    {
        gameObject.SetActive(true);
    }

    public void DestroyCherry()
    {
        gameObject.SetActive(false);
    }
}
