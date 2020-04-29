using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterBuilder
{
    private string name;
    public string Name
    {
        get { return name; }
    }
    private int speed;
    private int ATK;

    public MonsterBuilder(string name, int speed, int ATK)
    {
        this.name = name;
        this.speed = speed;
        this.ATK = ATK;
    }

    public abstract void BuildHead();
    public abstract void BuildBody();
    public abstract void BuildLegs();

}
