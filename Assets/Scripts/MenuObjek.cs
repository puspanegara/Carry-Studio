using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuObjek : MonoBehaviour
{
    public bool Keluar = false;
    public bool Options = false;
    Renderer renderer;

    void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }
}
