using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie : MonoBehaviour
{
    Rigidbody2D _yokaiRigid;
    float _yokaiSpeed = 3f;
    public int _yokaiHp = 1;

    private void Awake()
    {
        _yokaiRigid = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 Walker = transform.position-GameObject.Find("Triangle").transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector2.down, Walker);
    }

    private void FixedUpdate()
    {
        _yokaiRigid.velocity = transform.up * _yokaiSpeed;
    }
}
