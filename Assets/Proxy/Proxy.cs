using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proxy : ISubject
{
    RealSubject realSubject;
    public Proxy(Girl girl)
    {
        realSubject = new RealSubject(girl);
    }

    public void GiveDoll()
    {
        realSubject.GiveDoll();
    }

    public void GiveFlowers()
    {
        realSubject.GiveFlowers();
    }

    public void GiveChocolate()
    {
        realSubject.GiveChocolate();
    }
}
