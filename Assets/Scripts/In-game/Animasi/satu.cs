using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satu : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    Animator anim;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        if (ver > 0)
        {
            anim.SetBool("Running", true);
            anim.SetFloat("Speed", 1.0f);
        }
        else if (ver < 0)
        {
            anim.SetBool("Running", true);
            anim.SetFloat("Speed", -1.0f);
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
}
