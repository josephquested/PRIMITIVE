﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorCrouch : MonoBehaviour {

	// Crouch //

	public void ReceiveCrouch (bool crouchButton)
	{
		if (crouchButton)
		{
			transform.localScale = new Vector3(1, 0.5f, 1);
		}
		else
		{
			transform.localScale = new Vector3(1, 1, 1);
		}
	}
}
