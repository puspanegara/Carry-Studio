using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klueBuku : MonoBehaviour
{
    public AudioSource soundbuku;
    public GameObject klue;
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            soundbuku.Play();
            klue.SetActive(true);
        }
    }
}
