using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DG.Tweening.Plugins;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraController : MonoBehaviour
{
    private CinemachineFreeLook cinemachine;
    private bool isMoveRight;
    private bool isMoveLeft;
    private float moveValue;
    private void Awake()
    {
        cinemachine = GetComponent<CinemachineFreeLook>();
    }

    private void Update()
    {
        if (isMoveLeft)
        {
            moveValue += -0.05f;
        }
        else
            moveValue -= -0.05f;
    }

    private void OnMoveRight()
    {
        
    }
}
