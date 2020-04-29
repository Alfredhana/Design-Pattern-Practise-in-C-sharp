using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using VisitorConcreteHuman;
public abstract class Action
{
    public abstract void GetManConclution(Man concreteElementA);
    public abstract void GetWomanConclution(Woman concreteElementB);
}

