using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAmmo
{
    public enum AmmoType { Physical, Ice, Fire, Elemental, Magical}
    public float damage { get; set; }
    public float speed { get; set; }
    public AmmoType ammoTypes { get; set; }
}
