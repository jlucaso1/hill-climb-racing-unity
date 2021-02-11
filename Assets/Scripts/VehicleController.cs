using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;
    public Rigidbody2D rb;
    
    public float speed = 1500f;
    public float rotationSpeed = 15f;
    public float fuel = 1;
    public float fuelconsume = 0.1f;
    public float max_turbo = 100f;
    public float turbo;
    public float turbo_force = 3000f;
    private float movement = 0f;
    private float rotation = 0f;
    private bool isTurbo;

    

    private void Start()
    {
        turbo = max_turbo;
    }

    void Update()
    {
        movement = Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal");
        isTurbo = Input.GetButton("Jump");
    }
    private void FixedUpdate()
    {
        if (movement == 0f || fuel <= 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
            fuel -= fuelconsume * Time.fixedDeltaTime;
        }
        rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
        if (isTurbo == true && turbo > 0)
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = turbo_force, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
            turbo--;
        }
    }
}
