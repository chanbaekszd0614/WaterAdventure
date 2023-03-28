using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAnimalFeed : MonoBehaviour
{
    public Setup sets;
    public PlayerControler player;
    public void CloseAnimal()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            sets.ClosePanel();
            player.AddHealth(12);
        }
    }
}
