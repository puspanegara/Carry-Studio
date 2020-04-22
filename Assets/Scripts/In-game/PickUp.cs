using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{

  public GameObject MessagePanel1;
  public GameObject MessagePanel2;
  public float radius= 3f;
  public string tagObject;

  private void Start()
  {
     
  }
   public void OpenMessagePanel1()
  {
      MessagePanel1.SetActive(true);
  }
  public void OpenMessagePanel2()
  {
      MessagePanel2.SetActive(true);
  }
  public void CloseMessagePanel1()
  {
      //Menutup pesan Jika menjauh dari benda
      MessagePanel1.SetActive(false);
  }
  public void CloseMessagePanel2()
  {
      //Menutup pesan Jika menjauh dari benda
      MessagePanel2.SetActive(false);
  }

  

    void OnDrawGizmosSelected() {
    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(transform.position, radius);   
  }

  private void OnTriggerEnter(Collider other) {
     /*
      if (other.CompareTag("Player"))
      {
          for(int i = 0; i < inventory.slots.Length; i++;)
          {
              if (inventory.isFull[i] == false)
              {
                  inventory.isFull = true;
                  Instantiate(itemBu)
              }
          }
      } 
      */

      //Jika benda dekat dengan player 
      //Maka pesan akan terlihat
    if(other.CompareTag("Player"))
    {
        OpenMessagePanel1();
        Debug.Log("Collactable Item");
    }
    if(other.CompareTag("Player2"))
    {
        OpenMessagePanel2();
        Debug.Log("Collactable Item");
    }
    
  }
  
  private void OnTriggerExit(Collider other) {
      //Jika pemain sudah menjauh 
      //Maka pesan akan tertutup secara otomatis
   //Inventory item= other.GetComponent<Inventory>();
   /*if(item != null)
   {
       CloseMessagePanel();
   } */
   CloseMessagePanel1();
   CloseMessagePanel2(); 
  }
  

  //Collision untuk Camera agar tidak nembus ke tembok

  
}
