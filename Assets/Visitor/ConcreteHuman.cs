using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorConcreteHuman
{
    public class Man : Human
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclution(this);
        }
    }

    public class Woman : Human
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWomanConclution(this);
        }
    }
}