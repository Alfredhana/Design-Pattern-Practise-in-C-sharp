using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICharacter
{
    protected IWeapon weapon;
    public void SetWeapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public virtual void Attack(ICharacter target)
    {
        weapon.Fire(target);
    }
}
