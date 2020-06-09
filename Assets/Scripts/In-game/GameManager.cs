using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get {
            if(_instance == null)
            {
                GameObject go= new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    public bool box1Correct;
    public bool box2Correct;
    public bool box3Correct;
    public bool box4Correct;

    private Animator _doorAnimation;

    

     void Awake() {
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _doorAnimation = GameObject.Find("Door").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (box1Correct && box2Correct && box3Correct && box4Correct)
        {
            PlayerWins();
        }
    }

    void PlayerWins()
    {
        box1Correct = box2Correct = box3Correct = box4Correct = false;
        _doorAnimation.SetTrigger("openDoor");
    }
     
}
