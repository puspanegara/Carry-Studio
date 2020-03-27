using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMove : MonoBehaviour
{
    [Header("Controls")]
    CharacterMove controls;
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpPower;
    public  float gravity;

    [Header("Input Move")]
    public string horizontalMove;
    public string verticalMove;
    public string jumpMove;


    private Vector3 moveDirection =  Vector3.zero;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
     CharacterController controller = GetComponent<CharacterController>();

     if(controller.isGrounded) //Mengecek keberadaan diatas tanah
     {
         //input contoller pemain
        moveDirection= new  Vector3 (0, 0, Input.GetAxis(verticalMove));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        if(Input.GetButton(jumpMove))
        moveDirection.y = jumpPower;


     }

        moveDirection.y -= gravity *Time.deltaTime;
        controller.Move(moveDirection*Time.deltaTime); 
        Debug.Log("Jalan lah cuy");

        //pemain berputar
        transform.Rotate(0, Input.GetAxis(horizontalMove), 0);  
     
    }
}

