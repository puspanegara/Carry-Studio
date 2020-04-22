using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuObjek : MonoBehaviour
{
    public bool Keluar = false;
    public bool Options = false;

    public GameObject optionMenu, mainMenu;
    public GameObject buttonBackMenu,buttonSetting, buttonNewGame;
    Renderer renderer;

     void Update() {
         if(Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Select"))
         {
             MaintoMenu();
         }
    }
    public void MaintoMenu()
    {
        if (!mainMenu.activeInHierarchy)
        {
            mainMenu.SetActive(true);
            Time.timeScale = 0f;

            EventSystem.current.SetSelectedGameObject(null);

            EventSystem.current.SetSelectedGameObject(buttonNewGame);
        }
        else
        {
            mainMenu.SetActive(false);
            Time.timeScale = 1f;
            optionMenu.SetActive(true);
        }
    } 

    public void OpenOption()
    {
        optionMenu.SetActive(true);
    }
    public void CloseOption()
    {
        optionMenu.SetActive(false);
    }
    /*
    void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }
    */
}
