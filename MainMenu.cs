using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Code for transitioning scenes and Exiting games*/

public class MainMenu : MonoBehaviour
{

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void ExitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();   
    }
}
