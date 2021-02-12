using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public int coins = 0;

    private void Update()
    {
        if (GameObject.Find("Player").GetComponentInChildren<VehicleController>().fuel <= 0)
        {
            //GameObject.Find("GameOverUI").GetComponent<GameOverController>().showGameOver();
        }
        if (Input.GetKey("escape"))
        {
            BackToMainMenu();
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level0");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
