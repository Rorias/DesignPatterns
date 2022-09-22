using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public IWeapon weapon;
    public IAmmo ammo;

    public void Awake()
    {
        weapon = new Weapon();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("shooting ice bullets");

            GameObject bullet = AmmoPool.Instance.RequestBullet();

            IceDecorator ice = new IceDecorator(50, 0.5f);
            ice.Decorate(bullet.GetComponent<Ammo>());

            weapon.Fire(bullet);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("shooting fire bullets");

            GameObject bullet = AmmoPool.Instance.RequestBullet();

            FireDecorator fire = new FireDecorator(20, 1f);
            fire.Decorate(bullet.GetComponent<Ammo>());

            weapon.Fire(bullet);
        }
    }
}
