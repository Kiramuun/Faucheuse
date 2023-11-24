using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CounterKill : ScriptableObject
{
    public int _ghostCount;

    void OnEnable()
    {
        _ghostCount = 0;
    }
}
