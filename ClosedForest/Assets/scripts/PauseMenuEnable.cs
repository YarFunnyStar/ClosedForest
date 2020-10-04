using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuEnable : MonoBehaviour
{
    public GameObject pauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }
}
