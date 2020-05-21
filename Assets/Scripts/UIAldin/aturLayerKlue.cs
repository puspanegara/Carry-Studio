using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aturLayerKlue : MonoBehaviour
{
    public GameObject layar1;
    public GameObject layar2;
    public GameObject layar3;
    public GameObject layar4;
    public GameObject layar5;
    public GameObject layar6;
    public GameObject layar7;
    public GameObject layar8;
    public GameObject layar9;

    public void OnLayar1()
    {
        layar1.SetActive(true);
        layar2.SetActive(false);
    }

    public void OnLayar2()
    {
        layar1.SetActive(false);
        layar2.SetActive(true);
    }
    public void OnLayar3()
    {
        layar2.SetActive(false);
        layar3.SetActive(true);
    }
    public void OnLayar4()
    {
        layar3.SetActive(false);
        layar4.SetActive(true);
    }
    public void OnLayar5()
    {
        layar4.SetActive(false);
        layar5.SetActive(true);
    }
    public void OnLayar6()
    {
        layar5.SetActive(false);
        layar6.SetActive(true);
    }
    public void OnLayar7()
    {
        layar6.SetActive(false);
        layar7.SetActive(true);
    }
    public void OnLayar8()
    {
        layar7.SetActive(false);
        layar8.SetActive(true);
    }
    public void OnLayar9()
    {
        layar8.SetActive(false);
        layar9.SetActive(true);
    }

    public void OffLayar3()
    {
        layar3.SetActive(false);
        layar2.SetActive(true);
    }
    public void OffLayar4()
    {
        layar4.SetActive(false);
        layar3.SetActive(true);
    }
    public void OffLayar5()
    {
        layar5.SetActive(false);
        layar4.SetActive(true);
    }
    public void OffLayar6()
    {
        layar6.SetActive(false);
        layar5.SetActive(true);
    }
    public void OffLayar7()
    {
        layar7.SetActive(false);
        layar6.SetActive(true);
    }
    public void OffLayar8()
    {
        layar8.SetActive(false);
        layar7.SetActive(true);
    }
    public void OffLayar9()
    {
        layar9.SetActive(false);
        layar8.SetActive(true);
    }
    public void TutupBuku()
    {
        layar9.SetActive(false);
    }
}
