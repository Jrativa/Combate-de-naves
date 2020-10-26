using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class BossHealth : MonoBehaviour
{
    public float BossHp= 100;
    public Image health;
    public GameObject player;
    public GameObject Boss;

    // Update is called once per frame
    
    void Update(){
        if(player.transform == Boss.transform ){BossHp -=10;}
        BossHp = Mathf.Clamp(BossHp, 0, 100);
        health.fillAmount = BossHp/100;
    }
   
}
