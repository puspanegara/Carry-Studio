using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterDuaa : MonoBehaviour
{
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
    public Animator anim;
    public GameObject PopUpBuku;
    private Vector3 moveDirection = Vector3.zero;
    public Rigidbody rb; //Menggunakan Komponen Rigidbody
    Camera cam;
    PlayerMotor motor;
    public GameObject InvetoryPanel; //Panel Inventory 

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
        if (Input.GetButton(multiButton))
        {
            InvetoryPanel.SetActive(true);
        }

    }

    //Membuat  Inventory di buka
    public void OpenmInventoryPanel()
    {
        InvetoryPanel.SetActive(true);
    }
    public void CloseInventoryPanel()
    {
        InvetoryPanel.SetActive(false);
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
        CharacterController controller = GetComponent<CharacterController>(); //Menggunakan CharacterController, terdapat pada inspector
                                                                              //Mengecek keberadaan diatas tanah
        if (controller.isGrounded)
        {
            //Membuat pemain agar dapat maju dan mundur 
            //Dengan inputan 'verticalMove'
            moveDirection = new Vector3(0, 0, Input.GetAxis(verticalMove)); //Berjalan Maju-Mundur
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;
            anim.SetFloat("jalandua", moveDirection.z);

            //Pemain Loncat menggunakan 'jumpButton' 
            if (Input.GetButton(jumpButton)) { 
                anim.SetBool("lompatdua", true);
            moveDirection.y = jumpPower;
            }
            else
            {
                anim.SetBool("lompatdua", false);
            }
    }
        moveDirection.y -= gravity * Time.deltaTime; //Saat akan loncat
        controller.Move(moveDirection * Time.deltaTime);

        //pemain berputar
        //Berputar kekanan kiri untuk melihat sekeliling
        //Menggunakan Axis Horizontal
        transform.Rotate(0, Input.GetAxis(horizontalMove), 0);
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PopUpBuku")
        {
            PopUpBuku.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PopUpBuku")
        {
            PopUpBuku.SetActive(false);
        }
    }
}
