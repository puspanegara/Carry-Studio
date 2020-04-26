using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    //Menentukan Pintu yang akan digunakan
    public Component doorColliderHere;
    //Menentukan kunci mana yang akan dihilangkan
    public GameObject keyGone;
    void OnTriggerStay(Collider other)
    {
        //Mendeteksi keberadaan kunci menggunakan Collider
        //Menganmbilnya dengan tombol 'E'
        if(Input.GetKey(KeyCode.E))
        {
            doorColliderHere.GetComponent<BoxCollider>().enabled = true;
            keyGone.SetActive(false);

        }   
    }
}
