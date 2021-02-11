using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public CarController car;
    public CoinCollector coins;
    bool gameover = false;

    private void Update()
    {
        if(car.fuel <= 0 && gameover == false)
        {
            gameover = true;
        }
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
