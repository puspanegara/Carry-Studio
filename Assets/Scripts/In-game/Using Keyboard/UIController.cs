using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject interactText;
    public GameObject collectText;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Interact")
        {
            interactText.SetActive(true);
            Debug.Log("Interact");
        }
        else if (collision.gameObject.tag == "item")
        {
            collectText.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        interactText.SetActive(false);
        collectText.SetActive(false);
    }
}
