using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CamController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CinemachineVirtualCamera>().m_Follow = GameObject.Find("Player").GetComponent<Transform>().GetChild(0).GetComponent<Transform>();
    }
}
