using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    //code for chosing the next scene i.e. play game
    public void PlayGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    //code for quitting game
    public void QuitGame()
    {
        Application.Quit();
    }

}
