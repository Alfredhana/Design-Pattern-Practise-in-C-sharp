using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    public Vector3 ReadInput()
    {
        float x = 0;
        if (Input.GetKey(KeyCode.A))
            x = -1;
        else if (Input.GetKey(KeyCode.D))
            x = 1;

        float y = 0;
        if (Input.GetKey(KeyCode.S))
            y = -1;
        else if (Input.GetKey(KeyCode.W))
            y = 1;

        if (x != 0 || y != 0)
        {
            Vector3 direction = new Vector3(x, 0, y);
            return direction;
        }
        return Vector3.zero;
    }

    internal bool ReadDo()
    {
        return Input.GetButtonDown("Submit");
    }

    internal bool ReadUndo()
    {
        return Input.GetKey(KeyCode.Backspace);
    }
}
