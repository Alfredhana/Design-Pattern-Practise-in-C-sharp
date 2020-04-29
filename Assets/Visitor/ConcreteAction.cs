using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using VisitorConcreteHuman;
namespace VisitorConcreteAction
{
    public class Success : Action
    {
        public override void GetManConclution(Man concreteElementA)
        {
            Debug.Log(concreteElementA.GetType().Name + " " + this.GetType().Name + " 时，背后有一个伟大的女人");
        }

        public override void GetWomanConclution(Woman concreteElementB)
        {
            Debug.Log(concreteElementB.GetType().Name + " " + this.GetType().Name + " 时，背后有一个不成功的男人");
        }
    }

    public class Failing : Action
    {
        public override void GetManConclution(Man concreteElementA)
        {
            Debug.Log(concreteElementA.GetType().Name + " " + this.GetType().Name + " 时，闷头喝酒");
        }

        public override void GetWomanConclution(Woman concreteElementB)
        {
            Debug.Log(concreteElementB.GetType().Name + " " + this.GetType().Name + " 时，谁也劝不了");
        }
    }

    public class Amativeness : Action
    {
        public override void GetManConclution(Man concreteElementA)
        {
            Debug.Log(concreteElementA.GetType().Name + " " + this.GetType().Name + " 时，不懂也装懂");
        }

        public override void GetWomanConclution(Woman concreteElementB)
        {
            Debug.Log(concreteElementB.GetType().Name + " " + this.GetType().Name + " 时，遇事装不懂");
        }
    }
}
