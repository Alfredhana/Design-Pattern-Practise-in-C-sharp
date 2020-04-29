using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trouser : Cloth
{
    public override void Show()
    {
        Debug.Log("Trouser!");
        base.Show();
    }
}
