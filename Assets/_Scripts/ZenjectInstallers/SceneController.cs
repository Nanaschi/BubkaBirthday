using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class SceneController: MonoBehaviour
{ 
    [Inject] private UIController _uiController;

    
    #region OnEnable/ OnDisable
    private void OnEnable()
    {
        _uiController.Start.onClick.AddListener(LoadNextLevel);
    }

    private void OnDisable()
    {
        _uiController.Start.onClick.RemoveListener(LoadNextLevel);
    }

    #endregion


    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}