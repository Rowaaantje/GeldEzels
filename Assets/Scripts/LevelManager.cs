using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Load previous scene
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void backToMenuNav()
    {
        SceneManager.LoadScene(0);
    }
    //keuzes
    public void Keuze1()
    {
        SceneManager.LoadScene(19);
    }
    public void Keuze2()
    {
        SceneManager.LoadScene(20);
    }
    public void loadsceene21()
    {
        SceneManager.LoadScene(21);
    }
     public void LoadScene19()
    {
        SceneManager.LoadScene(19);
    }
}
