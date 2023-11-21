using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : StateMachineBehaviour
{
    public GameObject _bulletPrefab;
    public Transform _groupBullets;
    public float _bulletSpeed;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2[] dir = new Vector2[4]
        {
            Vector2.right,
            Vector2.up,
            Vector2.left,
            Vector2.down
        };
        
        for (int i = 0; i < 4; i++)
        {
            GameObject newBullet = Object.Instantiate(_bulletPrefab, animator.gameObject.transform);
            newBullet.transform.localPosition = Vector2.zero;
            newBullet.GetComponent<Rigidbody2D>().AddForce(dir[i] * _bulletSpeed);
            newBullet.transform.parent = _groupBullets;
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
