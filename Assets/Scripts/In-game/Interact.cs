using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
   public Transform theDest;

   void OnInteract()
   {
       GetComponent<Rigidbody>().useGravity = false;
       this.transform.position = theDest.position;
       this.transform.parent = GameObject.Find("Destination").transform;
   }

}
