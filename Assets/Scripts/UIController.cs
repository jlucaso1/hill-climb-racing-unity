using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIController : MonoBehaviour
{
    public TMP_Text score_text;
    public UnityEngine.UI.Image fuel_image;
    public UnityEngine.UI.Slider turbo_slider;
    public GameController game;
    public CarController car;
    public CoinCollector coins;
    void Start()
    {
        turbo_slider.maxValue = car.max_turbo;
    }

    // Update is called once per frame
    private void Update()
    {
        turbo_slider.value = car.turbo;
        fuel_image.fillAmount = car.fuel;
        score_text.text = "Score: " + coins.coins;
    }
}
