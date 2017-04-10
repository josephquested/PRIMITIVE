using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

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
		anim.SetBool("Warm", Input.GetButton("Fire"));
		if (Input.GetButtonUp("Fire"))
		{
			anim.SetTrigger("Fire");
			Thrust();
		}
	}

	void Thrust ()
	{
		rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
	}
}
