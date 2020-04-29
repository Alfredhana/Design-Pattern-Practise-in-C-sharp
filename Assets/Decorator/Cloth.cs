using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth : Person
{
    protected Person component;
    
    public void Decorate(Person component)
    {
        this.component = component;
    }

    public override void Show()
    {
        if (component != null)
        {
            component.Show();
        }
    }
}
