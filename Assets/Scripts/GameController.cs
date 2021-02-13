using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public int coins = 0;
    private bool gameover = false;
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
        gameover = false;
        SceneManager.LoadScene("Level0");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Death()
    {
        if (!gameover)
        {
            gameover = true;
            StartCoroutine(DeathEffect());
        }
    }

    IEnumerator DeathEffect()
    {
        Time.timeScale = 0.5f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
        yield return new WaitForSeconds(1);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
        SceneManager.LoadScene("MainMenu");
    }
}
