using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogFeedback : MonoBehaviour
{
    public GameObject player;
    public GameObject frogs;

    public void FrogAddHealth()
    {
        PlayerControler play = player.GetComponent<PlayerControler>();
        play.AddHealth(12);
        Destroy(frogs);


    }
}
