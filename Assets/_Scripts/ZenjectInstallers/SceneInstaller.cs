using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace _Scripts.ZenjectInstallers
{
    public class SceneInstaller : MonoInstaller
    {

        [SerializeField] private SceneController _sceneController;
        [FormerlySerializedAs("_audioController")] [SerializeField] private BaseAudioController baseAudioController;
        [SerializeField] private UIController _uiController;
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BaseAudioController>().
                FromInstance(baseAudioController).AsSingle();
            
            Container.Bind<UIController>().FromInstance(_uiController).AsSingle();
            
        
            Container.BindInterfacesAndSelfTo<SceneController>().FromInstance(_sceneController).AsSingle();
        }
    }
}