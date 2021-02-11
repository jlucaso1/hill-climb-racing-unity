using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public int value = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Game").GetComponent<GameController>().coins += value;
        Destroy(gameObject);
    }
}
