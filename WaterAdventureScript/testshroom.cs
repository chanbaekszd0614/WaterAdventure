using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class testshroom : MonoBehaviour
{
    public float reduceHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("进去");
        PlayerControler pc = other.GetComponent<PlayerControler>();
        if (pc!=null)
        {
            Debug.Log("碰到我啦");
            Thread.Sleep(30);
            pc.ReduceHealth(reduceHealth);
            Debug.Log(pc.MyCurrentHealth);
            if (pc.MyCurrentHealth == 0)
            {
                pc.death();
            }
            Destroy(gameObject);
        }
    }


}
