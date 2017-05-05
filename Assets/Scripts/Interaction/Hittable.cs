﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour {

	// HIT //

	public int hitpoints;

	public void ReceiveHit (Hit hit)
	{
		hitpoints -= hit.damage;
		CheckIfDead();
	}

	// DEATH //

	public GameObject deathEventPrefab;

	void CheckIfDead ()
	{
		if (hitpoints <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
		if (deathEventPrefab != null) { Instantiate(deathEventPrefab, transform.position, transform.rotation); }
		Destroy(gameObject);
	}
}
