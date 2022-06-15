using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.NiceVibrations;
using UnityEngine;
using Zenject;

public class AnnaInThePotAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [Inject] private GornyakAudioController _gornyakAudioController;
    [Inject] private GornyakUIController _gornyakUIController;
    [Inject] private Vibrator _vibrator;
    private static readonly int ChickenDance = Animator.StringToHash("ChickenDance");
    private static readonly int DanceMultiplier = Animator.StringToHash("DanceMultiplier");
    public event Action OnHalfDanced;
    bool crawlPossible = true;
    
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
        _animator.SetFloat(DanceMultiplier, _animator.GetFloat(DanceMultiplier)+ .1f);
        MMVibrationManager.Vibrate();
       
        if (_animator.GetFloat(DanceMultiplier) >= .3f && crawlPossible)
        {
            crawlPossible = false;
            OnHalfDanced?.Invoke();
        }

        if (_animator.GetFloat(DanceMultiplier) >= .3f && crawlPossible)
        {
            
        }
    }

    private void StartDanceAnimation()
    {
        _animator.SetTrigger(ChickenDance);
    }
}
