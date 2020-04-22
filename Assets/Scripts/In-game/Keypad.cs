using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    //Kode yang akan digunakan
    public string curPassword = "123";
    //Angka yang di masuka pada keypad 
    public string input;
    //Mentrigger keypad untuk muncul dengan menekan tombol
    public bool onTrigger;
    //Mengaktifkan pintu terbuka atau tertutup
    public bool doorOpen;
    //Mengaktifkan keypad
    public bool keypadScreen;
    public Transform doorHinge;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;    
    }
    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;  
        input = "";  
    }

    void Update()
    {
        //Membuat sistem pintu terbuka
        //Jika angka yang dimasukkan sama dengan yang diminta
        if(input == curPassword)
        {
            doorOpen = true;
        }

        //Membuat animasi atau gerakan pintu terbuka
        //Dengan merotasinya
        if(doorOpen)
        {
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
        }
    }
    void OnGUI()
    {
        if(!doorOpen)
        {
            if(onTrigger)
            {
                //Jika keypad sudah di trigger
                //Maka akan diminta untuk menekan tombol
                //Tombol 'E' akan membuka keypad
                GUI.Box(new Rect(0, 0, 200, 25),"Pres Button to open Keypad");
                if (Input.GetKey(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                }
            }

        //Membuat keypad screen dengan GUI
        if (keypadScreen)
        {
            
            GUI.Box(new Rect(0, 0, 320, 455), "");
            GUI.Box(new Rect(5, 5, 310, 25), input);

            if(GUI.Button(new Rect(5, 35, 100, 100),"1"))
            {
                input = input + "1";
            }
            if(GUI.Button(new Rect(110, 35, 100, 100),"2"))
            {
                input = input + "2";
            }
            if(GUI.Button(new Rect(215, 35, 100, 100),"3"))
            {
                input = input + "3";
            }
            if(GUI.Button(new Rect(5, 140, 100, 100),"4"))
            {
                input = input + "4";
            }
            if(GUI.Button(new Rect(110, 140, 100, 100),"5"))
            {
                input = input + "5";
            }
            if(GUI.Button(new Rect(215, 140, 100, 100),"6"))
            {
                input = input + "6";
            }
            if(GUI.Button(new Rect(5, 245, 100, 100),"7"))
            {
                input = input + "7";
            }
            if(GUI.Button(new Rect(110, 245, 100, 100),"8"))
            {
                input = input + "8";
            }
            if(GUI.Button(new Rect(215, 245, 100, 100),"9"))
            {
                input = input + "9";
            }
            if(GUI.Button(new Rect(110, 350, 100, 100),"0"))
            {
                input = input + "0";
            }
        }
        }
    }
}
