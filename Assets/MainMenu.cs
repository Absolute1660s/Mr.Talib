using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void SinglePlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MultiPlayer()
    {

    }

    public void Settings()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }




}