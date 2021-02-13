using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Changing to level0");
        SceneManager.LoadScene("Level0");
    }
    public void ExitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
