using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decorator :  Beverage
{
    protected Beverage beverage;

    public Decorator(Beverage beverage)
    {
        this.beverage = beverage;
    }
}
