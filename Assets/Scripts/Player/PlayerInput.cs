﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// SYSTEM //

	ActorController actorController;

	void Start ()
	{
		actorController = GetComponent<ActorController>();
	}

	void FixedUpdate ()
	{
		UpdateMovement();
	}

	void Update ()
	{
		UpdateFire();
		UpdateSpecial();
		UpdateCrouch();
	}

	// MOVEMENT //

	void UpdateMovement ()
	{
		actorController.ReceiveMovement(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}

	// FIRE //

	void UpdateFire ()
	{
		actorController.ReceiveFire(Input.GetButtonDown("Fire"));
	}

	// SPECIAL //

	void UpdateSpecial ()
	{
		actorController.ReceiveSpecial(Input.GetButton("Special"));
	}

	// CROUCH //

	void UpdateCrouch ()
	{
		actorController.ReceiveCrouch(Input.GetButton("Crouch"));
	}
}
