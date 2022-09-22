using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : IWeapon
{
    public Weapon()
    {
    }

    public void Fire(GameObject _bullet)
    {
        _bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(5 * _bullet.GetComponent<Ammo>().speed, 0);
        Debug.Log(_bullet.GetComponent<Ammo>().damage);
        Debug.Log(_bullet.GetComponent<Ammo>().ammoTypes);
    }
}
