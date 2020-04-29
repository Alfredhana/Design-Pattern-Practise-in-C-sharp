using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memento
{
    /* 在不破坏封装性的前提下
     * 捕获一个对象的内部状态
     * 并在改对象之外保存这个状态
     * 以后就可将该状态恢复到原先保存的状态
     */

    public Memento(int health, int atk, int def)
    {
        this.health = health;
        this.atk = atk;
        this.def = def;
    }

    private int health;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    private int atk;
    public int Attack
    {
        get { return atk; }
        set { atk = value; }
    }

    private int def;
    public int Deffense
    {
        get { return def; }
        set { def = value; }
    }
}
