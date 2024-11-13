using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Player Player { get; }

    public float MovementSpeed {  get; private set; } 

    public PlayerStateMachine(Player player)
    {
        this.Player = player;

        MovementSpeed = player.Data.ExploreData.BaseSpeed;
    }
}
