using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GatherAI : MonoBehaviour, IUnit
{

    [SerializeField] private Transform potatoNodeTransform;
    [SerializeField] private Transform crateNodeTransform;

    private IUnit unit;

    public bool IsIdle()
    {
        return unit.IsIdle();
    }

    public void MoveTo(Vector3 position, float stopDistance, Action onArrivedAtPosition)
    {
        unit.MoveTo(position, stopDistance, onArrivedAtPosition);
    }

    public void PlayAnimationCollect(Vector3 lookAtPosition, Action onAnimationComplete)
    {
        unit.PlayAnimationCollect(lookAtPosition, onAnimationComplete);
    }

    private void Awake()
    {
        Debug.Log("Left");
        unit = gameObject.GetComponent<IUnit>();
        Debug.Log("Right");

        unit.IsIdle();
        unit.MoveTo(potatoNodeTransform.position, 10.0f, () => 
        {
            unit.PlayAnimationCollect(potatoNodeTransform.position, () =>
            {
                unit.MoveTo(crateNodeTransform.position, 5.0f, null);
            });
        });
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
