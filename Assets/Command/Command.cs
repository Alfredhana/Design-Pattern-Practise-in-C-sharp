using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    protected Character target;

    public Command(Character target)
    {
        this.target = target;
    }

    public Command() { }

    public abstract void Execute();
    public abstract void Undo();
}
