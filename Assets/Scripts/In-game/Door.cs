using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //Animator yang digunakan
    private Animator _anim;
    //Animasi pintu yang digunakan
    public Animation hingehere;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.E))
        {
            hingehere.Play();
        }    
    }
}
