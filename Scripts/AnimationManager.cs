using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator goku;
    public Animator vegeta;

    public void FlipOff()
    {
        goku.SetBool("Flip", false);
    }
    public void SuperSaiyanOff()
    {
        goku.SetBool("SuperSaiyan", false);
    }
    public void KickOff()
    {
        goku.SetBool("Kick", false);
    }
    public void PunchOff()
    {
        goku.SetBool("Punch", false);
    }
    public void FallOff()
    {
        goku.SetBool("Fall", false);
    }
    public void BlastOff()
    {
        vegeta.SetBool("Blast", false);
    }
    public void GokuFall()
    {
        goku.SetBool("Fall", true);
        GameObject.FindGameObjectWithTag("Blast").GetComponent<SpriteRenderer>().enabled = true;
    }

    public void BlastSpriteOff()
    {
        GameObject.FindGameObjectWithTag("Blast").GetComponent<SpriteRenderer>().enabled = false;
    }
}
