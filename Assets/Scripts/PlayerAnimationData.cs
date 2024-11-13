using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerAnimationData
{
    [SerializeField] private string exploreParameterName = "@Explore";
    [SerializeField] private string exploreIdleParameterName = "ExploreIdle";
    [SerializeField] private string walkParameterName = "Walk";
    [SerializeField] private string runParameterName = "Run";

    [SerializeField] private string combatParameterName = "@Combat";
    [SerializeField] private string combatIdleParameterName = "CombatIdle";

    [SerializeField] private string attackParameterName = "@Attack";
    [SerializeField] private string comboParameterName = "ComboAttack";

    public int ExploreParameterHash { get; private set; }
    public int CombatParameterHash { get; private set; }

    public void Initialize()
    {
        ExploreParameterHash = Animator.StringToHash(exploreParameterName);
        CombatParameterHash = Animator.StringToHash(combatParameterName);
    }
}


