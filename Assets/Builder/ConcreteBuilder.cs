using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConcreteBuilder
{
    public class MonsterBigBuilder : MonsterBuilder
    {
        public MonsterBigBuilder(string name, int speed, int ATK) : base(name, speed, ATK)
        {

        }

        public override void BuildBody()
        {
            Debug.Log(Name + " Body Built!");
        }

        public override void BuildHead()
        {
            Debug.Log(Name + " Head Built!");
        }

        public override void BuildLegs()
        {
            Debug.Log(Name + " Legs Built!");
        }
    }

    public class MonsterSmallBuilder : MonsterBuilder
    {
        public MonsterSmallBuilder(string name, int speed, int ATK) : base(name, speed, ATK)
        {

        }

        public override void BuildBody()
        {
            Debug.Log(Name + " Body Built!");
        }

        public override void BuildHead()
        {
            Debug.Log(Name + " Head Built!");
        }

        public override void BuildLegs()
        {
            Debug.Log(Name + " Legs Built!");
        }
    }
}

