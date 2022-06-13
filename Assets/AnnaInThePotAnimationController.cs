using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AnnaInThePotAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [Inject] private GornyakAudioController _gornyakAudioController;
    private static readonly int ChickenDance = Animator.StringToHash("ChickenDance");

    private void OnEnable()
    {
        _gornyakAudioController.OnDialogueEnded += StartDanceAnimation;
    }

    private void StartDanceAnimation()
    {
        _animator.SetTrigger(ChickenDance);
    }
}
