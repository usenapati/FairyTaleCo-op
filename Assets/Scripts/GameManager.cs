using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isLevelComplete; // Win Condition

    public Objectives player1Objectives;
    public Objectives player2Objectives;
    public int Level;
    public GameObject Player1;
    public GameObject Player2;

    private void Start()
    {

    }

    public void CompleteLevel ()
    {
        Debug.Log("LEVEL COMPLETE");
    }

}
