using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use : MonoBehaviour
{
    private bool use = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            use = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            use = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && use)
        {
            // действие
            Destroy(gameObject);
        }
    }
}
