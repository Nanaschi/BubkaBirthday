using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GornyakUIController : MonoBehaviour
{
    [field: SerializeField] public Button Screen { get; private set; }
    
    [Inject] private GornyakAudioController _gornyakUIController;

    private void OnEnable()
    {
        _gornyakUIController.OnDialogueEnded += SwitchOnButton;
    }

    private void SwitchOnButton()
    {
        Screen.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        _gornyakUIController.OnDialogueEnded -= SwitchOnButton;
    }
}
