using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Weapon : ICloneable
{
    private string name;
    private string weaponType;
    public string WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    private float atkBuff;
    public float ATKBuff
    {
        get { return atkBuff; }
        set { atkBuff = value; }
    }

    public object Clone()
    {
        return (Weapon)this.MemberwiseClone();
    }
}
