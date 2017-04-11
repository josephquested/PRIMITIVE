using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unarmed : Weapon {

  // OFFENCE //

  public override void Warm ()
  {
    anim.SetBool("Warm", true);
    canFire = true;
  }

  public override void Fire ()
  {
    canFire = false;
    anim.SetBool("Warm", false);
    anim.SetTrigger("Fire");
    Thrust();
  }

  public virtual void DamageObject (GameObject hitObj)
  {
    if (IsFiring())
    {
      hitObj.GetComponent<Hitpoints>().ReceiveDamage(damage);
    }
  }

  // DEFENCE //

  public override void Block (bool shouldBlock)
  {
    anim.SetBool("Block", shouldBlock);
  }

  // PHYSICS //

  public override void ReceiveHitObject (GameObject hitObj)
  {
    DamageObject(hitObj);
    Knockback(hitObj, transform.forward);
  }
}
