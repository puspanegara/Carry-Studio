using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNote : MonoBehaviour
{
    public AudioSource noteC;
    public AudioSource noteD;
    public AudioSource noteE;
    public AudioSource noteF;
    public AudioSource noteG;
    public AudioSource noteA;
    public AudioSource noteB;
    public AudioSource noteC1;

    public void CPlay()
    {
        noteC.Play();
    }
    public void DPlay()
    {
        noteD.Play();
    }
    public void EPlay()
    {
        noteE.Play();
    }
    public void FPlay()
    {
        noteF.Play();
    }
    public void GPlay()
    {
        noteG.Play();
    }
    public void APlay()
    {
        noteA.Play();
    }
    public void BPlay()
    {
        noteB.Play();
    }
    public void C1Play()
    {
        noteC1.Play();
    }
}
