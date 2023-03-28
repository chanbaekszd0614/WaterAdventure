using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchDown : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
      PlayerControler pl = other.GetComponent<PlayerControler>();
      if (pl.tag=="Player")
      {
         Debug.Log("shuzhi");
         pl.ReduceHealth(5);
         Destroy(gameObject);
      }
   }
}
