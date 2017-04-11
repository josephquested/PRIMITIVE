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
    firing = true;
    canFire = false;
    anim.SetBool("Warm", false);
    anim.SetTrigger("Fire");
    Thrust();
    firing = false;
  }

  public virtual void DamageObject (GameObject hitObj)
  {
    hitObj.GetComponent<Hitpoints>().ReceiveDamage(damage);
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
  }
}
