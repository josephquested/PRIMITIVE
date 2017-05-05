﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorBlock : MonoBehaviour {

	// SYSTEM //

	Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	// BLOCK //

	public void ReceiveBlock (bool blockButton)
	{
		anim.SetBool("Block", blockButton);
	}
}
