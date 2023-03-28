using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crank : MonoBehaviour
{
    private Animator anim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        anim = this.GetComponent<Animator>();
        PlayerControler pl = other.GetComponent<PlayerControler>();
        if (pl != null)
        {
            Debug.Log("ojbk");
            anim.SetTrigger("crank");
            anim.SetTrigger("crank-up");
        }
    }
}
