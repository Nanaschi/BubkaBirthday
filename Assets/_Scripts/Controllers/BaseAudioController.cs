using System;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;
using Random = System.Random;

public abstract class BaseAudioController : MonoBehaviour
{

    [SerializeField] protected List<AudioClip> _mainBackground;

    [SerializeField] protected AudioSource _audioSource;
}
