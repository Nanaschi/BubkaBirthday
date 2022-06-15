using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;
using Zenject;

public class GornyakAudioController : BaseAudioController
{
   private float AudioLegth => _audioSource.clip.length;
   public event Action OnDialogueEnded;
   private void Start()
   {
      StartCoroutine(WaitTillDiealogueEnds());
   }

   private IEnumerator WaitTillDiealogueEnds()
   {
      yield return new WaitForSeconds(AudioLegth);
      DialogueEnded();
   }

   public void DialogueEnded()
   {
      OnDialogueEnded?.Invoke();
   }
}
