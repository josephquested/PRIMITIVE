﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		actorMovement = GetComponent<ActorMovement>();
		actorCrouch = GetComponent<ActorCrouch>();
		actorBlock = GetComponent<ActorBlock>();
		weapon = GetComponentInChildren<Weapon>();
	}

	// MOVEMENT //

	ActorMovement actorMovement;

	public void ReceiveMovement (float horizontal, float vertical)
	{
		if (horizontal != 0 || vertical != 0)
		{
			actorMovement.ReceiveMovement(horizontal, vertical);
		}
	}

	// FIRE //

	Weapon weapon;

	public void ReceiveFire (bool fireDown)
	{
		if (fireDown && !blocking)
		{
			weapon.FireDown();
		}
	}

	// BLOCK //

	ActorBlock actorBlock;

	bool blocking;

	public void ReceiveBlock (bool blockButton)
	{
		blocking = blockButton;
		actorBlock.ReceiveBlock(blockButton);
	}

	// CROUCH //

	ActorCrouch actorCrouch;

	public void ReceiveCrouch (bool crouchButton)
	{
		actorCrouch.ReceiveCrouch(crouchButton);
	}
}
