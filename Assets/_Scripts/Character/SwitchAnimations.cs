using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _Scripts;
using UnityEngine;

public class SwitchAnimations : MonoBehaviour
{
   [SerializeField] private Animator _animator;

   private void Start()
   {
      _animator.SetTrigger(_animator.parameters.GetRandomElement().name);
   }
}
