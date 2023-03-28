using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TreeDrop : MonoBehaviour
{
    private Animator anim;
    private void OnTriggerEnter2D(Collider2D other)
    {
        anim = this.GetComponent<Animator>();
        PlayerControler pl = other.GetComponent<PlayerControler>();
        if (pl != null)
        {
            anim.SetTrigger("drop");
        }
    }
}
