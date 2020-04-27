using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingPlayerState : IPlayerState
{
    Animator anim;

    public void Enter(Player player)
    {
        player.mCurrentState = this;
        anim = player.GetComponent<Animator>();
        anim.SetBool("Punch", true);
        Debug.Log(player.mCurrentState);
    }

    public void Execute(Player player)
    {
        IdlePlayerState idleState = new IdlePlayerState();
        idleState.Enter(player);
    }
}