using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isLevelComplete; // Win Condition

    public Objectives player1Objectives;
    public Objectives player2Objectives;

    public void CompleteLevel ()
    {
        Debug.Log("LEVEL COMPLETE");
    }

    // Level 1: Feed the Cat
    void Level1 ()
    {
        // Find Cat Food
        Objective foundPlayer1CatFood = new Objective(); // 1A
        Objective foundPlayer2CatFood = new Objective(); // 2A

        // Find Cat Bowl
        Objective foundPlayer1CatBowl = new Objective(); // 1B
        Objective foundPlayer2CatBowl = new Objective(); // 2B

        // Pour Food into Bowl
        Objective filledPlayer1CatBowl = new Objective(); // 1C
        Objective filledPlayer2CatBowl = new Objective(); // 2C

        // Wake the Cat
        Objective wakePlayer1Cat = new Objective(); // 1D
        Objective wakePlayer2Cat = new Objective(); // 2D

        Objective fedPlayer1Cat = new Objective(); // 1E
        Objective fedPlayer2Cat = new Objective(); // 2E

        // 1A
        foundPlayer1CatFood.Name = "Find the Cat Food";
        foundPlayer1CatFood.Kind = Objective.ObjectiveType.Find;
        foundPlayer1CatFood.Player = player1Objectives.Player;
        // Add Target in Editor
        foundPlayer1CatFood.NextObjective = foundPlayer1CatBowl;
        foundPlayer1CatFood.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 1B
        foundPlayer1CatBowl.Name = "Find the Cat Bowl";
        foundPlayer1CatBowl.Kind = Objective.ObjectiveType.Hold;
        foundPlayer1CatBowl.Player = player1Objectives.Player;
        // Add Target in Editor
        foundPlayer1CatBowl.NextObjective = filledPlayer1CatBowl;
        foundPlayer1CatBowl.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 1C
        filledPlayer1CatBowl.Name = "Pour Food into Bowl";
        filledPlayer1CatBowl.Kind = Objective.ObjectiveType.Hold;
        filledPlayer1CatBowl.Player = player1Objectives.Player;
        // Add Target in Editor
        filledPlayer1CatBowl.NextObjective = wakePlayer1Cat;
        filledPlayer1CatBowl.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 1D
        wakePlayer1Cat.Name = "Wake the Cat";
        wakePlayer1Cat.Kind = Objective.ObjectiveType.Wake;
        wakePlayer1Cat.Player = player1Objectives.Player;
        // Add Target in Editor
        wakePlayer1Cat.NextObjective = fedPlayer1Cat;
        wakePlayer1Cat.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 1E
        fedPlayer1Cat.Name = "Feed the Cat";
        fedPlayer1Cat.Kind = Objective.ObjectiveType.Wake;
        fedPlayer1Cat.Player = player1Objectives.Player;
        // Add Target in Editor
        fedPlayer1Cat.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 2A
        foundPlayer2CatFood.Name = "Find the Cat Food";
        foundPlayer2CatFood.Kind = Objective.ObjectiveType.Find;
        foundPlayer2CatFood.Player = player1Objectives.Player;
        // Add Target in Editor
        foundPlayer2CatFood.NextObjective = foundPlayer2CatBowl;
        foundPlayer2CatFood.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 2B
        foundPlayer2CatFood.Name = "Find the Cat Bowl";
        foundPlayer2CatFood.Kind = Objective.ObjectiveType.Hold;
        foundPlayer2CatFood.Player = player1Objectives.Player;
        // Add Target in Editor
        foundPlayer2CatFood.NextObjective = filledPlayer2CatBowl;
        foundPlayer2CatFood.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 2C
        foundPlayer2CatFood.Name = "Pour Food into Bowl";
        foundPlayer2CatFood.Kind = Objective.ObjectiveType.Hold;
        foundPlayer2CatFood.Player = player1Objectives.Player;
        // Add Target in Editor
        foundPlayer2CatFood.NextObjective = filledPlayer2CatBowl;
        foundPlayer2CatFood.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 2D
        foundPlayer2CatFood.Name = "Wake the Cat";
        foundPlayer2CatFood.Kind = Objective.ObjectiveType.Hold;
        foundPlayer2CatFood.Player = player1Objectives.Player;
        // Add Target in Editor
        foundPlayer2CatFood.NextObjective = filledPlayer2CatBowl;
        foundPlayer2CatFood.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);

        // 2E
        foundPlayer2CatFood.Name = "Feed the Cat";
        foundPlayer2CatFood.Kind = Objective.ObjectiveType.Hold;
        foundPlayer2CatFood.Player = player1Objectives.Player;
        // Add Target in Editor
        foundPlayer2CatFood.NextObjective = filledPlayer2CatBowl;
        foundPlayer2CatFood.ActionsOnReach.Add(Objective.ActionOnReach.MarkAsAchieved);
    }

}
