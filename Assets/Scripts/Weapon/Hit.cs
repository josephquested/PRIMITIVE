﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	// SYSTEM //

	public GameObject destroyEventPrefab;

	// DAMAGE //

	public int damage;

	// COLLISION //

	public bool destroyOnCollision;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.GetComponent<Hittable>() != null)
		{
			HitCollider(collider);
		}
	}

	void HitCollider (Collider collider)
	{
		collider.GetComponent<Hittable>().ReceiveHit(this);
		if (destroyOnCollision)
		{
			if (destroyEventPrefab != null) { Instantiate(destroyEventPrefab, transform.position, transform.rotation); }
			Destroy(gameObject);
		}
	}
}
