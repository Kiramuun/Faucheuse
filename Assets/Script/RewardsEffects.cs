using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RewardsEffects : MonoBehaviour
{
    public UnityEvent afterEnnemyDeath,
                      afterAttack;
    public GameObject buttonPanel;

    public BulletSpeed speedReward;

    void Start()
    {
        
    }

    public void AddBonusBullet()
    {
        afterEnnemyDeath.AddListener(CreateBonusBullet);
        Time.timeScale = 1;
        buttonPanel.SetActive(false);
    }

    public void AddVitesseBullet()
    {
        speedReward.speed *= speedReward.bonuSpeed;
        Time.timeScale = 1;
        buttonPanel.SetActive(false);
    }

    void CreateBonusBullet()
    {
        
    }

   
}
