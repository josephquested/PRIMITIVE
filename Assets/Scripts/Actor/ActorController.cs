﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		actorMovement = GetComponent<ActorMovement>();
		actorCrouch = GetComponent<ActorCrouch>();
		actorSpecial = GetComponent<ActorSpecial>();
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
		if (fireDown && !specialButton)
		{
			weapon.FireDown();
		}
	}

	// SPECIAL //

	ActorSpecial actorSpecial;

	bool specialButton;

	public void ReceiveSpecial (bool _specialButton)
	{
		specialButton = _specialButton;
		actorSpecial.ReceiveSpecial(specialButton);
	}

	// CROUCH //

	ActorCrouch actorCrouch;

	public void ReceiveCrouch (bool crouchButton)
	{
		actorCrouch.ReceiveCrouch(crouchButton);
	}
}
