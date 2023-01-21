using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{

    public static bool isPaused=false;
    public GameObject PauseOverlay;
    // Start is called before the first frame update
    void Start()
    {
       PauseOverlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //PauseOverlay.SetActive(false);//Overlay is off when just playing the game
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused=false)
            {
                PauseOverlay.SetActive(false);//overlay does not appear 
                resumeGame();
            }
            else
            {
                PauseOverlay.SetActive(true);//overlay does appear since boolean is true 
                pauseGame();
            }
        }
        
    }

    public void resumeGame()
    {
        PauseOverlay.SetActive(false);//overlay does not appear 
        isPaused=false;//pause boolean is false so nothing occures
        Time.timeScale=1f;//time is set to 1x speed which allows player to play game at normal pace.
    }

    public void pauseGame()
    {
         PauseOverlay.SetActive(true);//overlay does appear since boolean is true 
         isPaused=true;//pause boolean is true so game is paused.
         Time.timeScale=0f;//time is set to 0x speed which allows game to pause.
    }

    public void QuitGame()
    {
        Application.Quit();//Quit
    }
}
