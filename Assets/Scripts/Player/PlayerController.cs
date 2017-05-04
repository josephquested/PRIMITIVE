﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		playerMovement = GetComponent<PlayerMovement>();
		playerCrouch = GetComponent<PlayerCrouch>();
		weapon = GetComponentInChildren<Weapon>();
	}

	// MOVEMENT //

	PlayerMovement playerMovement;

	public void ReceiveMovement (float horizontal, float vertical)
	{
		if (horizontal != 0 || vertical != 0)
		{
			playerMovement.ReceiveMovement(horizontal, vertical);
		}
	}

	// FIRE //

	Weapon weapon;

	public void ReceiveFire (bool fireDown)
	{
		if (fireDown)
		{
			weapon.FireDown();
		}
	}

	// CROUCH //

	PlayerCrouch playerCrouch;

	public void ReceiveCrouch (bool crouchButton)
	{
		playerCrouch.ReceiveCrouch(crouchButton);
	}
}
