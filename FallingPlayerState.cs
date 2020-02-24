using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlayerState : IPlayerState
{
    Animator anim;

    public void Enter(Player player)
    {
        player.mCurrentState = this;
        anim = player.GetComponent<Animator>();
        GameObject.FindGameObjectWithTag("Vegeta").GetComponent<Animator>().SetBool("Blast", true);
        //GameObject.FindGameObjectWithTag("Blast").GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log(player.mCurrentState);
    }

    public void Execute(Player player)
    {
            IdlePlayerState idleState = new IdlePlayerState();
            idleState.Enter(player);
        
    }
}
