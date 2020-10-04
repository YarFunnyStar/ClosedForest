using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float shift, cof;
    public GameObject body;
    private Animator anim;

    void Start()
    {
        anim = body.GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (x > 0)
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }
        else if (x < 0)
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        if (x == 0)
        {
            anim.Play("Idle");
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * cof * shift, 0);
            anim.Play("speedforward");
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * cof, 0);
            anim.Play("Forward");
        }
    }
}