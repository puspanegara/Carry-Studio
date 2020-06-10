using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class Puzzle : MonoBehaviour
{
    private void OnMouseDown()
    {
        if(!GameController.youDone)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
