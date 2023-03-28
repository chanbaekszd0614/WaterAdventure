using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ff : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Animator anim = GetComponent<Animator>();
        if (collision != null)
        {
            anim.SetTrigger("f2");
        }
    }
}
