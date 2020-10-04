using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject OptionsMenu, Menu, pauseMenu;
    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Options()
    {
        OptionsMenu.SetActive(true);
        Menu.SetActive(false);
    }
    public void OptionsBack()
    {
        Menu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
    public void Exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
//Input.GetKeyDown(KeyCode.Escape)