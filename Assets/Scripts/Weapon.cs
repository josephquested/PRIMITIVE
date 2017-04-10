using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	Animator anim;
	Rigidbody rb;

	public bool canWarm;
	public bool canFire;

	public float thrust;

	void Start ()
	{
		anim = GetComponent<Animator>();
		rb = transform.parent.GetComponent<Rigidbody>();
	}

	public virtual void Warm ()
	{
		anim.SetBool("Warm", true);
		canFire = true;
	}

	public virtual void Fire ()
	{
		anim.SetBool("Warm", false);
		anim.SetTrigger("Fire");
		canFire = false;
		Thrust();
	}

	public virtual void Thrust ()
	{
		rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
	}
}
