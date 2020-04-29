using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espresso : Beverage
{
    public Espresso()
    {
        description = "Espresso";
    }

    public override double cost()
    {
        return 1.99;
    }
}
