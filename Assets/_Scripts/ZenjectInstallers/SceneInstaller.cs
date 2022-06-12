using UnityEngine;
using Zenject;

namespace _Scripts.ZenjectInstallers
{
    public class SceneInstaller : MonoInstaller
    {

        [SerializeField] private SceneController _sceneController;
        [SerializeField] private AudioController _audioController;
        [SerializeField] private UIController _uiController;
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<AudioController>().
                FromInstance(_audioController).AsSingle();
            
            Container.Bind<UIController>().FromInstance(_uiController).AsSingle();
            
        
            Container.BindInterfacesAndSelfTo<SceneController>().FromInstance(_sceneController).AsSingle();
        }
    }
}