using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Start : MonoBehaviour
{
    public void OpenButton()
    {
        gameObject.SetActive(true);
    }

    public void Begin()
    {
        SceneManager.LoadScene("1-2");
    }

}
