using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //Beferences
    Animator am;
    PlayerMovement pm;
    SpriteRenderer sr;
    
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDir.x != 0)
        {
            am.SetBool("Move", true);

            SpriteDirectionChecker();
        }
        else
        {
            am.SetBool("Move", false);
        }
        
        if (pm.moveDir.y > 0)
        {
            am.SetBool("MoveUp", true);
        }
        else
        {
            am.SetBool("MoveUp", false);
        }

        if(pm.moveDir.y < 0)
        {
            am.SetBool("MoveDown", true);
        }
        else
        {
            am.SetBool("MoveDown", false);
        }
    }

    void SpriteDirectionChecker()
    {
        if (pm.lastHorizontalVector < 0)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }
    }
}
