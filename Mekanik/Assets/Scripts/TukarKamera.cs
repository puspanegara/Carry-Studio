using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TukarKamera : MonoBehaviour
{

    public Camera cam1, cam2;

    private bool HorizontalSplit;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HorizontalSplit = !HorizontalSplit;
            SetSplit();
        }
    }

    public void SetSplit()
    {
        if (HorizontalSplit)
        {
            cam1.rect = new Rect(0f, .5f, 1f, .5f);
            cam2.rect = new Rect(0f, 0f, 1f, .5f);
        }
        else
        {
            cam1.rect = new Rect(0f, 0f, .5f, 1f);
            cam2.rect = new Rect(.5f, 0f, .5f, 1f);
        }
    }
}
