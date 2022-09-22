using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDecorator : DamageAmmoDecorator
{
    public FireDecorator(float _damage, float _speed) : base(_damage, _speed) { }

    public override IAmmo Decorate(IAmmo _ammo)
    {
        Debug.Log("Making Fire ammo");
        _ammo.ammoTypes |= IAmmo.AmmoType.Fire;
        _ammo.damage *= 3f;
        _ammo.speed *= 1f;
        return _ammo;
    }
}
