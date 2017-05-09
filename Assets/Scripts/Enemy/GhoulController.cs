﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhoulController : MonoBehaviour {

	// SYSTEM //

	public Transform goal;

	void Start ()
	{
	  agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.speed = Random.Range(minSpeed, maxSpeed);
	}

	void Update ()
	{
		agent.destination = goal.position;
	}

	// NAVIGATION //

	NavMeshAgent agent;

	public float minSpeed;
	public float maxSpeed;

}
