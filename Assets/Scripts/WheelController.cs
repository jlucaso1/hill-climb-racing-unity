using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 400f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");
        JointMotor2D motor = GetComponent<WheelJoint2D>().motor;
        motor.motorSpeed = speed * movement;
        GetComponent<WheelJoint2D>().motor = motor;
    }
}
