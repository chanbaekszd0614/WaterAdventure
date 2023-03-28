using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlay : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControler pc = other.GetComponent<PlayerControler>();
        if (pc!=null)
        {
            pc.ReduceHealth(pc.MyCurrentHealth);
            pc.death();
            Destroy(pc.gameObject);
        }
    }
}
