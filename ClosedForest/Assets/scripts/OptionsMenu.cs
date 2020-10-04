using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Menu, Options;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {
        Menu.SetActive(true);
        Options.SetActive(false);
    }
}
