using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    private GameObject[] _childs;
    private int childCount;

    public void Activate()
    {
        for (int i = 0; i < childCount; i++)
        {
            _childs[i].SetActive(true);
        }
    }

    private void Awake()
    {
        childCount =  transform.childCount;
        _childs = new GameObject[childCount];

        for(int i = 0; i < childCount; i++)
        {
            _childs[i] = transform.GetChild(i).gameObject;
        }
    }
    // Update is called once per frame
    private void OnEnable()
    {
        GameManager.Instance.GameOver.AddListener(Activate);
    }
    private void OnDisable()
    {
        GameManager.Instance.GameOver.RemoveListener(Activate);
    }

    // Update is called once per frame

}
