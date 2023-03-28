using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBox : MonoBehaviour
{
   private Animator anim;
   public Cherry cherrys;
   private void OnTriggerEnter2D(Collider2D other)
   {
      anim = this.GetComponent<Animator>();
      PlayerControler pl = other.GetComponent<PlayerControler>();
      if (pl != null&&cherrys!=null)
      {
         anim.SetTrigger("open");
         cherrys.ShowCherry();
      }
   }
}
