using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INeeds
{
    void Fatigue(float fatigue);

    void Rest();

    float maxExhaustion { get; set; }

    float currentExhaustion { get; set; }
}
