using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
   public Transform theDest;

   void OnButtonInteractDown()
   {
       GetComponent<Rigidbody>().useGravity = false;
       this.transform.position = theDest.position;
       this.transform.parent = GameObject.Find("Destination").transform;
   }

   void OnButtonInteractUp()
   {
       this.transform.parent = null;
       GetComponent<Rigidbody>().useGravity = true;
   }
}
