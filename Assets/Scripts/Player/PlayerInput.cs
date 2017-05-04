﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// SYSTEM //

	PlayerController playerController;

	void Start ()
	{
		playerController = GetComponent<PlayerController>();
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
		playerController.ReceiveMovement(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}

	// FIRE //

	void UpdateFire ()
	{
		playerController.ReceiveFire(Input.GetButtonDown("Fire"));
	}

	// BLOCK //

	void UpdateBlock ()
	{
		playerController.ReceiveBlock(Input.GetButton("Block"));
	}

	// CROUCH //

	void UpdateCrouch ()
	{
		playerController.ReceiveCrouch(Input.GetButton("Crouch"));
	}
}
