using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightFactory
{
    private Hashtable flyweights = new Hashtable();
    
    public FlyWeight GetFlyweight(string key)
    {
        if (!flyweights.ContainsKey(key))
            flyweights.Add(key, new ConcreteFlyWeight(key));
        return ((FlyWeight)flyweights[key]);
    }

    public int GetFlyWeightCount()
    {
        return flyweights.Count;
    }
}
