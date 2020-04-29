using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnsharedConcreteFlyWeight : FlyWeight
{
    public UnsharedConcreteFlyWeight(string name) : base(name) { }

    public override void Operation()
    {
        Debug.Log("Unshared Concrete Operation : " + Name);
    }
}
