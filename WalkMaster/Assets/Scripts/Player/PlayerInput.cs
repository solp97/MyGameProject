using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Camera PlayInCamera;
    Vector2 firstGetPoint;
    Vector2 mousePos;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //한 번 실행
        {
            StickManager.Instance.StickIsOn();
            firstGetPoint = Input.mousePosition;
        }

        if (Input.GetMouseButton(0)) // 누르고 있을때 쭉
        {
            Ray ray = PlayInCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            mousePos = Input.mousePosition;

            Vector2 pointToPosition = mousePos - firstGetPoint;
            Debug.Log($"찍음{pointToPosition}");

            StickManager.Instance.StickMove(firstGetPoint,mousePos);
        }

        if (Input.GetMouseButtonUp(0)) // 손에서 땔때 한 번 실행
        {
            StickManager.Instance.StickIsOff(); 
        }

    }
}
