using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    protected string name;
    protected IObservable observable;
    public Observer(string name, IObservable observable)
    {
        this.name = name;
        this.observable = observable;
    }

    public void UpdateSelf()
    {
        Debug.Log(observable.SecretaryAction + " " + name + DoJob());
    }

    public virtual string DoJob()
    {
        return "";
    }
}
