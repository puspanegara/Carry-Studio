using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerMotor))]
public class GerakanPemainku : MonoBehaviour
{
    public Animator anim;

    [Header("Controls")] //Judul Pada Inspector
    CharacterMove controls;
    public float moveSpeed; //kecepatan bergerak
    public float rotateSpeed;//Kecepatan saat berputar ke kanan dan kiri
    public float jumpPower; //Kekuatan saat loncat
    public float gravity; //Besar gaya gravitasi yang digunakan
    public float addForcePower; //Besar gaya dorong yang diberikan

    [Header("Input Button")] //Judul pada Inspector untuk input button
    public string horizontalMove; //Jenis tombol yang digunakan, untuk berputar ke kanan dan kiri
    public string verticalMove;  //Jenis tombol yang digunakan, untuk maju dan mundur   
    public string jumpButton;  //Jenis tombol yang digunakan, untuk loncat

    public string multiButton; //Satu tombol yang digunakan, untuk berbagai hal

    private Vector3 moveDirection = Vector3.zero;
    public Rigidbody rb; //Menggunakan Komponen Rigidbody
    Camera cam;
    PlayerMotor motor;
    public GameObject Pause;
    //public GameObject InvetoryPanel; //Panel Inventory 

    public Interactable focus;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        //Invetory akan terbuka saat di tekan tombol X pada keyboard
        /*if (Input.GetKey(KeyCode.X))
        {
            //OpenmInventoryPanel();
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            //CloseInventoryPanel();
        }*/
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause.SetActive(true);
        }
    }

    //Membuat  Inventory di buka
    /*public void OpenmInventoryPanel()
    {
        //InvetoryPanel.SetActive(true);
    }
    public void CloseInventoryPanel()
    {
        //InvetoryPanel.SetActive(false);
    }
    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }
    */
    void RemoveFocus()
    {
        focus = null;
    }
    void Movement()
    {
        CharacterController controller = GetComponent<CharacterController>(); //Menggunakan CharacterController, terdapat pada inspector
                                                                              //Mengecek keberadaan diatas tanah
        anim = GetComponent<Animator>();

        if (controller.isGrounded)
        {
            //Membuat pemain agar dapat maju dan mundur 
            //Dengan inputan 'verticalMove'
            anim.SetFloat("Mlayu", 1);
            moveDirection = new Vector3(0, 0, Input.GetAxisRaw("Vertical")); //Berjalan Maju-Mundur

            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;
            anim.SetFloat("Mlayu", 1);
          

            //Pemain Loncat menggunakan 'jumpButton' 
            if (Input.GetButton(jumpButton))
                moveDirection.y = jumpPower;
        }
        moveDirection.y -= gravity * Time.deltaTime; //Saat akan loncat
        controller.Move(moveDirection * Time.deltaTime);

        //pemain berputar
        //Berputar kekanan kiri untuk melihat sekeliling
        //Menggunakan Axis Horizontal

        transform.Rotate(0, Input.GetAxisRaw("Horizontal"), 0);
        Debug.Log("loo");

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {

        Rigidbody rigid = hit.collider.attachedRigidbody;
        if (rigid != null && rigid.isKinematic == false)
        {
            //Membuat pemain dapat mendorong suatu benda yang ada di depannya
            Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
            rigid.velocity = pushDirection * addForcePower;
        }
    }
}
