using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public void OnMouseDown()
    {
        if (!Puzzle.youDone)
            transform.Rotate(0f, 0f, 90f);
    }
}
