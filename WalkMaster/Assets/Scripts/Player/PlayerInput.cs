using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Camera PlayInCamera;
    public StickManager stick;
    Vector2 firstGetPoint;

    private void Start()
    {
        stick = GetComponent<StickManager>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            firstGetPoint = Input.mousePosition;
        }

        /*Debug.Log($"{mousePos}");*/
        if (Input.GetMouseButton(0))
        {
            Ray ray = PlayInCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            Vector2 mousePos = Input.mousePosition;
                Debug.Log($"ÂïÀ½{firstGetPoint - mousePos}");
        }

        if (Input.GetMouseButtonUp(0))
        {
            
        }

    }
}
