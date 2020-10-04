using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerEnemy : MonoBehaviour
{
    public Transform enemy;
    private bool check= false;
    void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && check == false)
        {
            check = true;
            enemy.transform.position = new Vector2(-8, 0.5f);
        }
    }

    void Update()
    {
       
    }
}
