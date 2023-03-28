using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TriggerFly : MonoBehaviour
{
    public Setup setup;
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControler pl = other.GetComponent<PlayerControler>();
        if (pl != null)
        {
            setup.ShowPanel();
        }

    }
}
