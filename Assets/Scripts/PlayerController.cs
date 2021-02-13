using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject vehicle;
    void Start()
    {
        GameObject vehicleInstannced= Instantiate(vehicle, new Vector3(5, 3, 0), Quaternion.identity);
        vehicleInstannced.transform.SetParent(transform);
    }
}
