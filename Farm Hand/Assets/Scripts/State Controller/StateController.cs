using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController
{ 
    State currentState;

    public void ChangeState(State newState)
    {
        if (currentState != null)
        {
            currentState.Exit();
        }
        currentState = newState;
        newState.Enter();
    }

    public void Update()
    {
        if(currentState != null) currentState.Execute();
    }
}
