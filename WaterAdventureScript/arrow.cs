using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public Setup sets;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Setup set = sets.GetComponent<Setup>();
        PlayerControler pl = other.GetComponent<PlayerControler>();
        if (pl != null)
        {
            set.ShowPanel();
            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("shoot");
        }
    }
}
