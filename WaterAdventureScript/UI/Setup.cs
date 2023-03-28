using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour
{
  public void ShowPanel()
  {
    gameObject.SetActive(true);
  }

  public void ClosePanel()
  {
    gameObject.SetActive(false);
  }
}
