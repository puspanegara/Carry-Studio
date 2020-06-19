using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PapanTulis : MonoBehaviour
{
    public GameObject papanBuka;
  
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            if(Input.GetKey(KeyCode.E))
            {
                papanBuka.SetActive(true);
                Debug.Log("Buka Cataan");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        papanBuka.SetActive(false);
    }
}
