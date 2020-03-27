
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    [Header("Input Controller")]

    public string horizontal;
    public string vertical;
    public string jump;

    [Header("Speed Controller")]
    public float speedMove;
    public float speedJump;
     public float theGravity;
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {


    }

    
    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        if(controller.isGrounded)
        {   
        moveDirection = new Vector3 (Input.GetAxis("horizontal"), 0, Input.GetAxis("vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speedMove;

        if(Input.GetKeyDown("jump"))
          moveDirection.y = speedJump;

        }

        moveDirection.y -= theGravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

    }

}
