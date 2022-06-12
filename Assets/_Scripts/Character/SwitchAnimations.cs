using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SwitchAnimations : MonoBehaviour
{
   [SerializeField] private Animator _animator;

   private void Start()
   {
      var triggerParameters=_animator.parameters.Select
         (parameter => parameter.type == AnimatorControllerParameterType.Trigger);
      

   }
}
