using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klueBuku : MonoBehaviour
{
    public GameObject klue;
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            klue.SetActive(true);
        }
    }
}
