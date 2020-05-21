using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject Pause;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause.SetActive(true);
        }
    }
    public void Unpause()
    {
        Pause.SetActive(false);
    }
    public void BalikMainMenu()
    {
        SceneManager.LoadScene("MainMenu1");
    }
}
