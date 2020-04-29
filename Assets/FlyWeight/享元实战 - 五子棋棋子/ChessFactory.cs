using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessFactory
{
    private Hashtable flyweights = new Hashtable();

    public Chess GetChess(string key)
    {
        if (!flyweights.ContainsKey(key))

            flyweights.Add(key, new ConcreteChess(key));
        return (Chess)flyweights[key];
    }

    public int GetFlyWeightCount()
    {
        return flyweights.Count;
    }
}
