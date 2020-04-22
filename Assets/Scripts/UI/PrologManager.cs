using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologManager : MonoBehaviour
    
{
    public GameObject prolog1;
    public GameObject prolog2;
    public GameObject prolog3;

    public void dua()
    {
        prolog2.SetActive(true);
        prolog1.SetActive(false);
        prolog3.SetActive(false);

        Debug.Log("yaaa");
    }
    public void tiga()
    {
        prolog2.SetActive(false);
        prolog1.SetActive(false);
        prolog3.SetActive(true);
        Debug.Log("yaaa");
    }
}
