using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject
{
    public Sprite characterImage;

    public AudioClip speakingSound;

    public string characterName;
}
