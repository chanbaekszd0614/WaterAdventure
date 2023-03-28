using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeatroyMusic : MonoBehaviour
{
    void  Awake()
    {
        GameObject vo=GameObject.FindWithTag("voice");
        if(vo)
            Destroy(vo.gameObject);
        
    }
}
