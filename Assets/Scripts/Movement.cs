using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

 	// SYSTEM //

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	public void ReceiveInput (float horizontal, float vertical)
	{
		Move(GetMovement(horizontal, vertical));
	}

	// MOVEMENT //

	Rigidbody rb;

	public float speed;
	public float baseSpeed;
	public float blockSpeed;

	Vector3 GetMovement (float horizontal, float vertical)
	{
		Vector3 movement = new Vector3(horizontal, 0, vertical);
		if (horizontal != 0 && vertical != 0) { movement *= 0.75f; }
		return movement * speed;
	}

	void Move (Vector3 movement)
	{
		rb.AddForce(movement, ForceMode.Impulse);
	}
}
