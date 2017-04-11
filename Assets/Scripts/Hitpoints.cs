using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitpoints : MonoBehaviour {

	// DAMAGE SYSTEM //

	public void ReceiveDamage (int damage)
	{
		print(gameObject.name + " took damage: " + damage);
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
