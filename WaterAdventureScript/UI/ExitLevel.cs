using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitLevel : MonoBehaviour
{
   public void exitLevel()
   {
      SceneManager.LoadScene("StartMenu");
   }
}
