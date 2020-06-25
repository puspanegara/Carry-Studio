using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject Pause;
    public void Unpause()
    {
        Pause.SetActive(false);
    }
    public void BalikMainMenu()
    {
        SceneManager.LoadScene("MainMenu1");
    }
}
