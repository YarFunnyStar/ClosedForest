using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenu, Menu;
    public void NewGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void Options()
    {
        OptionsMenu.SetActive(true);
        Menu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
