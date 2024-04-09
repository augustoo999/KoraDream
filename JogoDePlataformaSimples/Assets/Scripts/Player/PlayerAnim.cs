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

    private void Update()
    {
        OnMove();
    }

    void OnMove()
    {
        if (player.direction > 0) 
        {
            anim.SetInteger("Transition", 1);
            transform.eulerAngles = new Vector2(0, 0);
        }
        else if (player.direction < 0)
        {
            anim.SetInteger("Transition", 1);
            transform.eulerAngles = new Vector2(0, 180);
        }
        else
        {
            anim.SetInteger("Transition", 0);
        }

        if (player.IsJumping)
        {
            anim.SetInteger("Transition", 2);
        }
    }
}
