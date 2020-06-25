using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public Animator anim;

    public void PopMisi1()
    {
        anim.SetBool("Misi1", true);
    }
}
