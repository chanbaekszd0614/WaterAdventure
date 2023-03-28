using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene("1-2");
    }

    public void retry2()
    {
        SceneManager.LoadScene("2");
    }

    public void retry3()
    {
        SceneManager.LoadScene("3");
    }

}
