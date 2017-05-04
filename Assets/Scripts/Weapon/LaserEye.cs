﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEye : Weapon {

	// SYSTEM //

	public GameObject laserPrefab;
	public Transform laserSpawn;

	// INPUT //

	public override void FireDown ()
	{
		FireLaser();
	}

	// FIRE //

	public float laserSpeed;

	void FireLaser ()
	{
		GameObject laserObj = Instantiate(laserPrefab, laserSpawn.position, laserSpawn.rotation);
		laserObj.GetComponent<Rigidbody>().AddForce(transform.forward * laserSpeed, ForceMode.Impulse);
	}
}
