using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    public class KeyboardInput : MonoBehaviour
    {
        public string horizontalMove;
        public string verticalMove;
        void Update()
        {
            if (Input.GetButton(horizontalMove))
            {
                VirtualInputManager.Instance.moveHor = true;
            }
            else
            {
                VirtualInputManager.Instance.moveHor = false;
            }

            if (Input.GetButton(verticalMove))
            {
                VirtualInputManager.Instance.moveVer = true;
            }
            else
            {
                VirtualInputManager.Instance.moveVer = false;
            }
        }
    }
}
