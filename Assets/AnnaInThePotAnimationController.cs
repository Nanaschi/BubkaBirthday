using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AnnaInThePotAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [Inject] private GornyakAudioController _gornyakAudioController;
    [Inject] private GornyakUIController _gornyakUIController;
    
    private static readonly int ChickenDance = Animator.StringToHash("ChickenDance");
    private static readonly int DanceMultiplier = Animator.StringToHash("DanceMultiplier");

    
    
    private void OnEnable()
    {
        _gornyakAudioController.OnDialogueEnded += StartDanceAnimation;
        _gornyakUIController.Screen.onClick.AddListener(IncreaseAnimationSpeed);
    }
    
    private void OnDisable()
    {
        _gornyakAudioController.OnDialogueEnded -= StartDanceAnimation;
        _gornyakUIController.Screen.onClick.RemoveListener(IncreaseAnimationSpeed);
    }

    private void IncreaseAnimationSpeed()
    {
        print("increase!");
        _animator.SetFloat(DanceMultiplier, _animator.GetFloat(DanceMultiplier)+ .01f);
    }

    private void StartDanceAnimation()
    {
        _animator.SetTrigger(ChickenDance);
    }
}
