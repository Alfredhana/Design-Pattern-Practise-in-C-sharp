using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        description = "House Blend Coffee";
    }

    public override double cost()
    {
        return .89;
    }
}
