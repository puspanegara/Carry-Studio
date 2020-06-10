using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekanAnimasi : MonoBehaviour
{
    public Animator anim;
    
    public void tekanJalan()
    {
        anim.SetBool("Running", true);
    }

    public void tekanIdle()
    {
        anim.SetBool("Running", false);
    }
    public void tekanDorong()
    {
        anim.SetBool("Push", true);
    }
}
