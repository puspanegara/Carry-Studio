using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMotor))]
public class CubeMove : MonoBehaviour
{
    [Header("Controls")]
    CharacterMove controls;
    //kecepatan bergerak
    public float moveSpeed;
    //Kecepatan saat berputar ke kanan dan kiri
    public float rotateSpeed;
    //Kekuatan saat loncat
    public float jumpPower;
    //Besar gaya gravitasi yang digunakan
    public  float gravity;
    //Besar gaya dorong yang diberikan
    public float addForcePower;

    [Header("Input Button")]
     /*
    Menulis jenis tombol yang digunakan 
    untuk berputar ke kanan dan kiri
    */
    public string horizontalMove;
   
    /*
    Menulis jenis tombol yang digunakan 
    untuk maju dan mundur
    */
    public string verticalMove;
     /*
        Jenis tombol yang digunakan
        untuk loncat
    */
    public string jumpButton;
     /*
        Satu tombol yang digunakan
        untuk berbagai hal 
    */
    public string multiButton;
    
    private Vector3 moveDirection =  Vector3.zero;
    public Rigidbody rb;
    public Interactable focus;
    public LayerMask movementMask;
    Camera cam; 
    PlayerMotor motor;

    // Start is called before the first frame update
    void Start() {
        cam = Camera.main;
        motor=GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray=cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100, movementMask))
            {
                motor.MoveToPoint(hit.point);
                RemoveFocus;
            }
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray=cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100, 100))
            {
                Interactable interactable=hit.collider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }

    void RemoveFocus()
    {
        focus = null;
    }
    void Movement()
    {
     CharacterController controller = GetComponent<CharacterController>();
            //Mengecek keberadaan diatas tanah
            if(controller.isGrounded) 
            {
                //Membuat pemain agar dapat maju dan mundur 
                //Dengan inputan 'verticalMove'
                moveDirection= new  Vector3 (0, 0, Input.GetAxis(verticalMove)); //Berjalan Maju
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= moveSpeed;

                //Pemain Loncat menggunakan 'jumpButton' 
                if(Input.GetButton(jumpButton))
                moveDirection.y = jumpPower;
            }
        moveDirection.y -= gravity *Time.deltaTime;
        controller.Move(moveDirection*Time.deltaTime); 

        //pemain berputar
        //Berputar kekanan kiri untuk melihat sekeliling
        //Menggunakan Axis Horizontal
        transform.Rotate(0, Input.GetAxis(horizontalMove), 0);  
    }

     void OnControllerColliderHit(ControllerColliderHit hit)
     {

        Rigidbody rigid= hit.collider.attachedRigidbody;
        if(rigid != null &&  rigid.isKinematic == false)
        {
            Vector3 pushDirection = new Vector3 (hit.moveDirection.x,0, hit.moveDirection.z);
            rigid.velocity = pushDirection*addForcePower;
        }
    }
    }
}

