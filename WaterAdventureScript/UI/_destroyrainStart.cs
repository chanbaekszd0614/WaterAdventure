using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _destroyrainStart : MonoBehaviour
{
   public GameObject st;
  
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.tag == "river")
      {
         Destroy(gameObject);
         _Start sta = st.GetComponent<_Start>();
         sta.OpenButton();
      }
   }
}
