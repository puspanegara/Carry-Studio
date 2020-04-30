using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologManager : MonoBehaviour
    
{
    public GameObject Textsatu;
    public GameObject Textdua;
    public GameObject Texttiga;
    public GameObject prolog1;
    public GameObject prolog2;
    public GameObject prolog3;

    void Start()
    {
       
    }

    public void dua()
    {
        if (Textsatu != null)
        {
            prolog2.SetActive(true);
            prolog1.SetActive(false);
            prolog3.SetActive(false);

            Debug.Log("yaaa");
        }
    }
    public void tiga()
    {
        prolog2.SetActive(false);
        prolog1.SetActive(false);
        prolog3.SetActive(true);
        Debug.Log("yaaa");
    }
}
