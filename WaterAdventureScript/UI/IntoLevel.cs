using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoLevel : MonoBehaviour
{
    public void intoLevel()
    {
        SceneManager.LoadScene("1-2");
    }

    public void intoLevel1()
    {
        SceneManager.LoadScene("2");
    }

    public void intoLevel2()
    {
        SceneManager.LoadScene("3");
    }

}
