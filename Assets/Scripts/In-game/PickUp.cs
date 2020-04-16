using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{

  public GameObject MessagePanel;
  public float radius= 3f;

  private void Start()
  {
     
  }
   public void OpenMessagePanel()
  {
      MessagePanel.SetActive(true);
  }

  public void CloseMessagePanel()
  {
      //Menutup pesan Jika menjauh dari benda
      MessagePanel.SetActive(false);
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
        OpenMessagePanel();
    }
    Debug.Log("Collactable Item");
  }
  
  /*private void OnTriggerExit(Collider other) {
      //Jika pemain sudah menjauh 
      //Maka pesan akan tertutup secara otomatis
   Inventory item= other.GetComponent<Inventory>();
   if(item != null)
   {
       CloseMessagePanel();
   }  
  }
  */

  //Collision untuk Camera agar tidak nembus ke tembok

  
}
