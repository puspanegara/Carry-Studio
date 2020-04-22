using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Options;
    public GameObject Tampilan;

    public void Level1()
    {
        SceneManager.LoadScene("Prolog1");
    }
    public void Keluar()
    {
        Application.Quit();
    }
    public void optionsOn()
    {
        Options.SetActive(true);
        Tampilan.SetActive(false);
    }
    public void optionsOff()
    {
        Options.SetActive(false);
        Tampilan.SetActive(true);
    }

}
