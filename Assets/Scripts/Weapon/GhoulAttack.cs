﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulAttack : Weapon {

	// SYSTEM //

	public GameObject attackPrefab;
	public Transform attackSpawn;

	// INPUT //

	public override void FireDown ()
	{
		FireAttack();
	}

	// FIRE //

	public Animator anim;
	public Rigidbody rb;

	public float attackSpeed;
	public float thrustForce;

	void FireAttack ()
	{
		GameObject attackObj = Instantiate(attackPrefab, attackSpawn.position, attackSpawn.rotation);
		attackObj.GetComponent<Rigidbody>().AddForce(transform.forward * attackSpeed, ForceMode.Impulse);
		anim.SetTrigger("Attack");
		Thrust();
	}

	void Thrust ()
	{
		rb.AddForce(transform.forward * thrustForce, ForceMode.Impulse);
	}
}
