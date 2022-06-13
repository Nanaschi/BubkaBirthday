using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinemachine;
using UnityEngine;

public class GornyakCameraController : BaseCameraController
{

    [SerializeField] private CinemachineVirtualCamera _camera1;

    private void Start()
    {
        StartCoroutine(SwitchTheCamera());
    }

    private IEnumerator SwitchTheCamera()
    {
        yield return new WaitForEndOfFrame();
        _camera1.Priority = 0;
    }
}