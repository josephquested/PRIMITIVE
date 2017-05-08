﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	// SYSTEM //

	public GameObject destroyEventPrefab;

	// DAMAGE //

	public int damage;

	// KNOCKBACK //

	public float knockback;

	void Knockback (Collider collider)
	{
		collider.GetComponent<Rigidbody>().AddForce(transform.forward * knockback, ForceMode.Impulse); 
	}

	// COLLISION //

	public bool destroyOnCollision;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.GetComponent<Hittable>() != null)
		{
			HitCollider(collider);
			Knockback(collider);
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
