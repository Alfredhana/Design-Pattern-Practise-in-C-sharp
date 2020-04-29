using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStructure
{
    private IList<Human> elements = new List<Human>();

    public void Attach(Human element)
    {
        elements.Add(element);
    }

    public void Detach(Human element)
    {
        elements.Remove(element);
    }

    public void Display(Action visitor)
    {
        foreach (Human e in elements)
        {
            e.Accept(visitor);
        }
    }
}
