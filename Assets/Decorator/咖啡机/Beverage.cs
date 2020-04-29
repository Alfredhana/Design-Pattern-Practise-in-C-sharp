using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Beverage
{
    protected string description;
    protected string size;
    
    public virtual string getDescription()
    {
        return description;
    }

    public abstract double cost();

    public string getSize()
    {
        return size;
    }

    public void setSize(string size)
    {
        this.size = size;
    }
}
