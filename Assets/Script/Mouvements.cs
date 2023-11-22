using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    Vector2 _mouvementInput;

    public InputManager inputManager;

    public float _speed;

    Rigidbody2D _rigidB;

    void Awake()
    {
        _rigidB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _mouvementInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized;

        Vector3 dirRotate = inputManager.mousePosInGame - transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward,dirRotate);
    }

    void FixedUpdate()
    {
        _rigidB.velocity = _mouvementInput * _speed;
    }
}
