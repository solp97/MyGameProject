using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickManager : Singleton<StickManager>
{
    public GameObject LeftStick;
    public GameObject RightStick;
    public GameObject PlayerObj;

    public float StickMoveMaxXDistance;
    public float StickMoveMinXDistance;
    public float StickMoveMaxYDistance;
    public float StickMoveMinYDistance;
    public float StickMaxRotate;
    public float StickMinRotate;

    private bool isLeftStickClick = false;
    private bool isRightStickClick = false;
    private enum stickChange { Left, Right };
    stickChange stickNum = stickChange.Right;
    // Start is called before the first frame update

    
    public void StickIsOn()
    {

        if (stickNum == stickChange.Left)
        {
           isLeftStickClick = true;
        }

        else if(stickNum == stickChange.Right)
        {
            isRightStickClick = true;
        }
    }

    public void StickMove(Vector2 FirstMousePos, Vector2 NowMousePos)
    {
        float dist = Vector2.Distance(FirstMousePos, NowMousePos);
        Debug.Log($"현재 거리{dist}");
    }

    public void StickIsOff()
    {
        if (stickNum == stickChange.Left)
        {
            isLeftStickClick = false;
        }

        else if(stickNum == stickChange.Right)
        {
            isRightStickClick = false;
        }

        StickChange();
    }

    public void StickChange()
    {
        if (stickNum == 0) stickNum = stickChange.Right;
        else stickNum = stickChange.Left;
        Debug.Log($"현재{stickNum}");
    }
}
