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
        if (Input.GetMouseButtonDown(0)) //�� �� ����
        {
            StickManager.Instance.StickIsOn();
            firstGetPoint = Input.mousePosition;
        }

        if (Input.GetMouseButton(0)) // ������ ������ ��
        {
            Ray ray = PlayInCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            mousePos = Input.mousePosition;

            Vector2 pointToPosition = mousePos - firstGetPoint;
            Debug.Log($"����{pointToPosition}");

            StickManager.Instance.StickMove(firstGetPoint,mousePos);
        }

        if (Input.GetMouseButtonUp(0)) // �տ��� ���� �� �� ����
        {
            StickManager.Instance.StickIsOff(); 
        }

    }
}
