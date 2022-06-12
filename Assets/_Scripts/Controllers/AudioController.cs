using System;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;
using Random = System.Random;

public class AudioController : MonoBehaviour
{

    [SerializeField] private List<AudioClip> _mainBackground;

    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource.clip = (AudioClip) _mainBackground.GetRandomElement();
    }

    private void Start()
    {
        _audioSource.Play();
    }
}
