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
		UpdateBlock();
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

	// BLOCK //

	void UpdateBlock ()
	{
		actorController.ReceiveBlock(Input.GetButton("Block"));
	}

	// CROUCH //

	void UpdateCrouch ()
	{
		actorController.ReceiveCrouch(Input.GetButton("Crouch"));
	}
}
