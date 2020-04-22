using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundController : MonoBehaviour
{
    public AudioSource audioku;
    
    public void Suarahidup()
    {
        audioku.Play();
    }
    public void SuaraMati()
    {
        audioku.Stop();
    }
}
