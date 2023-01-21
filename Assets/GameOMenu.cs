using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu"); //loads scene Main Game
    }

    //code for quitting game
    public void QuitGame()
    {
        Application.Quit();// Quits the application.
    }
}
