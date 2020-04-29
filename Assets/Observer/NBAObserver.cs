using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBAObserver : Observer
{
    public NBAObserver(string name, IObservable sub) : base(name, sub) { }
    
    public override string DoJob()
    {
        return " Close NBA Live, back to work!";
    }
}
