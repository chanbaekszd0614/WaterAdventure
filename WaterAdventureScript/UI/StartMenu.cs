using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
   

   public void PlayGame()
   {
      SceneManager.LoadScene("Menu");
   }

   public void ExitGame()
   {
      Application.Quit();
   }


}
