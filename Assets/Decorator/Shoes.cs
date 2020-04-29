using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoes : Cloth
{
    public override void Show()
    {
        Debug.Log("Shoes!");
        base.Show();
    }
}
