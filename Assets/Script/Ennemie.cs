using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie : MonoBehaviour
{
    Rigidbody2D _yokaiRigid;
    Animator _yokaiAnim;
    float _yokaiSpeed = 3f;
    public int _yokaiHp = 1;

    void Awake()
    {
        _yokaiRigid = GetComponent<Rigidbody2D>();
        _yokaiAnim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            _yokaiHp--;
            if (_yokaiHp == 0) 
            {
                _yokaiAnim.SetTrigger("New Trigger");
            }
            //else { Destroy(gameObject); }
        }
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
