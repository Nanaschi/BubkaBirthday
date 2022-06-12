using System.Collections;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;

public class MainMenuAudioController : BaseAudioController
{
    private void Awake()
    {
        _audioSource.clip = _mainBackground.GetRandomElement();
    }

    private void Start()
    {
        _audioSource.Play();
    }
}
