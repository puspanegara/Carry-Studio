using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    public void Prolog()
    {
        SceneManager.LoadScene(2);
        Debug.Log("ini working lo");
    }
    public void Keluar()
    {
        Application.Quit();
    }
}
