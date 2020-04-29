using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConcreteCommand
{
    public class MoveCommand : Command
    {
        private Vector3 direction;
        public MoveCommand(Character target, Vector3 direction) : base(target)
        {
            this.direction = direction;
        }

        public override void Execute()
        {
            target.transform.position += direction * Time.deltaTime * target.speed;
        }

        public override void Undo()
        {
            target.transform.position -= direction * Time.deltaTime * target.speed;
        }
    }

}
