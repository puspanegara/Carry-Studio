using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    //inisilisasi panel info Player1
    public GameObject MessagePanel1;
    //inisialisasi panel info Player2
    public GameObject MessagePanel2;
    public float radius= 3f;
    public string tagObject;
    private Inventory inventory;
    public GameObject itemButton;

    private void Start() 
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();    
    }

    //untuk membuka panel info Player1
    public void OpenMessagePanel1()
    {
        MessagePanel1.SetActive(true);
    }
    //untuk membuka panel info Player2
    public void OpenMessagePanel2()
    {
        MessagePanel2.SetActive(true);
    }
    //Menutup panel info Player1
    public void CloseMessagePanel1()
    {
        //Menutup pesan Jika menjauh dari benda
        MessagePanel1.SetActive(false);
    }
    //Menutup panel info Player2
    public void CloseMessagePanel2()
    {
        //Menutup pesan Jika menjauh dari benda
        MessagePanel2.SetActive(false);
    }
    /*private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        } 

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
    } */
    private void OnTriggerStay(Collider other) 
    {
        //if (other.CompareTag("Player"))
        //akan terambil bila sudah di tekan E
        if(Input.GetKey(KeyCode.E))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        } 

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
    
    private void OnTriggerExit(Collider other) 
    {
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
}
