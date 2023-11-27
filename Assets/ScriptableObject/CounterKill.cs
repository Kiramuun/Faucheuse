using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu]
public class CounterKill : ScriptableObject
{
    TextMeshProUGUI _tmpScore;
    private int _ghostCount;
    public int ghostCount
    {
        get { return _ghostCount; }
        set 
        {
            _ghostCount = value;
            GameObject tmpGObjectRef = GameObject.Find("Value");
            _tmpScore = tmpGObjectRef.GetComponent<TextMeshProUGUI>();

            _tmpScore.text = ghostCount.ToString();

            if(ghostCount == 3)
            {
                Time.timeScale = 0;
                GameObject.Find("MainPanel").transform.Find("Panel Reward").gameObject.SetActive(true);
                ghostCount = 0;
            }
            

        }
    }

    void OnEnable()
    {
        ghostCount = 0;
    }

    
}
