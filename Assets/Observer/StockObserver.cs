using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockObserver : Observer
{
    public StockObserver(string name, IObservable sub) : base(name, sub) { }
    
    public override string DoJob()
    {
        return " Close Stock, back to work!";
    }
}
