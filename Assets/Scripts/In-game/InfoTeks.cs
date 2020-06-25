using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoTeks : MonoBehaviour
{
    public GameObject infoPopup;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player1" && collision.gameObject.tag =="Player2")
        {
            infoPopup.SetActive(true);
        }
    }
}
