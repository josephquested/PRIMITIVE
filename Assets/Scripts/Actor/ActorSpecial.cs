﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorSpecial : MonoBehaviour {

	// SYSTEM //

	Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	// BLOCK //

	public void ReceiveSpecial (bool specialButton)
	{
		anim.SetBool("Special", specialButton);
	}
}
