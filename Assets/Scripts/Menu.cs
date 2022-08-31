using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
     public void OnExitButton()
     {
          Application.Quit();
     }

     public void OnPlayButton()
     {
          SceneManager.LoadScene(1);
     }
}
