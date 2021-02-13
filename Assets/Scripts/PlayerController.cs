using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PlayerController : MonoBehaviour
{
    public GameObject vehicle;
    void Awake()
    {
        GameObject vehicleInstannced = Instantiate(Resources.Load<GameObject>("Prefabs/Vehicles/MotorCycle"), new Vector3(5, 3, 0), Quaternion.identity);
        vehicleInstannced.transform.SetParent(transform);
        GameObject.Find("PlayerCam").GetComponent<CinemachineVirtualCamera>().m_Follow = vehicleInstannced.transform;
    }
}
