using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConcreteStatus
{

    public class IdleState : Status
    {
        AI ai;
        public IdleState(AI ai)
        {
            this.ai = ai;
        }

        public void CheckAttacker()
        {
            if (ai.hasAttacker)
            {
                ai.ChangeStatus(ai.chaseState);
            }
        }

        public void CheckPosition()
        {
            Debug.Log("The AI is patrolling in its own position");
        }

        public void CheckRotation()
        {
            ai.InitialRotation();
        }

        public void MovePosition()
        {
            Debug.Log("It would not move oh!");
        }
    }

    public class ChaseState : Status
    {
        AI ai;
        public ChaseState(AI ai)
        {
            this.ai = ai;
        }

        public void CheckAttacker()
        {
            if (Vector3.Distance(ai.Player.transform.position, ai.transform.position) > ai.maxChasingDistance)
            {
                // 与敌人距离过大，追丢的情况
                ai.ChangeStatus(ai.backState);
                ai.ResetAttacker();
                return;
            }
            if (Vector3.Distance(ai.BasePosition, ai.transform.position) > ai.maxHomeDistance)
            {
                // 离开原始位置过远的情况
                ai.ChangeStatus(ai.backState);
                ai.ResetAttacker();
                return;
            }
        }

        public void CheckPosition()
        {
            Debug.Log("The AI is Moving");
        }

        public void CheckRotation()
        {
            if (!ai.IsFacing("Player"))
                ai.RotateTo("Player");
        }
        
        public void MovePosition()
        {
            ai.MoveToPosition("Player");
        }
    }

    public class BackState : Status
    {
        AI ai;
        public BackState(AI ai)
        {
            this.ai = ai;
        }

        public void CheckAttacker()
        {
            Debug.Log("The AI Has no attacker");
        }

        public void CheckPosition()
        {
            if (ai.IsInPosition(ai.BasePosition))
            {
                ai.ChangeStatus(ai.idleState);
                return;
            }
        }

        public void CheckRotation()
        {
            if (!ai.IsFacing("Home"))
                ai.RotateTo("Home");
        }

        public void MovePosition()
        {
            ai.MoveToPosition(ai.BasePosition);
        }
    }
}
