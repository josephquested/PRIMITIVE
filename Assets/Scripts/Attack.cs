﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	Animator anim;

	Rigidbody rb;

	public float thrust;

	void Start ()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		anim.SetBool("Warm", Input.GetButton("Fire1"));
		if (Input.GetButtonUp("Fire1"))
		{
			anim.SetTrigger("Attack");
			Thrust();
		}
	}

	void Thrust ()
	{
		rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
	}
}
