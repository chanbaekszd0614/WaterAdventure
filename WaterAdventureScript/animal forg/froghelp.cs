using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class froghelp : MonoBehaviour
{
   public GameObject play;
   public void help()
   {
      PlayerControler player = play.GetComponent<PlayerControler>();
      player.ReduceHealth(10);
      if(player.MyCurrentHealth==0)
         player.death();
      
   }
}
