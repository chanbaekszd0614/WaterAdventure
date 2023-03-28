using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakdown : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("break");
        }
    }

    void DisableBox()
    {
        this.enabled = false;
    }

    void DeatroyBreak()
    {
        Destroy(this.gameObject);
    }
}
