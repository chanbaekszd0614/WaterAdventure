using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller2 : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GameObject.Find("voice").GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey(GameConst.AlwaysMusic.soundValue.ToString()))
        {
            float vol = PlayerPrefs.GetFloat(GameConst.AlwaysMusic.soundValue.ToString());
            audioSource.volume = vol;
        }
        else
        {
            audioSource.volume = 0.5f;
            PlayerPrefs.SetFloat(GameConst.AlwaysMusic.soundValue.ToString(),0.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
