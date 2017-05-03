﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// SYSTEM //

	public Transform target;

	void Update ()
	{
		if (target != null)
		{
			FollowTarget();
		}
	}

	void FollowTarget ()
	{
		transform.position = new Vector3(target.position.x, target.position.y + 11, target.position.z - 10);
	}
}
