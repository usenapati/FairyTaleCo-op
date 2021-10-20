using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{

    public GameObject creditsMenu;

    public void openCredits() 
    {
        creditsMenu.SetActive(true);
    }

    public void closeCredits() 
    {
        creditsMenu.SetActive(false);
    }

    public void nextScene()
    {
        //src: https://answers.unity.com/questions/1141235/how-to-move-to-next-scene-using-scene-manager.html
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
