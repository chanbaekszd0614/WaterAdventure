using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starshine : MonoBehaviour
{
   public AudioSource audio;
   public GameObject setup;
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.tag == "Player")
      {
         Destroy(gameObject);
         AudioSource audios = audio.GetComponent<AudioSource>();
         Setup successful = setup.GetComponent<Setup>();
         audios.Play();
         successful.ShowPanel();
      }
   }
}
