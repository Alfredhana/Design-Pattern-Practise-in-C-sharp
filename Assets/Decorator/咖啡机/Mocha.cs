using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mocha : Decorator
{
    public Mocha(Beverage beverage) : base(beverage) { }

    public override string getDescription()
    {
        return beverage.getDescription() + ", Mocha";
    }

    public override double cost()
    {
        return .2 + beverage.cost();
    }
}
