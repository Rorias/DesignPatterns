using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour, IAmmo
{
    public float damage { get; set; } = 5;
    public float speed { get; set; } = 1;
    public IAmmo.AmmoType ammoTypes { get; set; } = IAmmo.AmmoType.Physical;
}
