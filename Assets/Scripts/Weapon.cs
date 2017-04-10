using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	Rigidbody rb;

	public Animator anim;

	public bool canWarm;
	public bool canFire;
	public bool firing;

	public float thrust;
	public float recoil;

	void Awake ()
	{
		rb = transform.parent.GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
	}

	public virtual void Warm ()
	{
		// override
	}

	public virtual void Fire ()
	{
		// override
	}

	public virtual void Thrust ()
	{
		rb.AddForce(transform.parent.transform.forward * thrust, ForceMode.Impulse);
	}

	public virtual void Recoil ()
	{
		rb.AddForce(-transform.parent.transform.forward * recoil, ForceMode.Impulse);
	}
}
