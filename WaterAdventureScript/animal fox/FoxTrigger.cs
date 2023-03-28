using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxTrigger : MonoBehaviour
{
    public AudioSource audio;
    public GameObject gantan;
    public Setup set;
 private void OnTriggerEnter2D(Collider2D other)
 {
      PlayerControler pl = other.GetComponent<PlayerControler>();
      if (pl != null)
      {
          audio.GetComponent<AudioSource>().Play();
          Destroy(gantan);
          Setup sets = set.GetComponent<Setup>();
          sets.ShowPanel();
      }
  

 }
}
