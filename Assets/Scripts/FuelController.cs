using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vehicle")
        {
            GameObject.Find("Player").GetComponentInChildren<VehicleController>().fuel = 1;
            Destroy(gameObject);
        }
    }
}
