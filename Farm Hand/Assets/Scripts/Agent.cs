using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour, INeeds
{
    [field: SerializeField] public float maxExhaustion { get; set; } = 100.0f;
    public float currentExhaustion { get; set; }

    public StateController stateController { get; set; }

    public void Start()
    {
        stateController = new StateController();
        stateController.ChangeState(new IdleState(this));
    }

    public void Update()
    {
        stateController.Update();
    }

    public void Fatigue(float fatigue)
    {
        
    }

    public void Rest()
    {
        
    }

    
}
