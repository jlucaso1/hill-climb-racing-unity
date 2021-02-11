using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int coins = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            coins += collision.gameObject.GetComponent<CoinController>().value;
            Destroy(collision.gameObject);
        }
    }
}
