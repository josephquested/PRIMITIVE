﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnStaticImpact : MonoBehaviour {

	// SYSTEM //

	public GameObject destroyEventPrefab;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.isStatic)
		{
			if (destroyEventPrefab)
			{
				Instantiate(destroyEventPrefab, transform.position, transform.rotation);
			}
			Destroy(gameObject);
		}
	}
}
