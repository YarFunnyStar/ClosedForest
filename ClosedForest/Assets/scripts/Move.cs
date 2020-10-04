using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float cof;
    [SerializeField] private float shift;

    void Start()
    {

    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * cof * shift, 0);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * cof, 0);
        }
    }
}