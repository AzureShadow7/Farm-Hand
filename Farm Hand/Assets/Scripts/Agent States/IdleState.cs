using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{

    Agent worker;

    public IdleState(Agent worker)
    {
        this.worker = worker;
    }

    public override void Enter()
    {
        Debug.Log("Entering idle state");
    }

    public override void Execute()
    {
        Debug.Log("Executing idle state");
    }

    public override void Exit()
    {
        Debug.Log("Exiting Idle state");
    }
}
