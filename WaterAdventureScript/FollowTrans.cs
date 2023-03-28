using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTrans : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerControler pc = col.GetComponent<PlayerControler>();
        if (pc!=null)
        {
            Debug.LogWarning("ok");
           
        }
    }
}
