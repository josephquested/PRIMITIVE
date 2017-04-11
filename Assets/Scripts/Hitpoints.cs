using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitpoints : MonoBehaviour {

	// DAMAGE SYSTEM //

	public int hitpoints;
	public bool damageable;

	public void ReceiveDamage (int damage)
	{
		hitpoints -= damage;
	}

	// PHYSICS //

	void OnCollisionEnter (Collision collision)
	{
		if (collision.collider.GetComponent<Hit>())
		{
			collision.collider.GetComponent<Hit>().ReceiveHitObject(gameObject);
		}
	}
}
