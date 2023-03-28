using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour
{
    public void ForgSay()
    {
        gameObject.SetActive(true);
    }

    public void FrogNoSay()
    {
        gameObject.SetActive(false);
    }
}
