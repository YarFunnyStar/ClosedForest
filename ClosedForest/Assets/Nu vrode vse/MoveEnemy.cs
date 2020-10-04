using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public Chiza chiza;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (chiza.ShizaP >= 12)
        {
            rb.velocity = new Vector2(2.0f, 0.0f);
        }else
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
        
    }
}
