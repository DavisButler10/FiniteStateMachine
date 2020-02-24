using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSaiyanIdlePlayerState : IPlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = this;
        Debug.Log(player.mCurrentState);
    }

    public void Execute(Player player)
    {
        if (Input.GetKey(KeyCode.Z))
        {
            SuperSaiyanPlayerState ssPlayerState = new SuperSaiyanPlayerState();
            ssPlayerState.Enter(player);
        }
    }
}
