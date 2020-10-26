        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
    public float BulletSpeed;
    public float  spawnTime;
    public GameObject Gun;
    public GameObject bullet;
    
    private float time;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   time += Time.deltaTime;
        if(time>=spawnTime){
            GameObject bulletClone = (GameObject)Instantiate(bullet, Gun.transform, true);
            bulletClone.GetComponent<Rigidbody2D>().velocity = new Vector2(BulletSpeed, bulletClone.GetComponent<Rigidbody2D>().velocity.y);
            time=0;
        }
    }
    
}
