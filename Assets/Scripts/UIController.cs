using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UIController : MonoBehaviour
{
    public TMPro.TMP_Text score_text;
    public UnityEngine.UI.Image fuel_image;
    public UnityEngine.UI.Slider turbo_slider;
    GameController game;
    VehicleController vehicle;
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<GameController>();
        vehicle = GameObject.Find("Player").GetComponentInChildren<VehicleController>();
        turbo_slider.maxValue = vehicle.max_turbo;
    }
    private void Update()
    {
        turbo_slider.value = vehicle.turbo;
        fuel_image.fillAmount = vehicle.fuel;
        score_text.text = "Score: " + game.coins;
    }

}
