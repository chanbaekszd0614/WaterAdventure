using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crank3 : MonoBehaviour
{
   public GameObject f;
   private void OnTriggerEnter2D(Collider2D other)
   {
      Animator anim = GetComponent<Animator>();
      Animator animf = f.GetComponent<Animator>();
      PlayerControler pl = other.GetComponent<PlayerControler>();
      if (pl != null)
      {
         anim.SetTrigger("crank3");
         animf.SetTrigger("f1");
      }
   }
}
