using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinemachine;
using UnityEngine;

public class GornyakCameraController : BaseCameraController
{

    [SerializeField] private CinemachineVirtualCamera _camera1;

    private async void Start()
    {
        await SwitchTheCamera();
    }

    private async Task SwitchTheCamera()
    {
        await Task.Delay(10);
        _camera1.Priority = 0;
    }
}