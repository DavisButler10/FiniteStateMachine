using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody2D rbPlayer;
    Animator anim;
    float thrust = 70f;

    public void Enter(Player player)
    {
        rbPlayer = player.GetComponent<Rigidbody2D>();
        anim = player.GetComponent<Animator>();
        anim.SetBool("Flip", true);
        rbPlayer.AddForce(Vector2.up * thrust);
        player.mCurrentState = this;
        Debug.Log(player.mCurrentState);
    }

    public void Execute(Player player)
    {
        if (Physics2D.Raycast(rbPlayer.transform.position, Vector2.down, 0.5f))
        {
           IdlePlayerState idleState = new IdlePlayerState();
           idleState.Enter(player);
        }
        
    }
}
