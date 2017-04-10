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

	public void Warm ()
	{
		anim.SetBool("Warm", true);
	}

	public void Fire ()
	{
		anim.SetBool("Warm", false);
		anim.SetTrigger("Fire");
		Thrust();
	}

	void Thrust ()
	{
		rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
	}
}
