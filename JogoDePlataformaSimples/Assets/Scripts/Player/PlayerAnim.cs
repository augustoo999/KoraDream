using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private MovimentoPlayer player;
    private Animator anim;


    private void Start()
    {
        player = GetComponent<MovimentoPlayer>();
        anim = GetComponent<Animator>();
    }

    void OnMove()
    {
        if (player.direction > 0) 
        {
            anim.SetInteger("Transition", 1);
        }
    }
}
