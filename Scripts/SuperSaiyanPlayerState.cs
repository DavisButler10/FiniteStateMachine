using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperSaiyanPlayerState : IPlayerState
{
    Animator anim;
    public Text textSS;

    public void Enter(Player player)
    {
        player.mCurrentState = this;
        anim = player.GetComponent<Animator>();
        anim.SetBool("SuperSaiyan", true);
        textSS = GameObject.Find("SuperSaiyanText").GetComponent<Text>();
        Debug.Log(player.mCurrentState);
    }

    public void Execute(Player player)
    {
        textSS.enabled = false;
        IdlePlayerState idleState = new IdlePlayerState();
        idleState.Enter(player);
    }
}
