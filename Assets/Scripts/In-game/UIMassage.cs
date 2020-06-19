using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMassage : MonoBehaviour
{
    public GameObject popInfo;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                popInfo.SetActive(true);
            }
            else if (Input.GetKey(KeyCode.R))
            {
                popInfo.SetActive(false);
            }
        }
    }
}
