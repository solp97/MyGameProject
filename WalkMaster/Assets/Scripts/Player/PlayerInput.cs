using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Camera camera;
    public float moveMaxXDistance;
    public float moveMinXDistance;
    public float moveMaxYDistance;
    public float moveMinYDistance;
    public float maxRotate;
    public float minRotate;
    Ray ray;

    void Start()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
        }
    }

}
