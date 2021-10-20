using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public enum ObjectiveType
    {
        Reach = 0,
        Talk = 1,
        Defeat = 2,
        Wake = 3,
        Find = 4,
        Hold = 5,
        Feed = 6,
    }

    public enum ObjectiveStatus
    {
        Pending = 0,
        Achieved = 1,
    }

    public enum ActionOnReach
    {
        MarkAsAchieved = 0,
        PlayCinematic = 1,
        PlayAnimation = 2,
        SetTrigger = 3,
    }

    public string Name;
    [Multiline(10)]
    public string Description;
    public ObjectiveType Kind;
    public ObjectiveStatus Status = ObjectiveStatus.Pending;
    public GameObject Player;
    public GameObject Target;
    public Objective NextObjective;
    public List<ActionOnReach> ActionsOnReach;
    public string TriggerName;
    public float distance;

    public Objectives ParentScript { get; set; }

    private bool isPlayerNearTarget() { return Vector3.Distance(Player.transform.position, Target.transform.position) <= distance; }

    private bool isTargetFound() { return Target.activeSelf; }

    private bool isPlayerHoldingTarget() { return Target.transform.parent == Player; }

    private bool completeObjective()
    {
        bool objectiveCondition = false;
        if (Status == ObjectiveStatus.Achieved)
        {
            return true;
        }
        else
        {
            if (Kind == ObjectiveType.Reach)
            {
                objectiveCondition = isPlayerNearTarget();
            }
            if (Kind == ObjectiveType.Find)
            {
                objectiveCondition = isTargetFound();
            }
            if (Kind == ObjectiveType.Hold)
            {
                objectiveCondition = isPlayerHoldingTarget();
            }

            if (objectiveCondition)
            {
                OnReach();
            }
        }
        return objectiveCondition;
    }

    private void OnReach()
    {
        if (this.ActionsOnReach.Contains(ActionOnReach.MarkAsAchieved))
        {
            this.Status = ObjectiveStatus.Achieved;
        }

        if (this.ActionsOnReach.Contains(ActionOnReach.PlayCinematic))
        {
            // Play Dialogue
        }
        
        if (this.ActionsOnReach.Contains(ActionOnReach.PlayAnimation))
        {
            // Plays Animation

        }
        
        if (this.ActionsOnReach.Contains(ActionOnReach.SetTrigger))
        {
            // Sets Trigger

        }

        this.Status = ObjectiveStatus.Achieved;
        ParentScript.CurrentObjective = this.NextObjective;

    }
}
