using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IWeapon
{
    protected int atk;
    protected float range;

    public abstract void Fire(ICharacter target);
}
