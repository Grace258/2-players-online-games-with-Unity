using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string MainGameScene;
   public void StartGame()
    {
        SceneManager.LoadScene(MainGameScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
