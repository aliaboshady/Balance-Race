﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CarController : MonoBehaviour {
	public float speed = 1500;
	public float rotationSpeed = 15;
	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;
	public Rigidbody2D rb;
	float movement = 0f;
	float rotation = 0f;

	void Update(){
		movement = -Input.GetAxisRaw ("Vertical") * speed;
		rotation = Input.GetAxisRaw ("Horizontal");
	}

	void FixedUpdate(){
		if (movement == 0f) {
			backWheel.useMotor = false;
			frontWheel.useMotor = false;
		} else {
			backWheel.useMotor = true;
			frontWheel.useMotor = true;
			JointMotor2D motor = new JointMotor2D{ motorSpeed = movement, maxMotorTorque = 10000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;
		}

		rb.AddTorque (-rotation * rotationSpeed * Time.fixedDeltaTime);
	}
}