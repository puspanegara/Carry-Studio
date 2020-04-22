using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCheck : MonoBehaviour
{
    public string nameToCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other) {
        if (other.name == nameToCheck)
        {
           switch (nameToCheck)
           {
                case "Box1":
                    GameManager.Instance.box1Correct = true;
                    break;

                case "Box2":
                    GameManager.Instance.box2Correct = true;
                    break;

                case "Box3":
                    GameManager.Instance.box3Correct = true;
                    break;

                case "Box4":
                    GameManager.Instance.box4Correct = true;
                    break;
           }
        }
        else
        {
            //Debug.Log("Place other box");
        }
    }
}
