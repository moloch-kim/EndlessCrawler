using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerExploreData
{
    [field: SerializeField][field:Range(0f,25f)]public float BaseSpeed {  get; set; } = 5f;

    [field: Header("IdleData")]

    [field: Header("WalkData")]
    [SerializeField][field: Range(0f, 25f)] public float WalkSpeedModifier { get; private set; } = 0.225f;

    [field : Header("RunData")]
    [field: SerializeField][field: Range(0f, 25f)] public float RunSpeedModifier { get; private set; } = 1f;
}

[Serializable]
public class PlayerCombatData
{

}

[CreateAssetMenu(fileName = "Player", menuName = "Chracters/Player")]
public class PlayerSO : ScriptableObject 
{
    [field:SerializeField] public PlayerExploreData ExploreData { get; private set;}
    [field:SerializeField] public PlayerCombatData CombatData { get; private set;}
}
