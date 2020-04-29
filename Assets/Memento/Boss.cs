using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    public Boss(string name)
    {
        this.name = name;
    }

    private string name;
    private int health;
    private int atk;
    private int def;

    public Memento SaveState()
    {
        return (new Memento(health, atk, def));
    }

    public void RecoverState(Memento memento)
    {
        this.health = memento.Health;
        this.atk = memento.Attack;
        this.def = memento.Deffense;
    }

    public void StateDisplay()
    {
        Debug.Log(this.name + " Current State: ");
        Debug.Log("Health : " + this.health);
        Debug.Log("Attack : " + this.atk);
        Debug.Log("Deffense : " + this.def);
    }

    public void InitState()
    {
        this.health = 100;
        this.atk = 100;
        this.def = 100;
    }

    public void FinishFight()
    {
        this.health = 0;
        this.atk = 0;
        this.def = 0;
    }
}
