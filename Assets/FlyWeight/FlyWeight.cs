using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FlyWeight
{
    private string name;
    public string Name
    {
        get { return name; }
    }

    public FlyWeight(string name)
    {
        this.name = name;
    }
    public abstract void Operation();
}
