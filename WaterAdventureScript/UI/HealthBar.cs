using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider healthBar;
    public  PlayerControler _play=new PlayerControler();
    public static HealthBar Instance;
    public Text healthNumber;

    void Awake()
    {
        Instance = this;
    }

    public void changeHealth()
    {
        if (healthBar == null)
        {
            healthBar = GetComponent<Slider>();
        }
        healthBar.value = _play.MyCurrentHealth;
        healthNumber.text = healthBar.value.ToString() + "/" + _play.MyMaxHealth.ToString();
    }
}
