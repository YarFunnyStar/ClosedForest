using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chiza : MonoBehaviour
{
    public Transform Player;
    public GameObject _Player;
    public float ShizaP;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (ShizaP >= 10)
        {
            rb.velocity = new Vector2(2.0f, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        ShizaP = Mathf.Sqrt(Mathf.Pow(transform.position.x - Player.transform.position.x, 2) + Mathf.Pow(transform.position.y - Player.transform.position.y, 2));
        if (ShizaP <= 1)
        {
            Destroy(_Player);
        }
        Debug.Log(ShizaP);



    }
}
