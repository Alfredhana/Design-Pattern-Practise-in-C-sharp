using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteFlyWeight : FlyWeight
{
    public ConcreteFlyWeight(string name) : base(name) { }

    public override void Operation()
    {
        Debug.Log("Concrete Operation : " + Name);
    }
}
