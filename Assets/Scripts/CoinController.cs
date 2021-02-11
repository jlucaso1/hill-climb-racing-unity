using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameController game;
    public int value = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        game.coin += value;
    }
}
