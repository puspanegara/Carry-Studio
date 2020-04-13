using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
  private Inventory inventory;
  
  public GameObject MessagePanel;

  private void Start()
  {
      inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
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
  
  private void OnTriggerExit(Collider other) {
      //Jika pemain sudah menjauh 
      //Maka pesan akan tertutup secara otomatis
   Inventory item= other.GetComponent<Inventory>();
   if(item != null)
   {
       CloseMessagePanel();
   }  
  }
}
