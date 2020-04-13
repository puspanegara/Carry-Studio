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
    //public float jumpPower;
    public  float gravity;
    public float addForcePower;

    [Header("Input Move")]
    public string horizontalMove;
    public string verticalMove;
    //public string jumpMove;
    public string actMode;


    private Vector3 moveDirection =  Vector3.zero;
    public Rigidbody rb;

    
    
    
    // Start is called before the first frame update
    void Start() {
    
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
     CharacterController controller = GetComponent<CharacterController>();
            //Mengecek keberadaan diatas tanah
            if(controller.isGrounded) 
            {
                //input contoller pemain
                moveDirection= new  Vector3 (0, 0, Input.GetAxis(verticalMove)); //Berjalan Maju
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= moveSpeed;
            /*
                if(Input.GetButton(jumpMove))
                moveDirection.y = jumpPower;
            */
            }
        moveDirection.y -= gravity *Time.deltaTime;
        controller.Move(moveDirection*Time.deltaTime); 

        //pemain berputar
        //Berputar kekanan kiri untuk melihat sekeliling
        transform.Rotate(0, Input.GetAxis(horizontalMove), 0);  
    }

     void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody rigid= hit.collider.attachedRigidbody;
        if(rigid != null &&  rigid.isKinematic == false)
        {
            Vector3 pushDirection = new Vector3 (hit.moveDirection.x,0, hit.moveDirection.z);
            rigid.velocity = pushDirection*addForcePower;
        }
        
    }

    
    private void OnInteract()
    {

    }
}

