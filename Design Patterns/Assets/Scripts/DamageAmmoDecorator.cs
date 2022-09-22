using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageAmmoDecorator
{
    public float damageMod { get; set; }
    public float speedMod { get; set; }

    public DamageAmmoDecorator(float _damageMod, float _speedMod)
    {
        damageMod = _damageMod;
        speedMod = _speedMod;
    }

    public abstract IAmmo Decorate(IAmmo ammo);
}
