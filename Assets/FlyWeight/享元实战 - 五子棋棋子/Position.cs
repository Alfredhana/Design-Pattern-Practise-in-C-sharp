using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position
{
    public Position(float x, float y)
    {
        this.position = new Vector2(x, y);
    }

    private Vector2 position;
    public Vector2 pos
    {
        get { return position; }
    }
}
