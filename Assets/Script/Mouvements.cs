using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    Vector2 _mouvementInput;

    public float _speed;

    Rigidbody2D _rigidB;

    void Awake()
    {
        _rigidB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _mouvementInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        _rigidB.velocity = _mouvementInput * _speed;
    }
}
