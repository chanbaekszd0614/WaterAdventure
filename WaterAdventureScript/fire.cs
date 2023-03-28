using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControler pl = other.GetComponent<PlayerControler>();
        if (pl != null)
        {
            pl.ReduceHealth(20);
        }

    }
}
