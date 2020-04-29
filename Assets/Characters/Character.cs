using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string name;
    public string Name {
        get { return name; }
    }

    public float speed;
    public float turnSpeed;

    public Character(string name)
    {
        this.name = name;
    }
}
