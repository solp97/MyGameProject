using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickManager : MonoBehaviour
{
    public GameObject LeftStick;
    public GameObject RightStick;
    public float StickMoveMaxXDistance;
    public float StickMoveMinXDistance;
    public float StickMoveMaxYDistance;
    public float StickMoveMinYDistance;
    public float StickMaxRotate;
    public float StickMinRotate;

    private bool isStickClick = false;
    private enum stickChange { Left,Right};
    stickChange stickNum = 0;
    // Start is called before the first frame update
    void Awake ()
    {
        LeftStick = GetComponent<GameObject>();
        RightStick = GetComponent<GameObject>();
    }


    void StickIsOn()
    {
        isStickClick = true;

        if((int)stickNum == 0)
        {
            

        }

        if((int)stickNum == 1)
        {
            
        }
    }

    void StickIsOff()
    {
        StickChange();
    }

    void StickChange()
    {

    }
}
