﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour {

	// SYSTEM //

	// TRIGGER //

	public bool playerInTrigger;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			playerInTrigger = true;
		}
	}

	void OnTriggerExit (Collider collider)
	{
		if (collider.tag == "Player")
		{
			playerInTrigger = false;
		}
	}
}
