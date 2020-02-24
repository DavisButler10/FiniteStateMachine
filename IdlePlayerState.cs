using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdlePlayerState : IPlayerState
{
    Animator anim;
    
    public void Enter(Player player)
    {
        player.mCurrentState = this;
        anim = player.GetComponent<Animator>();
        anim.SetBool("Idle", true);
        Debug.Log(player.mCurrentState);
    }

    public void Execute(Player player)
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            JumpingPlayerState jumpingState = new JumpingPlayerState();
            jumpingState.Enter(player);
        }

        if (Input.GetKey(KeyCode.D))
        {
            KickingPlayerState kickingState = new KickingPlayerState();
            kickingState.Enter(player);
        }

        if (Input.GetKey(KeyCode.E))
        {
            PunchingPlayerState punchingState = new PunchingPlayerState();
            punchingState.Enter(player);
        }

        if (Input.GetKey(KeyCode.C))
        {
            FallingPlayerState fallingState = new FallingPlayerState();
            fallingState.Enter(player);
        }

    }
}
