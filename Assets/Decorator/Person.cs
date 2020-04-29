using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    private string name;
    public Person()
    {

    }

    public Person(string name)
    {
        this.name = name;
    }

    public virtual void Show()
    {
        Debug.Log("Wear " + this.name);
    }
}
