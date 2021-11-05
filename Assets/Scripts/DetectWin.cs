using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectWin : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Food")
        {
            if (transform.position.x > 0)
            {
                SceneManager.LoadScene("LixWinner");
            }
            else
            {
                SceneManager.LoadScene("TrixWinner");
            }
        }
    }
}
