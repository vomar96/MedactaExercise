using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // load main menu
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }    
    
    // load main scene
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }    
    
    // load spring scene
    public void LoadSpringScene()
    {
        SceneManager.LoadScene("SpringScene");
    }

    // quit the application
    public void QuitGame()
    {
        print("Quit Game Button");
        Application.Quit();
    }
}
