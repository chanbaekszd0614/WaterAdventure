using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxHelp : MonoBehaviour
{
  public PlayerControler pl;
  public Setup set;
  public void FoxChooseHelp()
  {
    PlayerControler pls = pl.GetComponent<PlayerControler>();
    pls.ReduceHealth(20);
    if(pls.MyCurrentHealth==0)
      pls.death();
    set.GetComponent<Setup>().ShowPanel();
  }
  
}
