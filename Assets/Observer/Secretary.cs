using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secretary : MonoBehaviour, IObservable
{
    private IList<Observer> observers = new List<Observer>();
    private string action;

    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void DeTach(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Nofity()
    {
        foreach (Observer observer in observers)
        {
            observer.Update();
        }
    }

    
    public string SecretaryAction
    {
        get { return action; }
        set { action = value; }
    }
}
