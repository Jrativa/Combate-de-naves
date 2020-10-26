using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoss : MonoBehaviour
{
    public Transform Player_pos;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Player_pos = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player_pos.position.y > this.transform.position.y)
            transform.Translate (Vector3.up * Speed * Time.deltaTime);
        if (Player_pos.position.y < this.transform.position.y)
            transform.Translate (-Vector3.up * Speed * Time.deltaTime);
    }
}
