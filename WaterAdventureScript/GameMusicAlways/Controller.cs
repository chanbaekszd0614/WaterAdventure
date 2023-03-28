using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
   // private Button startButton;
    private AudioSource audioSource;

    private void Awake()
    {
       // startButton = GameObject.Find("Start").GetComponent<Button>();
        audioSource = GameObject.Find("voice").GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
        audioSource.Play();
    }

    public void Init()
    {
        //当音量有上一次记录值，附上相应值
        if (PlayerPrefs.HasKey(GameConst.AlwaysMusic.soundValue.ToString())) //PlayerPrefs是Unity提供的可以用于存储和读取玩家数据的公共类
        {
            float vol = PlayerPrefs.GetFloat(GameConst.AlwaysMusic.soundValue.ToString());
            audioSource.volume = vol;
        }
        //否则音量值为 0.5
        else
        {
            audioSource.volume = 0.5f;
            PlayerPrefs.SetFloat(GameConst.AlwaysMusic.soundValue.ToString(),0.5f);
        }
    }
    
}
