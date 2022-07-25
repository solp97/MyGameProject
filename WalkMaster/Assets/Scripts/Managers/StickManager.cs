using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickManager : MonoBehaviour
{
    /*public GameObject LeftStick;
    public GameObject RightStick;*/
    public BoxCollider2D LeftStickCol;
    public BoxCollider2D RightStickCol;

    private bool isStickClick = false;
    private enum stickChange { Left,Right};
    stickChange stickNum = 0;
    // Start is called before the first frame update
    void Awake ()
    {
        /*LeftStick = GetComponent<GameObject>();
        RightStick = GetComponent<GameObject>();*/
        LeftStickCol = GetComponent<BoxCollider2D>();
        RightStickCol = GetComponent<BoxCollider2D>(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void click()
    {
        isStickClick = true;

        if((int)stickNum == 0)
        {
            LeftStickCol.enabled = false;   
        }

        if((int)stickNum == 1)
        {
            RightStickCol.enabled = false;
        }
    }
}
