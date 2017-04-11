using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	// SYSTEM //
	
	public Weapon weapon;

	void Awake ()
	{
		SetWeapon();
	}

	public virtual void SetWeapon ()
	{
		weapon = transform.parent.GetComponent<Weapon>();
	}

	// PHYSICS //

	public virtual void ReceiveHitObject (GameObject hitObj)
	{
		weapon.ReceiveHitObject(hitObj);
	}
}
