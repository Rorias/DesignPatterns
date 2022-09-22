using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDecorator : DamageAmmoDecorator
{
    public IceDecorator(float _damage, float _speed) : base(_damage, _speed) { }

    public override IAmmo Decorate(IAmmo _ammo)
    {
        Debug.Log("Making Ice ammo");
        _ammo.ammoTypes |= IAmmo.AmmoType.Ice;
        _ammo.damage *= 5f;
        _ammo.speed *= 0.5f;
        return _ammo;
    }
}
