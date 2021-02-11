using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public int coins = 0;
    bool gameover = false;

    private void Update()
    {
        if (GameObject.Find("Player").GetComponentInChildren<VehicleController>().fuel <= 0 && gameover == false)
        {
            gameover = true;
        }
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
