using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GornyakSceneController : MonoBehaviour
{

    [SerializeField] private AnnaInThePotAnimationController _annaInThePotAnimationController;
    private void OnEnable()
    {
        _annaInThePotAnimationController.OnDanceFinished += LoadNextLevel;
    }
    
    private void OnDisable()
    {
        _annaInThePotAnimationController.OnDanceFinished -= LoadNextLevel;
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
