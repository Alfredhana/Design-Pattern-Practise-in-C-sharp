using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Human
{
    public abstract void Accept(Action visitor);
}
