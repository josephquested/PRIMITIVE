using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	// SYSTEM //

	public Animator anim;

	void Awake ()
	{
		anim = GetComponent<Animator>();
		rb = transform.parent.GetComponent<Rigidbody>();
	}

	// OFFENCE //

	public int damage;
	public bool firing;
	public bool canWarm;
	public bool canFire;

	public virtual void Warm ()
	{
		// override
	}

	public virtual void Fire ()
	{
		// override
	}

	// DEFENCE //

	public virtual void Block (bool shouldBlock)
	{
		// override
	}

	// PHYSICS //

	Rigidbody rb;

	public float thrust;
	public float recoil;

	public virtual void ReceiveHitObject (GameObject hitObj)
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
