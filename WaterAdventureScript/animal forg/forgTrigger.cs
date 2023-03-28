using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forgTrigger : MonoBehaviour
{
    public GameObject gantan;
    public GameObject frogs;
    public AudioSource voice;
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControler pcc = other.GetComponent<PlayerControler>();
        if (pcc != null)
        {
            voice.GetComponent<AudioSource>().Play();
            frog fr = frogs.GetComponent<frog>();
            fr.ForgSay();
            Destroy(gantan);
        }
    }
}
