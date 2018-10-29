using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void ResetLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadHowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void LoadOptions(){
        SceneManager.LoadScene("Options");
    }
    public void LoadStartScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
