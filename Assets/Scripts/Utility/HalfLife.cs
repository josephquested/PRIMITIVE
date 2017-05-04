﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLife : MonoBehaviour {

	// SYSTEM //

	public float halflife;

	void Start ()
	{
		Destroy(gameObject, halflife);
	}
}
