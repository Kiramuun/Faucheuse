using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BulletSpeed : ScriptableObject
{
    public float speed = 1200;
    public float bonuSpeed = 1.05f;

    void OnEnable()
    {
        speed = 1200;
    }

}
