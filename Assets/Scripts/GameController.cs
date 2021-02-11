using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{
    public TMP_Text score;
    public UnityEngine.UI.Image fuel_image;
    public UnityEngine.UI.Slider turbo_slider;
    public CarController car;
    public CoinCollector coins;
    bool gameover = false;
    private void Start()
    {
        turbo_slider.maxValue = car.max_turbo;
    }

    private void Update()
    {
        turbo_slider.value = car.turbo;
        fuel_image.fillAmount = car.fuel;
        score.text = "Score: " + coins.coins;
        if(car.fuel <= 0 && gameover == false)
        {
            gameover = true;
        }
    }
}
