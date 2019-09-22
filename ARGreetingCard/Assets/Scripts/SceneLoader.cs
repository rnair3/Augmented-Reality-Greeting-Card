using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void Quit()
    {
        Application.Quit();
    }

    public void GreetingCard()
    {
        SceneManager.LoadScene("GreetingCard");
    }

    public void RotateCube()
    {
        SceneManager.LoadScene("Rotate Cube");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
