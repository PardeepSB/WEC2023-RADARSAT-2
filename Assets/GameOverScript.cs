using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject LionelTheSeaLion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)// on collision load the gameover menu 
    {
            SceneManager.LoadScene("Game Over");//Boots into Game over scene.
    }

}
