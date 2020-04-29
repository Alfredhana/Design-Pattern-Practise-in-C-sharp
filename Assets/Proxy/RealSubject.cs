using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealSubject : ISubject
{
    Girl girl;
    public RealSubject(Girl girl)
    {
        this.girl = girl;
    }

    public void GiveDoll()
    {
        Debug.Log("Give " + girl.Name + " Doll");
    }

    public void GiveFlowers()
    {
        Debug.Log("Give " + girl.Name + " Flowers");
    }

    public void GiveChocolate()
    {
        Debug.Log("Give " + girl.Name + " Chocolate");
    }
}
