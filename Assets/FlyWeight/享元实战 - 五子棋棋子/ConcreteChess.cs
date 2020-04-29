using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteChess : Chess
{
    private string name;
    public ConcreteChess(string name)
    {
        this.name = name;
    }

    public override void Place(Position pos)
    {
        Debug.Log(name + " in " + pos.pos);
    }
}
