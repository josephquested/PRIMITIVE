using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unarmed : Weapon {

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

  public override void BlockStart ()
  {
    anim.SetBool("Block", true);
  }

  public override void BlockStop ()
  {
    anim.SetBool("Block", false);
  }
}
