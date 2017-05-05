﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayer : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		GetComponentInChildren<AudioListener>().enabled = true;
		PlayerInput playerInput = gameObject.AddComponent<PlayerInput>() as PlayerInput;
		RotateToCursor rotateToCursor = gameObject.AddComponent<RotateToCursor>() as RotateToCursor;
	}

	void Update ()
	{

	}
}
