using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysPlay : MonoBehaviour
{
    private static AlwaysPlay _instance;

    public static AlwaysPlay Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AlwaysPlay>();//FindObjectOfType按类型查找对象列表
                DontDestroyOnLoad(_instance);
            }

            return _instance;
        }
    }

    private void Awake()
    {
        //此脚本永不销毁，在进入初始场景时检查，有重复就销毁
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != _instance)
        {
            Destroy(gameObject);
        }
    }
}
