using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sneaker : Cloth
{
    public override void Show()
    {
        Debug.Log("Sneaker!");
        base.Show();
    }
}
