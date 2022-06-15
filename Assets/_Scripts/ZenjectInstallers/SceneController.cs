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
        _uiController.Exit.onClick.AddListener(ExitApplication);
    }



    private void OnDisable()
    {
        _uiController.Start.onClick.RemoveListener(LoadNextLevel);
        _uiController.Exit.onClick.RemoveListener(ExitApplication);
    }

    #endregion


    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void ExitApplication()
    {
        Application.Quit();
        print("exit");
    }
}