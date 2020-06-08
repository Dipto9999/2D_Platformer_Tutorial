using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Required for Changing Scenes
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // PlayButton Functionality
    // Must be Public so can be called from pressing PlayButton
    public void PlayGame ()
    {
        // Load Next Scene in Queue.
        // In this case, this is the actual Game.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // QuitButton Functionality
    // Must be Public so can be called from pressing QuitButton
    public void QuitGame(){

        // For Functionality in Unity Editor
        Debug.Log("Quit Game.");
        // End Gameplay
        Application.Quit();
    }
}
